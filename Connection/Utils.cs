using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Forms;
using SFTP_Files_Validator.Components;

namespace SFTP_Files_Validator.Connection
{
    class Utils
    {
        public static void Save(object connection, string path, string name)
        {
            XmlSerializer serializer = new XmlSerializer(connection.GetType());
            if (path != ".")
            {
                string[] paths = path.Split('/');
                string current = "";
                for (int i = 0; i < paths.Length; i++)
                {
                    current = $@"{current}/{paths[i]}".Trim('/');
                    if (!Directory.Exists(current))
                        Directory.CreateDirectory(current);
                }
            }
            
            using (FileStream fileStream = File.Open($"{path}/{name}.xml", FileMode.Create, FileAccess.Write))
            {
                serializer.Serialize(fileStream, connection);
                fileStream.Close();
            }
        }

        public static Object Read <T> (string name)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            FileStream fstream = File.Open(name, FileMode.Open);
            object obj = serializer.Deserialize(fstream);
            fstream.Close();
            fstream.Dispose();
            return obj;
        }

        public static bool ValidarFormulario(Control obj, ErrorProvider errorProvider)
        {
            bool errors = false;
            foreach (Control item in obj.Controls)
            {
                if (item is ErrorTextBox txtError)
                {
                    if (txtError.Validate)
                    {
                        if (txtError.OnlyNumbers)
                        {
                            if (!txtError.Text.All(char.IsDigit))
                            {
                                errorProvider.SetError(txtError, "Solo se admiten numeros");
                                errors = true;
                            }
                        }

                        if (string.IsNullOrEmpty(txtError.Text.Trim()))
                        {
                            errorProvider.SetError(txtError, "No puede estar en blanco");
                            errors = true;
                        }
                    }
                    else
                        errorProvider.SetError(txtError, "");
                }
            }
            return errors;
        }
    }
}
