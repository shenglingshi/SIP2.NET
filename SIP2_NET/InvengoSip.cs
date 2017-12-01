using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SIP2
{
    public class InvengoSip : IDisposable
    {
        #region private  field
        /// <summary>
        /// 服务器地址
        /// </summary>
        private IPEndPoint _remoteEP;
        /// <summary>
        /// Socket连接
        /// </summary>
        private Socket _sender = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sipCommand"></param>
        /// <returns></returns>
        private delegate string SipFactory(string sipCommand);
        private SipFactory sipFactory;
        #endregion

        #region public filed

        /// <summary>
        /// 同步对象
        /// </summary>
        public object syncRoot = new object();

        #endregion

        #region public method

        public bool Connect()
        {
            if (_remoteEP == null)
            {
                throw new ConnectionFailedException("未初始化服务器地址信息");
            }
            if (!_sender.Connected)
            {
                lock (syncRoot)
                {
                    if (!_sender.Connected)
                    {
                        try
                        {
                            _sender.Connect(_remoteEP.Address, _remoteEP.Port);
                        }
                        catch (Exception ex)
                        {
                            throw new ConnectionFailedException($"未能连接到Socket服务器:IP:{_remoteEP.Address.ToString()},IP:{_remoteEP.Port}", ex);
                        }
                    }
                }
            }

            return _sender.Connected;
        }


        #endregion


        public void Dispose()
        {
        }


        #region private method

        private string HandShake()
        {
            try
            {
                string rulesCommand = "9900302.0E";
                return sipFactory(rulesCommand);
            }
            catch (Exception)
            {
                return "0";  //  Highly unlikely that this will fail.  Hence try...catch logic vs. if...then logic.
            }
        }


        /// <summary>
        /// 获取日期字符串
        /// </summary>
        /// <returns></returns>
        private string GetDateString()
        {
            string year = DateTime.Now.Year.ToString("00");
            string month = DateTime.Now.Month.ToString("00");
            string day = DateTime.Now.Day.ToString("00");
            string ZZZZ = "    ";
            string hour = DateTime.Now.Hour.ToString("00");
            string minute = DateTime.Now.Minute.ToString("00");
            string second = DateTime.Now.Second.ToString("00");
            return year + month + day + ZZZZ + hour + minute + second;
        }

        #endregion

    }
}
