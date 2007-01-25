/*
 * IAjaxCryptProvider.cs
 * 
 * Copyright � 2006 Michael Schwarz (http://www.ajaxpro.info).
 * All Rights Reserved.
 * 
 * Permission is hereby granted, free of charge, to any person 
 * obtaining a copy of this software and associated documentation 
 * files (the "Software"), to deal in the Software without 
 * restriction, including without limitation the rights to use, 
 * copy, modify, merge, publish, distribute, sublicense, and/or 
 * sell copies of the Software, and to permit persons to whom the 
 * Software is furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be 
 * included in all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, 
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES 
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
 * IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR 
 * ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
 * CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN 
 * CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */
using System;

namespace AjaxPro
{
	public interface IAjaxCryptProvider
	{
        /// <summary>
        /// Encrypts the specified json.
        /// </summary>
        /// <param name="json">The json.</param>
        /// <returns></returns>
		string Encrypt(string json);
        /// <summary>
        /// Decrypts the specified jsoncrypt.
        /// </summary>
        /// <param name="jsoncrypt">The jsoncrypt.</param>
        /// <returns></returns>
		string Decrypt(string jsoncrypt);
        /// <summary>
        /// Sets the key provider.
        /// </summary>
        /// <value>The key provider.</value>
		IAjaxKeyProvider KeyProvider{set;}
        /// <summary>
        /// Gets the client script.
        /// </summary>
        /// <value>The client script.</value>
		string ClientScript{get;}
	}
}
