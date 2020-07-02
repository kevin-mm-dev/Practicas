using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatBoxN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtMsg.Select();
            listArrive.Items.Add("");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EJECUTAR();
        }
        private void txtMsg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                EJECUTAR();
            }
        }

        string user = "";
        //List<String> ListaRespuesta = new List<string>();
        string[] bankMsgHello = new string[] { "hola", "hey", "holi", "hello", "hi", "bonjour", "onda", "pex" };
        string[] bankAswHello = new string[] { "Hola! En que te puedo ayudar ?", "!Hola! Buen Dia", "Hola... Dime algo nuevo", "Hey! Crei que me habías abandondo", "Santos circuitos, Un humano!", "¡Hola! Necesitas algo?" };


        string[] bankMsgHello2 = new string[] { "estas", "encuentras" };
        string[] bankAswHello2 = new string[] { "Super bien! Y tu?", "!EXCELENTE! ¿Qué tal tu?", "Muy bien, gracias por preguntar", "Me encanta que se preocupen por mi" };


        string[] bankMsgSong1 = new string[] { "pero si le ponen la cancion", "Llorando lo comienza a llamar", "tusa" };
        string[] bankAswSong1 = new string[] { "U3yyyy nOOOOOOOO TUSA!" };

        string[] bankMsgExt = new string[] { "gracias", "yei", "excelente", "super", "listo", "ready", "fantastico", "bien", "igual", "divertido", "okey" };
        string[] bankAswExt = new string[] { "SÚPER !!!", "!Que haremos ahora?!", "Me alegra platicar contigo", "Yeeeiii!!", "Me estoy divirtiendo!" };


        string[] bankMsgG = new string[] { "puto", "pendejo", "verga", "idiota", "menso", "alv" };
        string[] bankAswG = new string[] { "!La tuya!", "Tu jefa :v", "Todo bien en casa?", "Casi... Te pregunto", "Ahora dilo sin llorar" };


        string[] bankMsgDo = new string[] { "hacer", "haces", "ases","comer","baila","cosa" };
        string[] bankAswDo = new string[] { "Solo digo adivinanzas, juego y te digo el clima :)" };


        string[] bankMsgRid = new string[] { "adivinanza", "chiste" };
        string[] bankAswRid = new string[] { "Okey, Ahí va!", "Okey... Deja recuerdo uno" };

        string[] bankMsgRiddles = new string[] { "¿Qué le dijo un pez a otro?", "Sube cargada y baja sin nada, Qué es?", "Mientras mas le quitas, mas crece ¿Qué es?" };
        string[] bankAswRiddles = new string[] { "nada", "la cuchara", "el hoyo" };
        string[] bankAswRiddlesR = new string[] { "Nada hahaha XD", "La cuchara:v hahaha", "El hoyo DUH" };



        string[] bankMsgGames = new string[] { "jugar", "juguemos" };

        string[] bankMsgWeather = new string[] { "clima", "tiempo", "weather" };

        string[] bankAswWeather = new string[] { "El clima es  9° C", "El clima es  -7° C", "El clima es  16° C" };
        string[] bankAswWeather2 = new string[] { "Pienso que no deberías salir sin un sueter", "Solo tengo 30% de mi sistema congelado", "La verdad me parece agradable!" };





        string[] bankAswError = new string[] { "Ups! No comprendí ", "Amm deberias escribir otra cosa ", "No entender te yo puedo SW <3 ", " Jajaja Escribe bien por favor " };
        /**
         * Hola || Hola! ¿Cómo estas? || Hola cómo estas? || hola Cómo estas
         * Hola! ¿Como estas? || Hola como estas? || hola Como estas
         *
         * OK
         * DIGA CLIMA
         * NUMEROS
         * BUG DICIENDO EL CLIMA
         *
         * ------------LUNES--------
         * 
         * reporte de analisis del sistema
         * como hace la descompocicion de entrada
         * Cuales son las evaluaciones de palabras clave
         * funciones exxplicarlas
         * como analizaste el texto
         * 
         */
        public void ClearLists()
        {
            if (listArrive.Items.Count >= 21)
            {
                listArrive.Items.RemoveAt(0);
                listArrive.Items.RemoveAt(0);
                listSent.Items.RemoveAt(0);
                listSent.Items.RemoveAt(0);
            }
        }
        List<string> listWords = new List<string>();
        Dictionary<string, int> oration = new Dictionary<string, int>();


        public void INICIO()
        {
            listWords.Clear();
            oration.Clear();

            ClearLists();

            string wrote = txtMsg.Text.ToLower();
            listSent.Items.Add("");
            listSent.Items.Add(txtMsg.Text);
            txtMsg.Text = "";
            string answer = "";
            string answer2 = "";
            int aux = 0;
            int aux2 = 1;
            for (int i = 0; i < wrote.Length; i++)
            {
                string character = wrote.Substring(aux, aux2);
                aux2++;
                if (character.Contains(" "))
                {
                    aux = aux + character.Length;
                    listWords.Add(character.Trim());
                    character = "";
                    aux2 = 1;
                }
                else
                {
                    answer2 = character.Trim();
                }
            }

            listWords.Add(answer2);

            foreach (var item in listWords)
            {
                answer = analizarMsg(item);
            }

            string theKey = "";
            int theValue = 0;
            Boolean error = false;

            foreach (var item in oration)
            {
                if (!error)
                {
                    if (item.Value == theValue)
                    {
                        error = true;
                    }
                    if (item.Value == 3)
                    {
                        if (item.Value > theValue)
                        {
                            theKey = item.Key;
                            theValue = 3;
                        }
                    }
                    if (item.Value == 2)
                    {
                        if (item.Value > theValue)
                        {
                            theKey = item.Key;
                            theValue = 2;
                        }
                    }
                    if (item.Value == 1)
                    {
                        if (item.Value > theValue)
                        {
                            theKey = item.Key;
                            theValue = 1;
                        }
                    }

                }

            }

            if (error)
            {
                listArrive.Items.Add("");
                listArrive.Items.Add("Veo que tienes dos peticiones en tu mensaje");
                key = "";
                status = "";
            }
            else
            {
                listArrive.Items.Add("");

                if (!answer.Equals(""))
                {
                    if (!key.Equals(""))
                    {
                        Comandos();
                    }
                    else
                    {
                        listArrive.Items.Add(answer);
                    }
                }
                else
                {

                    ////////////Errorsrs                    
                    var random = new Random();
                    numberMsj = random.Next(0, bankAswError.Count());
                    listArrive.Items.Add(bankAswError[numberMsj] + user);
                }
            }

            /// <summary>
            /// ///////////////////////////////////////////////////////////     BAKCUP
            /// </summary>
            /// 






        }


        public string analizarMsg(string msg)
        {
            string message = "";
            int numberMsj = -1;

            /////// HELLOS
            for (int i = 0; i < bankMsgHello.Length; i++)
            {
                string sentence = bankMsgHello[i];
                if (msg.Contains(sentence))
                {
                    var random = new Random();
                    numberMsj = random.Next(0, bankAswHello.Count());
                    message = bankAswHello[numberMsj];
                    try
                    {
                        oration.Add(message, 1);
                    }
                    catch (Exception)
                    {
                    }

                }
            }

            /////// HELLOS
            for (int i = 0; i < bankMsgHello2.Length; i++)
            {
                string sentence = bankMsgHello2[i];
                if (msg.Contains(sentence))
                {
                    var random = new Random();
                    numberMsj = random.Next(0, bankAswHello2.Count());
                    message = bankAswHello2[numberMsj];
                    try
                    {
                        oration.Add(message, 2);
                    }
                    catch (Exception)
                    {
                    }
                }
            }

            /////// G
            for (int i = 0; i < bankMsgG.Length; i++)
            {
                string sentence = bankMsgG[i];
                if (msg.Contains(sentence))
                {
                    var random = new Random();
                    numberMsj = random.Next(0, bankAswG.Count());
                    message = bankAswG[numberMsj];
                    try
                    {
                        oration.Add(message, 3);
                    }
                    catch (Exception)
                    {
                    }

                }
            }


            /////// EXTRAS
            for (int i = 0; i < bankMsgExt.Length; i++)
            {
                string sentence = bankMsgExt[i];
                if (msg.Contains(sentence))
                {
                    var random = new Random();
                    numberMsj = random.Next(0, bankAswExt.Count());
                    message = bankAswExt[numberMsj];
                    try
                    {
                        oration.Add(message, 2);
                    }
                    catch (Exception)
                    {
                    }

                }
            }

            /////// Song1
            for (int i = 0; i < bankMsgSong1.Length; i++)
            {
                string sentence = bankMsgSong1[i];
                if (msg.Contains(sentence))
                {
                    var random = new Random();
                    numberMsj = random.Next(0, bankAswSong1.Count());
                    message = bankAswSong1[numberMsj];
                    try
                    {
                        oration.Add(message, 1);
                    }
                    catch (Exception)
                    {
                    }


                }
            }
            ////////// Cosas hacer
            /////// VERIFICAR limite de respuestas
            for (int i = 0; i < bankMsgDo.Length; i++)
            {
                string sentence = bankMsgDo[i];
                if (msg.Contains(sentence))
                {
                    //var random = new Random();
                    //numberMsj = random.Next(0, 5);
                    message = bankAswDo[0];
                    try
                    {
                        oration.Add(message, 1);
                    }
                    catch (Exception)
                    {
                    }

                }
            }


            ////////  Riddles
            for (int i = 0; i < bankMsgRid.Length; i++)
            {
                string sentence = bankMsgRid[i];
                if (msg.Contains(sentence))
                {
                    var random = new Random();
                    numberMsj = random.Next(0, 1);
                    message = "commandA";
                    key = "riddles";
                    try
                    {
                        oration.Add(message, 3);
                    }
                    catch (Exception)
                    {
                    }

                    //Comandos();
                }
            }

            ////////  Games
            for (int i = 0; i < bankMsgGames.Length; i++)
            {
                string sentence = bankMsgGames[i];
                if (msg.Contains(sentence))
                {
                    var random = new Random();
                    numberMsj = random.Next(0, 1);
                    message = "commandG";
                    key = "Play";
                    try
                    {
                        oration.Add(message, 3);
                    }
                    catch (Exception)
                    {
                    }

                    //Comandos();
                }
            }


            ////////  Weather
            for (int i = 0; i < bankMsgWeather.Length; i++)
            {
                string sentence = bankMsgWeather[i];
                if (msg.Contains(sentence))
                {
                    var random = new Random();
                    numberMsj = random.Next(0, 1);
                    message = "commandC";
                    key = "Weather";
                    try
                    {
                        oration.Add(message, 3);
                    }
                    catch (Exception)
                    {
                    }

                    //Comandos();
                }
            }

            if (message.Equals(""))
            {
                try
                {
                    oration.Add("Error", 400);
                }
                catch (Exception)
                {

                }
            }
            return message;
        }




        public string key = "";
        public int IdKey = 0;

        public void EJECUTAR()
        {
            if (txtMsg.Text.Equals(""))
            {
                listArrive.Items.Add("");
                listArrive.Items.Add("Deberías escribir algo " + user);

            }
            else
            {

                if (user.Equals(""))
                {
                    user = txtMsg.Text;
                    listArrive.Items.Add("Hola! " + user);
                    listSent.Items.Add(txtMsg.Text);
                    txtMsg.Text = "";
                    listSent.Items.Add("");
                }
                else
                {

                    if (key.Equals(""))
                    {
                        INICIO();
                    }
                    else
                    {
                        Comandos();
                    }
                }
            }

        }
        // adivinanza
        //string conv = "";
        string status = "";
        int numberMsj = 0;
        int levelGame = 1;
        public void Comandos()
        {
            var random = new Random();
            ClearLists();
            switch (key)
            {
                case "Play":
                    if (status.Equals(""))
                    {

                        listArrive.Items.Clear();
                        listSent.Items.Clear();
                        numberMsj = random.Next(0, 3);
                        listArrive.Items.Add("");
                        listArrive.Items.Add("Provemos que tan buena memoria tienes " + user + "!!");
                        listArrive.Items.Add("Te dare unos numeros y tendras que decirme cual fue su orden");
                        listArrive.Items.Add("ESTAS LISTO?!");
                        status = "waitingAws";
                    }
                    else
                    {
                        string wrote = txtMsg.Text.ToLower();
                        if (wrote.Equals("si") || wrote.Equals("ok") || wrote.Equals("okey") || wrote.Equals("yes") || status.Equals("waitingAws2"))
                        {
                            if (status.Equals("waitingAws"))
                            {
                                listSent.Items.Add("");
                                listSent.Items.Add(wrote);
                                txtMsg.Text = "";
                                numberPlay = 0;
                                listArrive.Items.Add("Bien Aquí vamos! Los numeros son......");
                                timerPlay1.Enabled = true;
                                timerPlay1.Start();
                                status = "waitingAws2";
                            }
                            else
                            {
                                if (status.Equals("waitingAws2"))
                                {
                                    if (true)
                                    {
                                        listSent.Items.Add("");
                                        listSent.Items.Add(wrote);
                                        txtMsg.Text = "";
                                        if (wrote.Trim().Equals(charac))
                                        {
                                            listArrive.Items.Add("EXCELENTE!! Muy bien " + user);
                                            status = "";
                                            charac = "";
                                            //////////////////////////////Quitar este de querer segui jugando
                                            key = "";

                                        }
                                        else
                                        {
                                            listArrive.Items.Add("Oh Que mal! Quizas en otra ocasión");
                                            status = "";
                                            charac = "";
                                            key = "";

                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            listSent.Items.Add("");
                            listSent.Items.Add(wrote);
                            listArrive.Items.Add("Entiendo... Jugaremos en otro momento");
                            status = "";
                            txtMsg.Text = "";
                            charac = "";
                            key = "";

                        }

                    }

                    break;
                case "riddles":

                    if (status.Equals(""))
                    {
                        numberMsj = random.Next(0, 3);
                        listArrive.Items.Add("");
                        listArrive.Items.Add(bankMsgRiddles[numberMsj]);
                        status = "waitingAws";
                    }
                    else
                    {
                        if (status.Equals("waitingAws"))
                        {

                            string wrote = txtMsg.Text.ToLower();
                            listSent.Items.Add("");
                            listSent.Items.Add(wrote);
                            txtMsg.Text = "";
                            if (wrote.Contains(bankAswRiddles[numberMsj]))
                            {
                                listArrive.Items.Add("WOW! Eres muy bueno " + user + ":/");
                                key = "";
                            }
                            else
                            {
                                listArrive.Items.Add(bankAswRiddlesR[numberMsj]);
                                key = "";
                            }
                            status = "";
                        }
                    }

                    break;


                case "Weather":

                    if (status.Equals(""))
                    {
                        listArrive.Items.RemoveAt(0);
                        listArrive.Items.RemoveAt(0);
                        listSent.Items.RemoveAt(0);
                        listSent.Items.RemoveAt(0);
                        numberMsj = random.Next(0, 3);
                        listArrive.Items.Add("");
                        listArrive.Items.Add(bankAswWeather[numberMsj]);
                        status = "waitingAws";
                    }
                    else
                    {
                        string wrote = txtMsg.Text.ToLower();
                        listSent.Items.Add("");
                        listSent.Items.Add(wrote);
                        txtMsg.Text = "";
                        if (status.Equals("waitingAws2"))
                        {
                            listArrive.Items.Add("");
                            if (wrote.Contains("bien") || wrote.Contains("excelente") || wrote.Contains("nada") || wrote.Contains("agradable"))
                            {
                                listArrive.Items.Add("Me alegro mucho!");
                            }
                            if (wrote.Contains("regular") || wrote.Contains("quejo") || wrote.Contains("nada") || wrote.Contains("igual") || wrote.Contains("tambien"))
                            {
                                listArrive.Items.Add("Súper! Que quieres hacer ahora?");
                            }
                            if (wrote.Equals("mal") || wrote.Contains("horrible") || wrote.Contains("no me"))
                            {
                                listArrive.Items.Add("Oh... Que mal, pero seguro mejorará!");
                            }
                            status = "";
                            key = "";
                        }
                        if (status.Equals("waitingAws"))
                        {
                            if (wrote.Contains("parece") || wrote.Contains("piensas") || wrote.Contains("agrada") || wrote.Contains("gusta"))
                            {
                                listArrive.Items.Add("");
                                listArrive.Items.Add(bankAswWeather2[numberMsj]);
                                listArrive.Items.Add("A ti que te parece?");
                                status = "waitingAws2";
                            }
                            else
                            {
                                listArrive.Items.Add("");
                                listArrive.Items.Add("Okey... Creo que no quieres hablar sobre el clima");
                                status = "";
                                key = "";
                                EJECUTAR();
                            }
                        }


                    }

                    break;

                default:
                    break;
            }
        }



        private void btnVaciar_Click(object sender, EventArgs e)
        {
            listArrive.Items.Clear();
            listSent.Items.Clear();
            listArrive.Items.Add("");
            key = "";
            status = "";
        }

        int numberPlay = 0;
        string charac = "";
        private void timerPlay1_Tick(object sender, EventArgs e)
        {
            var random = new Random();
            numberMsj = random.Next(0, 9);
            txtTest.Text = numberMsj.ToString();
            numberPlay++;
            listArrive.Items.Add(numberMsj);
            int itt = levelGame + 5;
            if (numberPlay == itt)
            {
                timerPlay1.Stop();
                while (itt > 0)
                {
                    listArrive.Items.RemoveAt(listArrive.Items.Count - 1);
                    itt--;
                }
                listArrive.Items.Add("Cual ha sido la secuencia " + user + "?");
            }
            else
            {
                charac = charac + numberMsj.ToString();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timerPlay1.Enabled = true;
            timerPlay1.Start();

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timerPlay1.Stop();
        }
    }
}
