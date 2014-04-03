/*
 * Сделано в SharpDevelop.
 * Пользователь: Catfish
 * Дата: 01.04.2014
 * Время: 9:18
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ScriptEdition
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		
		void ListBox1DoubleClick(object sender, EventArgs e)
		{
			Clipboard.SetText(listBox1.Items[listBox1.SelectedIndex].ToString());
			richTextBox1.Paste();
		}
		
		void ListBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			toolStripStatusLabel3.Text = listBox1.Items[listBox1.SelectedIndex].ToString();
		}
		
		void ListBox1KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyData == Keys.Enter){
				Clipboard.SetText(listBox1.Items[listBox1.SelectedIndex].ToString());
				richTextBox1.Paste();
			}
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
	}
}
