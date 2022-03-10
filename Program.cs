using System;
using System.IO.Ports;
using System.Threading;
using System.Speech;
using System.Speech.Recognition;

namespace Speech_recognition
{
	class Program
	{
		static SpeechRecognitionEngine engine;
		static SerialPort _serialPort;
		public static void Main()
		{
			SpeechRecognitionEngine engine = new SpeechRecognitionEngine();
			_serialPort = new SerialPort();
			_serialPort.PortName = "COM3";
			_serialPort.BaudRate= 9600;
			_serialPort.Open();
			engine.SetInputToDefaultAudioDevice();
			GrammarBuilder gb = new GrammarBuilder(new Choices(new string[]{"Aggie", "cabron", "Asphyxiate", "Neurological", "hello"}));
			Grammar g = new Grammar(gb);
			engine.LoadGrammar(g);
			engine.RecognizeAsync(RecognizeMode.Multiple);
			engine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(engine_SpeechRecognized);
			Console.ReadLine();
		}
		static void engine_SpeechRecognized(object ob, SpeechRecognizedEventArgs e)
		{
			Console.WriteLine(e.Result.Text);
			_serialPort.Write("1");
		}
	}
}