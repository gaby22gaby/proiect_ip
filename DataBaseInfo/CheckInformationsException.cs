/**************************************************************************
 *                                                                        *
 *  File:        CheckInformationsException.cs                            *
 *  Copyright:   (c) 2021 , Balta Gabriel-Constantin                      *
 *  E-mail:      gabriel-constantin.balta@student.tuiasi.ro               *
 *  Description: Exceptions                                               *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using System;

namespace DataBaseInfo
{
    public class CheckInformationsException : Exception
    {
        #region Private Constants
        private string _message;
        #endregion

        #region Constructori
        public override string Message
        {
            get
            {
                return _message;
            }
        }
        public CheckInformationsException(string message)
        {
            _message = message;
        }
        #endregion
    }
}
