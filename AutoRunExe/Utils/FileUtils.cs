using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AutoRunExe.Utils
{
    public static class FileUtils
    {
        /*文件扩展名说明
             * 255216 jpg
             * 208207 doc xls ppt wps
             * 8075 docx pptx xlsx zip
             * 5150 txt
             * 8297 rar
             * 7790 exe
             * 3780 pdf      
             * 
             * 4946/104116 txt
             * 7173        gif 
             * 255216      jpg
             * 13780       png
             * 6677        bmp
             * 239187      txt,aspx,asp,sql
             * 208207      xls.doc.ppt
             * 6063        xml
             * 6033        htm,html
             * 4742        js
             * 8075        xlsx,zip,pptx,mmap,zip
             * 8297        rar   
             * 01          accdb,mdb
             * 7790        exe,dll
             * 5666        psd 
             * 255254      rdp 
             * 10056       bt种子 
             * 64101       bat 
             * 4059        sgf    
             */


        /// <summary>
        /// 判断是否是允许的文件类型；
        /// </summary>
        /// <param name="filePath">文件路径</param>
        /// <param name="typeCode"></param>
        /// <returns></returns>
        public static bool IsAllowedExtension(string filePath, string typeCode)
        {

            FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);
            string fileclass = "";
            try
            {
                for (int i = 0; i < 2; i++)
                {
                    fileclass += reader.ReadByte().ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }

            if (fileclass == typeCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 判断是否是exe文件；
        /// </summary>
        /// <param name="filePath">文件路径；</param>
        /// <returns>是 or 否</returns>
        public static bool IsExe(string filePath)
        {
            return FileUtils.IsAllowedExtension(filePath, "7790");
        }
    }
}
