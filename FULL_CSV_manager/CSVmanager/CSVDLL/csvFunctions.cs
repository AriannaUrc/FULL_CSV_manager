using System.Diagnostics;
using System.Text;

namespace CSVDLL
{
    public class csvFunctions
    {
        public struct dati
        {
            public string draw_date;
            public string winning_numbers;
            public int mega_ball;
            public int multiplier;
            public int miovalore;
            public bool cancLogic;
        }

        public int recordLength = 64;
        public string separator = ",";

        public dati d;
        public string FileName = "Lottery_Numbers.csv";
        public string BackUp = "BackUp.csv";
    


        //dato un comando lo esegue appogiandosi allo shell
        public static void ExecuteCommand(string Command, string Arguments = "", string Path = "", bool ShellExecute = true)
        {
            ProcessStartInfo ProcessInfo = new ProcessStartInfo(Command);

            if (Path != "")
            {
                ProcessInfo.WorkingDirectory = Path;
            }
            if (Arguments != "")
            {
                ProcessInfo.Arguments = Arguments;
            }
            ProcessInfo.CreateNoWindow = true;
            ProcessInfo.UseShellExecute = ShellExecute;

            //Process Process =
            Process.Start(ProcessInfo);
        }


        //rende il file utilizzabile per l'accesso diretto
        public static void Format(string BackUp, string FileName, string separator)
        {
            StreamReader sr = new StreamReader(BackUp);
            StreamWriter sw = new StreamWriter(FileName, false);

            string str = sr.ReadLine();
            Random random = new Random();

            while (str != null)
            {

                sw.WriteLine((str + separator + random.Next(10, 21).ToString() + separator + "true" + separator).PadRight(60) + "##");
                str = sr.ReadLine();
            }
            sw.Close();
            sr.Close();
        }

        public static void scriviAppend(string content, string filename)
        {
            var fStream = new FileStream(filename, FileMode.Append, FileAccess.Write, FileShare.Read);
            StreamWriter sw = new StreamWriter(fStream);
            sw.WriteLine(content);
            sw.Close();
        }

        //prende una variabile dati e la transforma per renderla idonea ad essere scritta sul file
        public static string FileString(dati d, string separator)
        {
            return ((d.draw_date + separator + d.winning_numbers + separator + d.mega_ball + separator + d.multiplier + separator + d.miovalore + separator + d.cancLogic + separator).PadRight(60) + "##");
        }

        public static dati FromString(string temp, string sep = ",")
        {
            //MessageBox.Show(temp);
            dati p;
            String[] fields = temp.Split(sep[0]);
            //MessageBox.Show(fields[3]);
            p.draw_date = fields[0];
            p.winning_numbers = fields[1];
            p.mega_ball = int.Parse(fields[2]);



            //controlla se il multiplier non é nullo
            if (fields[3] != "")
                p.multiplier = int.Parse(fields[3]);
            else
                p.multiplier = 1;

            p.miovalore = int.Parse(fields[4]);
            p.cancLogic = bool.Parse(fields[5]);

            //dalla stringa deve ritornare la variabile dati p settata con i valori estratti
            return p;
        }


        

        public static void AddFile(string drawDate, string WinNumbers, int MegaBall, int Multiplier, dati d, string separator, string FileName)
        {
            Random random = new Random();

            d.draw_date = drawDate;
            d.winning_numbers = WinNumbers;
            d.mega_ball = MegaBall;
            d.multiplier = Multiplier;
            d.miovalore = random.Next(10, 21);
            d.cancLogic = true;

            scriviAppend(FileString(d, separator), FileName);
        }


        //se c'é qualche valore non accettabile ritorna 1 se no 0
        public static int ModificaFile(string mod_draw_date, string target, string newvalue, string FileName, int recordLength, dati d, string separator)
        {
            String line;
            byte[] br;

            var f = new FileStream(FileName, FileMode.Open, FileAccess.ReadWrite);
            BinaryReader reader = new BinaryReader(f);
            BinaryWriter writer = new BinaryWriter(f);



            string[] words = new string[4];


            while (f.Position < f.Length - 2)
            {

                br = reader.ReadBytes(recordLength);
                //converte in stringa
                line = Encoding.ASCII.GetString(br, 0, br.Length);

                //estraggo dalla stringa i valori e gli inserisco il d
                d = FromString(line);

                if (d.draw_date == mod_draw_date && d.cancLogic == true)
                {
                    switch (target)
                    {
                        case "WinNumbers":
                            //MessageBox.Show("you are in modif winnumbers");
                            d.winning_numbers = newvalue;
                            break;

                        case "MegaBall":
                            if (int.TryParse(newvalue, out int number))
                            {
                                d.mega_ball = int.Parse(newvalue);
                            }
                            else
                            {
                                writer.Close();
                                reader.Close();
                                f.Close();
                                return 1;
                            }
                            break;

                        case "Multiplier":
                            if (int.TryParse(newvalue, out int number1))
                            {
                                d.multiplier = int.Parse(newvalue);
                            }
                            else
                            {
                                writer.Close();
                                reader.Close();
                                f.Close();
                                return 1;
                            }
                            break;

                        default:
                            writer.Close();
                            reader.Close();
                            f.Close();
                            return 1;
                    }


                    f.Seek(-recordLength, SeekOrigin.Current);
                    writer.Write(Encoding.UTF8.GetBytes(FileString(d, separator)));
                }

            }

            writer.Close();
            reader.Close();
            f.Close();

            return 0;
        }

        //return della stringa che deve essere mostrata all'utente
        public static string FindLineInFile(string find_target, string find_value, string FileName, int recordLength, dati d, string separator)
        {
            string line, output = "Non e stato trovato nessun oggetto che corrisponda ai criteri di ricerca";
            byte[] br;

            var f = new FileStream(FileName, FileMode.Open, FileAccess.ReadWrite);
            BinaryReader reader = new BinaryReader(f);
            BinaryWriter writer = new BinaryWriter(f);



            string[] words = new string[4];


            while (f.Position < f.Length - 2)
            {

                br = reader.ReadBytes(recordLength);
                //converte in stringa
                line = Encoding.ASCII.GetString(br, 0, br.Length);

                //estraggo dalla stringa i valori e gli inserisco il d
                d = FromString(line);


                switch (find_target)
                {

                    case "DrawDate":
                        if (d.draw_date == find_value && d.cancLogic == true)
                        {
                            output = line;
                        }
                        break;


                    case "WinNumbers":
                        if (d.winning_numbers == find_value && d.cancLogic == true)
                        {
                            output = line;
                        }
                        break;

                    case "MegaBall":
                        if (int.TryParse(find_value, out int number) && d.mega_ball == int.Parse(find_value) && d.cancLogic == true)
                        {
                            output = line;
                        }
                        break;

                    case "Multiplier":
                        if (int.TryParse(find_value, out int number1) && d.multiplier == int.Parse(find_value) && d.cancLogic == true)
                        {
                            output = line;
                        }
                        break;

                    default:
                        output = "dati non validi";
                        break;
                }


            }

            writer.Close();
            reader.Close();
            f.Close();

            return output;
        }



        public static int DeleteFile(string delete_target, string delete_value, string FileName, int recordLength, dati d, string separator)
        {

            String line;
            byte[] br;

            var f = new FileStream(FileName, FileMode.Open, FileAccess.ReadWrite);
            BinaryReader reader = new BinaryReader(f);
            BinaryWriter writer = new BinaryWriter(f);


            while (f.Position < f.Length - 2)
            {

                br = reader.ReadBytes(recordLength);
                //converte in stringa
                line = Encoding.ASCII.GetString(br, 0, br.Length);

                //estraggo dalla stringa i valori e gli inserisco il d
                d = FromString(line);

                //MessageBox.Show(line);

                switch (delete_target)
                {
                    case "DrawDate":
                        if (d.draw_date == delete_value)
                        {
                            d.cancLogic = false;

                            f.Seek(-recordLength, SeekOrigin.Current);
                            writer.Write(Encoding.UTF8.GetBytes(FileString(d, separator)));
                            //puts itself back to new line position
                            f.Seek(2, SeekOrigin.Current);
                        }
                        break;

                    case "WinNumbers":
                        if (d.winning_numbers == delete_value)
                        {
                            d.cancLogic = false;

                            f.Seek(-recordLength, SeekOrigin.Current);
                            writer.Write(Encoding.UTF8.GetBytes(FileString(d, separator)));
                            //puts itself back to new line position
                            f.Seek(2, SeekOrigin.Current);
                        }
                        break;

                    case "MegaBall":
                        if (int.TryParse(delete_value, out int number))
                        {
                            if (d.mega_ball == int.Parse(delete_value))
                            {
                                d.cancLogic = false;

                                f.Seek(-recordLength, SeekOrigin.Current);
                                writer.Write(Encoding.UTF8.GetBytes(FileString(d, separator)));
                                //puts itself back to new line position
                                f.Seek(2, SeekOrigin.Current);
                            }
                        }
                        break;

                    case "Multiplier":
                        if (int.TryParse(delete_value, out int number1))
                        {
                            if (d.multiplier == int.Parse(delete_value))
                            {
                                d.cancLogic = false;

                                f.Seek(-recordLength, SeekOrigin.Current);
                                writer.Write(Encoding.UTF8.GetBytes(FileString(d, separator)));
                                //puts itself back to new line position
                                f.Seek(2, SeekOrigin.Current);
                            }
                        }
                        break;


                    case "MioValore":
                        if (int.TryParse(delete_value, out int number2))
                        {
                            if (d.miovalore == int.Parse(delete_value))
                            {
                                d.cancLogic = false;

                                //MessageBox.Show(FileString(d));

                                f.Seek(-recordLength, SeekOrigin.Current);
                                writer.Write(Encoding.UTF8.GetBytes(FileString(d, separator)));
                                //puts itself back to new line position
                                f.Seek(2, SeekOrigin.Current);
                            }
                        }
                        break;

                    default:
                        writer.Close();
                        reader.Close();
                        f.Close();
                        return 1;
                }

            }

            writer.Close();
            reader.Close();
            f.Close();
            return 0;
        }

        public static int findNumberOfFields(string FileName, int recordLength, dati d, string separator)
        {
            String line;
            byte[] br;

            var f = new FileStream(FileName, FileMode.Open, FileAccess.ReadWrite);
            BinaryReader reader = new BinaryReader(f);



            string[] words = new string[4];


            br = reader.ReadBytes(recordLength);
            //converte in stringa
            line = Encoding.ASCII.GetString(br, 0, br.Length);

            //estraggo dalla stringa i valori e gli inserisco il d

            String[] fields = line.Split(separator);


            reader.Close();
            f.Close();

            //meno 1 per tenere in considerazione l'ultima virgola
            return fields.Length - 1;
        }

        public static int MaxFieldLenght(string FileName, int recordLength, dati d, string separator)
        {
            int maxLenght = 0;

            String line;
            byte[] br;

            var f = new FileStream(FileName, FileMode.Open, FileAccess.ReadWrite);
            BinaryReader reader = new BinaryReader(f);


            while (f.Position < f.Length - 2)
            {
                br = reader.ReadBytes(recordLength);
                //converte in stringa
                line = Encoding.ASCII.GetString(br, 0, br.Length);

                if (d.cancLogic == true)
                {
                    //estraggo dalla stringa i valori e gli inserisco il d
                    String[] fields = line.Split(separator);


                    for (int i = 0; i < fields.Length - 1; i++)
                        if (maxLenght < fields[i].Length)
                        {
                            maxLenght = fields[i].Length;
                        }
                }

            }

            reader.Close();
            f.Close();

            //meno 1 per tenere in considerazione l'ultima virgola
            return maxLenght;
        }
    }
}