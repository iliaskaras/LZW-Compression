using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCompressionLzwFormApplication
{
    public static class BinaryByteConverterController
    {

        /* binaryToBytes :
         * Transform a binary sequence string into bytes of 8 bits */

        public static byte[] binaryToBytes(this string compressedBinaryText)
        {
            List<byte> byteList = new List<byte>();
            StringBuilder finalCompressedBinaryText = new StringBuilder();
            string eightBitText = null;

            for (int i = 0; i <= compressedBinaryText.Length; i += 8)
            {
                eightBitText = null;
               
                if (i + 8 > compressedBinaryText.Length)
                {
                    int j = 0;
                    eightBitText = compressedBinaryText.Substring(i, compressedBinaryText.Length - i);
                    StringBuilder eightBitTextSB = new StringBuilder();
                    eightBitTextSB.Append(eightBitText);
                    for( j=0;j<(8 - eightBitText.Length);j+=1)
                    {
                        eightBitTextSB.Append("0");
                    }
                    
                    eightBitText = eightBitTextSB.ToString();
                }
                else
                {
                    eightBitText = compressedBinaryText.Substring(i, 8);
                    
                }
                byte convertedByte = Convert.ToByte(eightBitText,2);
                byteList.Add(convertedByte);
            }

            return byteList.ToArray();
        }

        /* compressedBytesToCodelenBytes :
         * 1) Calls the method getCompressedBinarySequence, that converts the bytes into a binary Sequence
         * 2) Convert that binary Sequence into code length Bytes */

        public static string compressedBytesToCodelenBytes(this byte[] decodedBytes, int maxCodeLen)
        {
            DateTime TimeDate1 = DateTime.Now;

            int totalAsciiDictionaryCounter = 255;
            string compressedBinarySequence = null;
            StringBuilder finalCompressedBinarySequence = new StringBuilder();
            int codeLen = 9;
            string currentByte = null;


            compressedBinarySequence = decodedBytes.getCompressedBinarySequence();
            for (int i = 0; i < compressedBinarySequence.Length; i += codeLen)
            {
                if (totalAsciiDictionaryCounter >= Math.Pow(2, maxCodeLen) - 1)
                {
                    codeLen = 9;
                    totalAsciiDictionaryCounter = 255;
                }

                if (i + codeLen > compressedBinarySequence.Length)
                {
                    
                    currentByte = compressedBinarySequence.Substring(i, compressedBinarySequence.Length - i);
                }
                else
                {
                    currentByte = compressedBinarySequence.Substring(i, codeLen);

                    totalAsciiDictionaryCounter += 1;

                   
                    if ((totalAsciiDictionaryCounter > Math.Pow(2, codeLen) - 1))
                    {
                        
                        codeLen += 1;
                        
                        
                        currentByte = compressedBinarySequence.Substring(i, codeLen);
                        finalCompressedBinarySequence.Append(currentByte);
                    }
                    else
                    {

                        currentByte = compressedBinarySequence.Substring(i, codeLen);
                        finalCompressedBinarySequence.Append(currentByte);
                    }
                }

            }

            DateTime TimeDate2 = DateTime.Now;
            return finalCompressedBinarySequence.ToString();
        }

        /* getCompressedCodeWordList : 
         * Converts the code length sequences of bits into integers */

        public static List<int> getCompressedCodeWordList(this string compressedBinarySequence, int maxCodeLen)
        {
            DateTime TimeDate1 = DateTime.Now;

            List<int> compressedCodeWordList = new List<int>();
            int codeLen = 9;
            string currentByte = null;
            int totalAsciiDictionaryCounter = 255;

            for (int i = 0; i < compressedBinarySequence.Length; i += codeLen)
            {
                if (totalAsciiDictionaryCounter >= Math.Pow(2, maxCodeLen) - 1)
                {
                    totalAsciiDictionaryCounter = 255;
                    codeLen = 9;
                }

                    if (i + codeLen > compressedBinarySequence.Length)
                    {
                        currentByte = compressedBinarySequence.Substring(i, compressedBinarySequence.Length - i);
                        compressedCodeWordList.Add(System.Math.Abs(Convert.ToInt32(currentByte, 2)));
                        totalAsciiDictionaryCounter += 1;
                    }
                    else
                    {
                        currentByte = compressedBinarySequence.Substring(i, codeLen);
                        totalAsciiDictionaryCounter += 1;
                        if ((totalAsciiDictionaryCounter > Math.Pow(2, codeLen) - 1))
                        {
                            codeLen += 1;
                            
                            currentByte = compressedBinarySequence.Substring(i, codeLen);
                            compressedCodeWordList.Add(System.Math.Abs(Convert.ToInt32(currentByte, 2)));
                          
                        }
                        else
                        {
                            currentByte = compressedBinarySequence.Substring(i, codeLen);
                            compressedCodeWordList.Add(System.Math.Abs(Convert.ToInt32(currentByte, 2)));
                        }
                    }

               

            }

            DateTime TimeDate2 = DateTime.Now;
            return compressedCodeWordList;
        }

        /* getCompressedBinarySequence : 
         * Simple converts the bytes into its binary string sequence */

        public static string getCompressedBinarySequence(this byte[] compressedBytes)
        {
            StringBuilder compressedBinaryForm = new StringBuilder();
            
            // We add all the decoded bytes in binary form into a StringBuilder sequence
            foreach (var currentDecodedByte in compressedBytes)
            {
                compressedBinaryForm.Append(Convert.ToString(currentDecodedByte, 2).fillWithZero(8));
            }
           

            return compressedBinaryForm.ToString();
        }

        public static string fillWithZero(this string value, int length)
        {
            while (value.Length < length)
            {
                value = "0" + value;
            }

            return value;
        }

    }
}
