using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe_STD_
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";

            List<Button> buttons = new List<Button>();
            int x = 0;
            int y = 0;
            for (int i = 0; i < 9; i++)
            {
                buttons.Add(new Button()
                {
                    Name = i.ToString(),
                    Location = new Point(x, y),
                    Size = new Size(100, 100)
                });
                //buttons[i].Click += Button_Click;
                this.Controls.Add(buttons[i]);
                x += 100;
                if (i == 2 || i == 5)
                {
                    x = 0;
                    y += 100;
                }
            }
        }

        #endregion
    }
}

