﻿
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSiete = new System.Windows.Forms.Button();
            this.btnNueve = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.btnOcho = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnDos = new System.Windows.Forms.Button();
            this.btnUno = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCuatro = new System.Windows.Forms.Button();
            this.btnCero = new System.Windows.Forms.Button();
            this.btnSigno = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnCuadrado = new System.Windows.Forms.Button();
            this.btnRaizCuadrada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(12, 29);
            this.txtResultado.MaxLength = 21;
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(321, 40);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.Text = "0";
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnSiete
            // 
            this.btnSiete.Location = new System.Drawing.Point(12, 149);
            this.btnSiete.Name = "btnSiete";
            this.btnSiete.Size = new System.Drawing.Size(55, 55);
            this.btnSiete.TabIndex = 2;
            this.btnSiete.Text = "7";
            this.btnSiete.UseVisualStyleBackColor = true;
            this.btnSiete.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnNueve
            // 
            this.btnNueve.Location = new System.Drawing.Point(135, 149);
            this.btnNueve.Name = "btnNueve";
            this.btnNueve.Size = new System.Drawing.Size(55, 55);
            this.btnNueve.TabIndex = 3;
            this.btnNueve.Text = "9";
            this.btnNueve.UseVisualStyleBackColor = true;
            this.btnNueve.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(135, 88);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(55, 55);
            this.btnQuitar.TabIndex = 4;
            this.btnQuitar.Text = "⌫";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.Location = new System.Drawing.Point(134, 210);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(55, 55);
            this.btnSeis.TabIndex = 5;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = true;
            this.btnSeis.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnTres
            // 
            this.btnTres.Location = new System.Drawing.Point(134, 271);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(55, 55);
            this.btnTres.TabIndex = 6;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = true;
            this.btnTres.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnPunto
            // 
            this.btnPunto.Location = new System.Drawing.Point(135, 332);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(55, 55);
            this.btnPunto.TabIndex = 7;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.Location = new System.Drawing.Point(74, 88);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(55, 55);
            this.btnBorrarTodo.TabIndex = 8;
            this.btnBorrarTodo.Text = "C";
            this.btnBorrarTodo.UseVisualStyleBackColor = true;
            this.btnBorrarTodo.Click += new System.EventHandler(this.btnBorrarTodo_Click);
            // 
            // btnOcho
            // 
            this.btnOcho.Location = new System.Drawing.Point(74, 149);
            this.btnOcho.Name = "btnOcho";
            this.btnOcho.Size = new System.Drawing.Size(55, 55);
            this.btnOcho.TabIndex = 9;
            this.btnOcho.Text = "8";
            this.btnOcho.UseVisualStyleBackColor = true;
            this.btnOcho.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnCinco
            // 
            this.btnCinco.Location = new System.Drawing.Point(73, 210);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(55, 55);
            this.btnCinco.TabIndex = 10;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = true;
            this.btnCinco.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnDos
            // 
            this.btnDos.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnDos.Location = new System.Drawing.Point(73, 271);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(55, 55);
            this.btnDos.TabIndex = 11;
            this.btnDos.Text = "2";
            this.btnDos.UseVisualStyleBackColor = true;
            this.btnDos.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnUno
            // 
            this.btnUno.Location = new System.Drawing.Point(12, 271);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(55, 55);
            this.btnUno.TabIndex = 12;
            this.btnUno.Text = "1";
            this.btnUno.UseVisualStyleBackColor = true;
            this.btnUno.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(12, 88);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(55, 55);
            this.btnBorrar.TabIndex = 13;
            this.btnBorrar.Text = "CE";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCuatro
            // 
            this.btnCuatro.Location = new System.Drawing.Point(12, 210);
            this.btnCuatro.Name = "btnCuatro";
            this.btnCuatro.Size = new System.Drawing.Size(55, 55);
            this.btnCuatro.TabIndex = 14;
            this.btnCuatro.Text = "4";
            this.btnCuatro.UseVisualStyleBackColor = true;
            this.btnCuatro.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnCero
            // 
            this.btnCero.Location = new System.Drawing.Point(73, 332);
            this.btnCero.Name = "btnCero";
            this.btnCero.Size = new System.Drawing.Size(55, 55);
            this.btnCero.TabIndex = 15;
            this.btnCero.Text = "0";
            this.btnCero.UseVisualStyleBackColor = true;
            this.btnCero.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnSigno
            // 
            this.btnSigno.Location = new System.Drawing.Point(12, 332);
            this.btnSigno.Name = "btnSigno";
            this.btnSigno.Size = new System.Drawing.Size(55, 55);
            this.btnSigno.TabIndex = 16;
            this.btnSigno.Text = "+/-";
            this.btnSigno.UseVisualStyleBackColor = true;
            this.btnSigno.Click += new System.EventHandler(this.btnSigno_Click);
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(214, 271);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(119, 55);
            this.btnResultado.TabIndex = 17;
            this.btnResultado.Tag = "=";
            this.btnResultado.Text = "=";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(214, 210);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(55, 55);
            this.btnSumar.TabIndex = 18;
            this.btnSumar.Tag = "+";
            this.btnSumar.Text = "+";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnRestar
            // 
            this.btnRestar.Location = new System.Drawing.Point(278, 210);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(55, 55);
            this.btnRestar.TabIndex = 19;
            this.btnRestar.Tag = "-";
            this.btnRestar.Text = "-";
            this.btnRestar.UseVisualStyleBackColor = true;
            this.btnRestar.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.Location = new System.Drawing.Point(278, 149);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(55, 55);
            this.btnMultiplicar.TabIndex = 20;
            this.btnMultiplicar.Tag = "x";
            this.btnMultiplicar.Text = "*";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicacion_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(214, 149);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(55, 55);
            this.btnDividir.TabIndex = 21;
            this.btnDividir.Tag = "÷";
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnCuadrado
            // 
            this.btnCuadrado.Location = new System.Drawing.Point(278, 88);
            this.btnCuadrado.Name = "btnCuadrado";
            this.btnCuadrado.Size = new System.Drawing.Size(55, 55);
            this.btnCuadrado.TabIndex = 22;
            this.btnCuadrado.Tag = "²";
            this.btnCuadrado.Text = "x²";
            this.btnCuadrado.UseVisualStyleBackColor = true;
            this.btnCuadrado.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnRaizCuadrada
            // 
            this.btnRaizCuadrada.Location = new System.Drawing.Point(214, 88);
            this.btnRaizCuadrada.Name = "btnRaizCuadrada";
            this.btnRaizCuadrada.Size = new System.Drawing.Size(55, 55);
            this.btnRaizCuadrada.TabIndex = 23;
            this.btnRaizCuadrada.Tag = " √";
            this.btnRaizCuadrada.Text = "  √";
            this.btnRaizCuadrada.UseVisualStyleBackColor = true;
            this.btnRaizCuadrada.Click += new System.EventHandler(this.clickOperador);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(345, 393);
            this.Controls.Add(this.btnRaizCuadrada);
            this.Controls.Add(this.btnCuadrado);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.btnSigno);
            this.Controls.Add(this.btnCero);
            this.Controls.Add(this.btnCuatro);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnUno);
            this.Controls.Add(this.btnDos);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnOcho);
            this.Controls.Add(this.btnBorrarTodo);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnNueve);
            this.Controls.Add(this.btnSiete);
            this.Controls.Add(this.txtResultado);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnSiete;
        private System.Windows.Forms.Button btnNueve;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btnBorrarTodo;
        private System.Windows.Forms.Button btnOcho;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCuatro;
        private System.Windows.Forms.Button btnCero;
        private System.Windows.Forms.Button btnSigno;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnCuadrado;
        private System.Windows.Forms.Button btnRaizCuadrada;
    }
}

