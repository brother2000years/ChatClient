using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;

using System.Threading;
using ChatLib;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;
namespace ChatClient
{
    public partial class Form1 : Form
    {
        private TcpClient currentClient;
        private Thread thMsgAccepting;
        // Клиент в сети
        private bool online;
        public Form1()
        {
            LoggerEvs.messageCame += addMessageToMessagesHistory;            
            InitializeComponent();
            tbIpAddr.Text = "127.0.0.1";
            tbPort.Text = "11000";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {            
            sendMessageToServer(tbNickname.Text, tbMessage.Text);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            disconnectFromServer();
        }

        private void disconnectFromServer()
        {
            try
            {
                if (currentClient.Connected)
                {
                    IFormatter formatter = new BinaryFormatter();
                    NetworkStream stream = currentClient.GetStream();
                    // Клиент отсоединился
                    online = false;
                    // Отправить серверу запрос на отключение
                    formatter.Serialize(stream, Requests.CloseConnection);
                    // Отправить серверу никнейм отключившегося пользователя
                    formatter.Serialize(stream, tbNickname.Text);
                    currentClient.Close();
                }
            }
            catch (Exception ex)
            {
                LoggerEvs.writeLog("Проблемы с отключением от сервера.");
            }            
        }        

        private void btnEnterToChat_Click(object sender, EventArgs e)
        {
            if (checkNickname())
            {
                try
                {
                    connectToServer();
                    setupWidgsAfterConnection();
                    // Запустить прием сообщений
                    thMsgAccepting = new Thread(delegate() { acceptMessageFromServer(); });
                    thMsgAccepting.Start();                    
                }
                catch (Exception ex)
                {
                    String error = ex.ToString();//"Ошибка при подключении к серверу";
                    LoggerEvs.writeLog(error);
                    MessageBox.Show(error);
                }
            }
        }

        private void setupWidgsAfterConnection()
        {
            tbMessage.Enabled = true;
            btnSend.Enabled = true;
            tbIpAddr.Enabled = false;
            tbPort.Enabled = false;
            btnDisconnect.Enabled = true;
            rtbMessages.Enabled = true;
        }

        private void connectToServer()
        {
            String ipAddr = tbIpAddr.Text;
            int port = int.Parse(tbPort.Text);
            // Присоединиться к серверу
            currentClient = new TcpClient(ipAddr, port);
            sendMessageToServer(tbNickname.Text, " connected.");
            tbNickname.Enabled = false;
            btnEnterToChat.Enabled = false;
        }
        
        private bool checkNickname()
        {
            bool validNickname = true;
            if (tbNickname.Text.Length == 0)
            {
                MessageBox.Show("Никнейм не может быть пустым");
                validNickname = false;
            }
            foreach (var character in tbNickname.Text)
            {
                if (!Char.IsLetter(character) && !Char.IsDigit(character))
                {
                    validNickname = false;
                    MessageBox.Show("Никнейм может содержать только буквы и цифры");
                }
            }
            return validNickname;
        }

        /// <summary>
        /// Отправить сообщение на сервер
        /// </summary>
        /// <param name="nickname">Никнейм отправителя</param>
        /// <param name="messageText">Текст сообщения</param>
        void sendMessageToServer(string nickname, string messageText)
        {
            IFormatter formatter = new BinaryFormatter();
            NetworkStream stream = currentClient.GetStream();
            UsualMessage msg = new UsualMessage(messageText, nickname);
            // Отправить запрос
            formatter.Serialize(stream, Requests.NewMessage);
            // Отправить сообщение
            formatter.Serialize(stream, msg);
            tbMessage.Clear();
        }

        /// <summary>
        /// Принять сообщение с сервера
        /// </summary>
        void acceptMessageFromServer()
        {            
            IFormatter formatter = new BinaryFormatter();
            NetworkStream stream = currentClient.GetStream();
            // Клиент находится в сети
            online = true;
            while (online)
            {
                try
                {
                    string msg = (string)formatter.Deserialize(stream);
                    this.BeginInvoke((MethodInvoker)delegate()
                    {
                        LoggerEvs.writeLog(msg);
                    });
                }
                catch(Exception ex)
                {
                    LoggerEvs.writeLog("Соединение с сервером разорвано.");
                    // Клиент больше не в сети
                    online = false;
                }
            }            
        }

        /// <summary>
        /// Добавить сообщение в историю
        /// </summary>
        /// <param name="msg">Сообщение</param>
        void addMessageToMessagesHistory(string msg)
        {
            rtbMessages.AppendText(msg);
            rtbMessages.ScrollToCaret();
        }

        private void tbMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                sendMessageToServer(tbNickname.Text, tbMessage.Text);                                
            }
        }

        private void tbMessage_TextChanged(object sender, EventArgs e)
        {               
            if (tbMessage.Text.Length == 2 && tbMessage.Text[0] == '\r' && tbMessage.Text[1] == '\n')
            {                
                tbMessage.Clear();
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            disconnectFromServer();
            setupWidgsAfterDisconnection();
        }

        private void setupWidgsAfterDisconnection()
        {
            tbIpAddr.Enabled = true;
            tbMessage.Enabled = false;
            tbPort.Enabled = true;
            tbNickname.Enabled = true;
            btnSend.Enabled = false;
            btnDisconnect.Enabled = false;
            btnEnterToChat.Enabled = true;
            rtbMessages.Enabled = false;
        }

    }
}
