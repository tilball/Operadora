namespace Operadora
{
    partial class frm_principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.grp_operadoras = new System.Windows.Forms.GroupBox();
            this.btn_Oi = new System.Windows.Forms.RadioButton();
            this.btn_Tim = new System.Windows.Forms.RadioButton();
            this.btn_Claro = new System.Windows.Forms.RadioButton();
            this.btn_Vivo = new System.Windows.Forms.RadioButton();
            this.lbl_BemVindo = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_OperadoraSelecionada = new System.Windows.Forms.Label();
            this.txt_OperadoraSelecionada = new System.Windows.Forms.TextBox();
            this.lbl_DDD = new System.Windows.Forms.Label();
            this.txt_DDD = new System.Windows.Forms.TextBox();
            this.lbl_NumerodeCelular = new System.Windows.Forms.Label();
            this.Txt_NumerodeCelular = new System.Windows.Forms.TextBox();
            this.lbl_ValorRecarga = new System.Windows.Forms.Label();
            this.txt_ValorRecarga = new System.Windows.Forms.TextBox();
            this.btn_RS1 = new System.Windows.Forms.Button();
            this.btn_RS2 = new System.Windows.Forms.Button();
            this.btn_RS3 = new System.Windows.Forms.Button();
            this.btn_RS4 = new System.Windows.Forms.Button();
            this.lbl_Validade1 = new System.Windows.Forms.Label();
            this.lalbl_Validade2 = new System.Windows.Forms.Label();
            this.lbl_Validade3 = new System.Windows.Forms.Label();
            this.lbl_Validade4 = new System.Windows.Forms.Label();
            this.lbl_Validade5 = new System.Windows.Forms.Label();
            this.btn_RS5 = new System.Windows.Forms.Button();
            this.lbl_Validade6 = new System.Windows.Forms.Label();
            this.btn_RS6 = new System.Windows.Forms.Button();
            this.lbl_Validade7 = new System.Windows.Forms.Label();
            this.btn_RS7 = new System.Windows.Forms.Button();
            this.lbl_Validade8 = new System.Windows.Forms.Label();
            this.btn_RS8 = new System.Windows.Forms.Button();
            this.lbl_SelecioneValor = new System.Windows.Forms.Label();
            this.pcb_image = new System.Windows.Forms.PictureBox();
            this.grp_operadoras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_image)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dados da Recarga";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grp_operadoras
            // 
            this.grp_operadoras.Controls.Add(this.btn_Oi);
            this.grp_operadoras.Controls.Add(this.btn_Tim);
            this.grp_operadoras.Controls.Add(this.btn_Claro);
            this.grp_operadoras.Controls.Add(this.btn_Vivo);
            this.grp_operadoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_operadoras.Location = new System.Drawing.Point(12, 89);
            this.grp_operadoras.Name = "grp_operadoras";
            this.grp_operadoras.Size = new System.Drawing.Size(145, 184);
            this.grp_operadoras.TabIndex = 1;
            this.grp_operadoras.TabStop = false;
            this.grp_operadoras.Text = "Operadoras";
            // 
            // btn_Oi
            // 
            this.btn_Oi.AutoSize = true;
            this.btn_Oi.Location = new System.Drawing.Point(7, 123);
            this.btn_Oi.Name = "btn_Oi";
            this.btn_Oi.Size = new System.Drawing.Size(41, 20);
            this.btn_Oi.TabIndex = 3;
            this.btn_Oi.Text = "Oi";
            this.btn_Oi.UseVisualStyleBackColor = true;
            this.btn_Oi.CheckedChanged += new System.EventHandler(this.btn_Oi_CheckedChanged);
            // 
            // btn_Tim
            // 
            this.btn_Tim.AutoSize = true;
            this.btn_Tim.Location = new System.Drawing.Point(7, 96);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(52, 20);
            this.btn_Tim.TabIndex = 2;
            this.btn_Tim.Text = "Tim";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.CheckedChanged += new System.EventHandler(this.btn_Tim_CheckedChanged);
            // 
            // btn_Claro
            // 
            this.btn_Claro.AutoSize = true;
            this.btn_Claro.Location = new System.Drawing.Point(7, 69);
            this.btn_Claro.Name = "btn_Claro";
            this.btn_Claro.Size = new System.Drawing.Size(63, 20);
            this.btn_Claro.TabIndex = 1;
            this.btn_Claro.Text = "Claro";
            this.btn_Claro.UseVisualStyleBackColor = true;
            this.btn_Claro.CheckedChanged += new System.EventHandler(this.btn_Claro_CheckedChanged);
            // 
            // btn_Vivo
            // 
            this.btn_Vivo.AutoSize = true;
            this.btn_Vivo.Location = new System.Drawing.Point(7, 42);
            this.btn_Vivo.Name = "btn_Vivo";
            this.btn_Vivo.Size = new System.Drawing.Size(57, 20);
            this.btn_Vivo.TabIndex = 0;
            this.btn_Vivo.Text = "Vivo";
            this.btn_Vivo.UseVisualStyleBackColor = true;
            this.btn_Vivo.CheckedChanged += new System.EventHandler(this.btn_Vivo_CheckedChanged);
            // 
            // lbl_BemVindo
            // 
            this.lbl_BemVindo.AutoSize = true;
            this.lbl_BemVindo.Enabled = false;
            this.lbl_BemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BemVindo.Location = new System.Drawing.Point(218, 89);
            this.lbl_BemVindo.Name = "lbl_BemVindo";
            this.lbl_BemVindo.Size = new System.Drawing.Size(142, 16);
            this.lbl_BemVindo.TabIndex = 2;
            this.lbl_BemVindo.Text = "Seja Bem Vindo(a):";
            // 
            // txt_nome
            // 
            this.txt_nome.CausesValidation = false;
            this.txt_nome.Enabled = false;
            this.txt_nome.Location = new System.Drawing.Point(365, 85);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(272, 20);
            this.txt_nome.TabIndex = 3;
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Enabled = false;
            this.lbl_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.Location = new System.Drawing.Point(363, 67);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(45, 15);
            this.lbl_Nome.TabIndex = 4;
            this.lbl_Nome.Text = "Nome";
            // 
            // lbl_OperadoraSelecionada
            // 
            this.lbl_OperadoraSelecionada.AutoSize = true;
            this.lbl_OperadoraSelecionada.Enabled = false;
            this.lbl_OperadoraSelecionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OperadoraSelecionada.Location = new System.Drawing.Point(366, 126);
            this.lbl_OperadoraSelecionada.Name = "lbl_OperadoraSelecionada";
            this.lbl_OperadoraSelecionada.Size = new System.Drawing.Size(159, 15);
            this.lbl_OperadoraSelecionada.TabIndex = 5;
            this.lbl_OperadoraSelecionada.Text = "Operadora Selecionada";
            this.lbl_OperadoraSelecionada.Click += new System.EventHandler(this.lbl_OperadoraSelecionada_Click);
            // 
            // txt_OperadoraSelecionada
            // 
            this.txt_OperadoraSelecionada.Enabled = false;
            this.txt_OperadoraSelecionada.Location = new System.Drawing.Point(369, 144);
            this.txt_OperadoraSelecionada.Name = "txt_OperadoraSelecionada";
            this.txt_OperadoraSelecionada.Size = new System.Drawing.Size(182, 20);
            this.txt_OperadoraSelecionada.TabIndex = 6;
            this.txt_OperadoraSelecionada.TextChanged += new System.EventHandler(this.txt_OperadoraSelecionada_TextChanged);
            // 
            // lbl_DDD
            // 
            this.lbl_DDD.AutoSize = true;
            this.lbl_DDD.Enabled = false;
            this.lbl_DDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DDD.Location = new System.Drawing.Point(366, 186);
            this.lbl_DDD.Name = "lbl_DDD";
            this.lbl_DDD.Size = new System.Drawing.Size(37, 15);
            this.lbl_DDD.TabIndex = 7;
            this.lbl_DDD.Text = "DDD";
            // 
            // txt_DDD
            // 
            this.txt_DDD.Enabled = false;
            this.txt_DDD.Location = new System.Drawing.Point(366, 204);
            this.txt_DDD.Name = "txt_DDD";
            this.txt_DDD.Size = new System.Drawing.Size(34, 20);
            this.txt_DDD.TabIndex = 8;
            // 
            // lbl_NumerodeCelular
            // 
            this.lbl_NumerodeCelular.AutoSize = true;
            this.lbl_NumerodeCelular.Enabled = false;
            this.lbl_NumerodeCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumerodeCelular.Location = new System.Drawing.Point(423, 186);
            this.lbl_NumerodeCelular.Name = "lbl_NumerodeCelular";
            this.lbl_NumerodeCelular.Size = new System.Drawing.Size(128, 15);
            this.lbl_NumerodeCelular.TabIndex = 9;
            this.lbl_NumerodeCelular.Text = "Número de Celular";
            // 
            // Txt_NumerodeCelular
            // 
            this.Txt_NumerodeCelular.Enabled = false;
            this.Txt_NumerodeCelular.Location = new System.Drawing.Point(426, 204);
            this.Txt_NumerodeCelular.Name = "Txt_NumerodeCelular";
            this.Txt_NumerodeCelular.Size = new System.Drawing.Size(125, 20);
            this.Txt_NumerodeCelular.TabIndex = 10;
            // 
            // lbl_ValorRecarga
            // 
            this.lbl_ValorRecarga.AutoSize = true;
            this.lbl_ValorRecarga.Enabled = false;
            this.lbl_ValorRecarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ValorRecarga.Location = new System.Drawing.Point(577, 186);
            this.lbl_ValorRecarga.Name = "lbl_ValorRecarga";
            this.lbl_ValorRecarga.Size = new System.Drawing.Size(118, 15);
            this.lbl_ValorRecarga.TabIndex = 11;
            this.lbl_ValorRecarga.Text = "Valor da Recarga";
            // 
            // txt_ValorRecarga
            // 
            this.txt_ValorRecarga.Enabled = false;
            this.txt_ValorRecarga.Location = new System.Drawing.Point(580, 204);
            this.txt_ValorRecarga.Name = "txt_ValorRecarga";
            this.txt_ValorRecarga.Size = new System.Drawing.Size(115, 20);
            this.txt_ValorRecarga.TabIndex = 12;
            // 
            // btn_RS1
            // 
            this.btn_RS1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RS1.Enabled = false;
            this.btn_RS1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_RS1.FlatAppearance.BorderSize = 5;
            this.btn_RS1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RS1.Location = new System.Drawing.Point(365, 283);
            this.btn_RS1.Name = "btn_RS1";
            this.btn_RS1.Size = new System.Drawing.Size(75, 58);
            this.btn_RS1.TabIndex = 13;
            this.btn_RS1.Text = "R$";
            this.btn_RS1.UseVisualStyleBackColor = true;
            // 
            // btn_RS2
            // 
            this.btn_RS2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RS2.Enabled = false;
            this.btn_RS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RS2.Location = new System.Drawing.Point(464, 283);
            this.btn_RS2.Name = "btn_RS2";
            this.btn_RS2.Size = new System.Drawing.Size(75, 58);
            this.btn_RS2.TabIndex = 14;
            this.btn_RS2.Text = "R$";
            this.btn_RS2.UseVisualStyleBackColor = true;
            // 
            // btn_RS3
            // 
            this.btn_RS3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RS3.Enabled = false;
            this.btn_RS3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RS3.Location = new System.Drawing.Point(562, 283);
            this.btn_RS3.Name = "btn_RS3";
            this.btn_RS3.Size = new System.Drawing.Size(75, 58);
            this.btn_RS3.TabIndex = 15;
            this.btn_RS3.Text = "R$";
            this.btn_RS3.UseVisualStyleBackColor = true;
            // 
            // btn_RS4
            // 
            this.btn_RS4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RS4.Enabled = false;
            this.btn_RS4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_RS4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_RS4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RS4.Location = new System.Drawing.Point(658, 283);
            this.btn_RS4.Name = "btn_RS4";
            this.btn_RS4.Size = new System.Drawing.Size(75, 58);
            this.btn_RS4.TabIndex = 16;
            this.btn_RS4.Text = "R$";
            this.btn_RS4.UseVisualStyleBackColor = true;
            // 
            // lbl_Validade1
            // 
            this.lbl_Validade1.AutoSize = true;
            this.lbl_Validade1.Enabled = false;
            this.lbl_Validade1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Validade1.Location = new System.Drawing.Point(366, 344);
            this.lbl_Validade1.Name = "lbl_Validade1";
            this.lbl_Validade1.Size = new System.Drawing.Size(71, 16);
            this.lbl_Validade1.TabIndex = 17;
            this.lbl_Validade1.Text = "Validade";
            // 
            // lalbl_Validade2
            // 
            this.lalbl_Validade2.AutoSize = true;
            this.lalbl_Validade2.Enabled = false;
            this.lalbl_Validade2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalbl_Validade2.Location = new System.Drawing.Point(469, 344);
            this.lalbl_Validade2.Name = "lalbl_Validade2";
            this.lalbl_Validade2.Size = new System.Drawing.Size(71, 16);
            this.lalbl_Validade2.TabIndex = 18;
            this.lalbl_Validade2.Text = "Validade";
            // 
            // lbl_Validade3
            // 
            this.lbl_Validade3.AutoSize = true;
            this.lbl_Validade3.Enabled = false;
            this.lbl_Validade3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Validade3.Location = new System.Drawing.Point(567, 344);
            this.lbl_Validade3.Name = "lbl_Validade3";
            this.lbl_Validade3.Size = new System.Drawing.Size(71, 16);
            this.lbl_Validade3.TabIndex = 19;
            this.lbl_Validade3.Text = "Validade";
            // 
            // lbl_Validade4
            // 
            this.lbl_Validade4.AutoSize = true;
            this.lbl_Validade4.Enabled = false;
            this.lbl_Validade4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Validade4.Location = new System.Drawing.Point(663, 344);
            this.lbl_Validade4.Name = "lbl_Validade4";
            this.lbl_Validade4.Size = new System.Drawing.Size(71, 16);
            this.lbl_Validade4.TabIndex = 20;
            this.lbl_Validade4.Text = "Validade";
            // 
            // lbl_Validade5
            // 
            this.lbl_Validade5.AutoSize = true;
            this.lbl_Validade5.Enabled = false;
            this.lbl_Validade5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Validade5.Location = new System.Drawing.Point(366, 443);
            this.lbl_Validade5.Name = "lbl_Validade5";
            this.lbl_Validade5.Size = new System.Drawing.Size(71, 16);
            this.lbl_Validade5.TabIndex = 22;
            this.lbl_Validade5.Text = "Validade";
            // 
            // btn_RS5
            // 
            this.btn_RS5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RS5.Enabled = false;
            this.btn_RS5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_RS5.FlatAppearance.BorderSize = 5;
            this.btn_RS5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RS5.Location = new System.Drawing.Point(365, 382);
            this.btn_RS5.Name = "btn_RS5";
            this.btn_RS5.Size = new System.Drawing.Size(75, 58);
            this.btn_RS5.TabIndex = 21;
            this.btn_RS5.Text = "R$";
            this.btn_RS5.UseVisualStyleBackColor = true;
            // 
            // lbl_Validade6
            // 
            this.lbl_Validade6.AutoSize = true;
            this.lbl_Validade6.Enabled = false;
            this.lbl_Validade6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Validade6.Location = new System.Drawing.Point(469, 443);
            this.lbl_Validade6.Name = "lbl_Validade6";
            this.lbl_Validade6.Size = new System.Drawing.Size(71, 16);
            this.lbl_Validade6.TabIndex = 24;
            this.lbl_Validade6.Text = "Validade";
            // 
            // btn_RS6
            // 
            this.btn_RS6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RS6.Enabled = false;
            this.btn_RS6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_RS6.FlatAppearance.BorderSize = 5;
            this.btn_RS6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RS6.Location = new System.Drawing.Point(464, 382);
            this.btn_RS6.Name = "btn_RS6";
            this.btn_RS6.Size = new System.Drawing.Size(75, 58);
            this.btn_RS6.TabIndex = 23;
            this.btn_RS6.Text = "R$";
            this.btn_RS6.UseVisualStyleBackColor = true;
            // 
            // lbl_Validade7
            // 
            this.lbl_Validade7.AutoSize = true;
            this.lbl_Validade7.Enabled = false;
            this.lbl_Validade7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Validade7.Location = new System.Drawing.Point(567, 443);
            this.lbl_Validade7.Name = "lbl_Validade7";
            this.lbl_Validade7.Size = new System.Drawing.Size(71, 16);
            this.lbl_Validade7.TabIndex = 26;
            this.lbl_Validade7.Text = "Validade";
            // 
            // btn_RS7
            // 
            this.btn_RS7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RS7.Enabled = false;
            this.btn_RS7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_RS7.FlatAppearance.BorderSize = 5;
            this.btn_RS7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RS7.Location = new System.Drawing.Point(562, 382);
            this.btn_RS7.Name = "btn_RS7";
            this.btn_RS7.Size = new System.Drawing.Size(75, 58);
            this.btn_RS7.TabIndex = 25;
            this.btn_RS7.Text = "R$";
            this.btn_RS7.UseVisualStyleBackColor = true;
            // 
            // lbl_Validade8
            // 
            this.lbl_Validade8.AutoSize = true;
            this.lbl_Validade8.Enabled = false;
            this.lbl_Validade8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Validade8.Location = new System.Drawing.Point(663, 443);
            this.lbl_Validade8.Name = "lbl_Validade8";
            this.lbl_Validade8.Size = new System.Drawing.Size(71, 16);
            this.lbl_Validade8.TabIndex = 28;
            this.lbl_Validade8.Text = "Validade";
            // 
            // btn_RS8
            // 
            this.btn_RS8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RS8.Enabled = false;
            this.btn_RS8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_RS8.FlatAppearance.BorderSize = 5;
            this.btn_RS8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RS8.Location = new System.Drawing.Point(658, 382);
            this.btn_RS8.Name = "btn_RS8";
            this.btn_RS8.Size = new System.Drawing.Size(75, 58);
            this.btn_RS8.TabIndex = 27;
            this.btn_RS8.Text = "R$";
            this.btn_RS8.UseVisualStyleBackColor = true;
            // 
            // lbl_SelecioneValor
            // 
            this.lbl_SelecioneValor.AutoSize = true;
            this.lbl_SelecioneValor.Enabled = false;
            this.lbl_SelecioneValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelecioneValor.Location = new System.Drawing.Point(442, 254);
            this.lbl_SelecioneValor.Name = "lbl_SelecioneValor";
            this.lbl_SelecioneValor.Size = new System.Drawing.Size(218, 16);
            this.lbl_SelecioneValor.TabIndex = 29;
            this.lbl_SelecioneValor.Text = "Selecione o Valor da Recarga";
            // 
            // pcb_image
            // 
            this.pcb_image.BackColor = System.Drawing.Color.White;
            this.pcb_image.Image = global::Operadora.Properties.Resources.top_embalagem_logo_anatel_03;
            this.pcb_image.Location = new System.Drawing.Point(12, 256);
            this.pcb_image.Name = "pcb_image";
            this.pcb_image.Size = new System.Drawing.Size(145, 203);
            this.pcb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_image.TabIndex = 30;
            this.pcb_image.TabStop = false;
            this.pcb_image.Click += new System.EventHandler(this.pcb_image_Click);
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(800, 555);
            this.Controls.Add(this.pcb_image);
            this.Controls.Add(this.lbl_SelecioneValor);
            this.Controls.Add(this.lbl_Validade8);
            this.Controls.Add(this.btn_RS8);
            this.Controls.Add(this.lbl_Validade7);
            this.Controls.Add(this.btn_RS7);
            this.Controls.Add(this.lbl_Validade6);
            this.Controls.Add(this.btn_RS6);
            this.Controls.Add(this.lbl_Validade5);
            this.Controls.Add(this.btn_RS5);
            this.Controls.Add(this.lbl_Validade4);
            this.Controls.Add(this.lbl_Validade3);
            this.Controls.Add(this.lalbl_Validade2);
            this.Controls.Add(this.lbl_Validade1);
            this.Controls.Add(this.btn_RS4);
            this.Controls.Add(this.btn_RS3);
            this.Controls.Add(this.btn_RS2);
            this.Controls.Add(this.btn_RS1);
            this.Controls.Add(this.txt_ValorRecarga);
            this.Controls.Add(this.lbl_ValorRecarga);
            this.Controls.Add(this.Txt_NumerodeCelular);
            this.Controls.Add(this.lbl_NumerodeCelular);
            this.Controls.Add(this.txt_DDD);
            this.Controls.Add(this.lbl_DDD);
            this.Controls.Add(this.txt_OperadoraSelecionada);
            this.Controls.Add(this.lbl_OperadoraSelecionada);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_BemVindo);
            this.Controls.Add(this.grp_operadoras);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "frm_principal";
            this.Text = "Regarga para Celular";
            this.grp_operadoras.ResumeLayout(false);
            this.grp_operadoras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grp_operadoras;
        private System.Windows.Forms.RadioButton btn_Oi;
        private System.Windows.Forms.RadioButton btn_Tim;
        private System.Windows.Forms.RadioButton btn_Claro;
        private System.Windows.Forms.RadioButton btn_Vivo;
        private System.Windows.Forms.Label lbl_BemVindo;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_OperadoraSelecionada;
        private System.Windows.Forms.TextBox txt_OperadoraSelecionada;
        private System.Windows.Forms.Label lbl_DDD;
        private System.Windows.Forms.TextBox txt_DDD;
        private System.Windows.Forms.Label lbl_NumerodeCelular;
        private System.Windows.Forms.TextBox Txt_NumerodeCelular;
        private System.Windows.Forms.Label lbl_ValorRecarga;
        private System.Windows.Forms.TextBox txt_ValorRecarga;
        private System.Windows.Forms.Button btn_RS1;
        private System.Windows.Forms.Button btn_RS2;
        private System.Windows.Forms.Button btn_RS3;
        private System.Windows.Forms.Button btn_RS4;
        private System.Windows.Forms.Label lbl_Validade1;
        private System.Windows.Forms.Label lalbl_Validade2;
        private System.Windows.Forms.Label lbl_Validade3;
        private System.Windows.Forms.Label lbl_Validade4;
        private System.Windows.Forms.Label lbl_Validade5;
        private System.Windows.Forms.Button btn_RS5;
        private System.Windows.Forms.Label lbl_Validade6;
        private System.Windows.Forms.Button btn_RS6;
        private System.Windows.Forms.Label lbl_Validade7;
        private System.Windows.Forms.Button btn_RS7;
        private System.Windows.Forms.Label lbl_Validade8;
        private System.Windows.Forms.Button btn_RS8;
        private System.Windows.Forms.Label lbl_SelecioneValor;
        private System.Windows.Forms.PictureBox pcb_image;
    }
}

