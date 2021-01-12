using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace CDS__Centro_de_Soluciones_
{
    public partial class FormPrinCDS : Form
    {
        // Ejecutar comandos del Sistema
        System.Diagnostics.Process proceso = new System.Diagnostics.Process();

        // Aspecto de la Terminal
        String configTerminal = "MODE 80, 0 & COLOR 03 &";


        public FormPrinCDS()
        {
            InitializeComponent();

        }



        /////////////////////////////////////////////////////////
        // importacion del metodo para mover la pestaña
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void MoverForm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Cerrar Form y Cambio de Color del Panel
        private void CloseForm(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseFormHover(object sender, EventArgs e)
        {
            panelCloseForm.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(1)))), ((int)(((byte)(12)))));
            panelImgClose0.Visible = false;
            panelImgClose1.Visible = true;
        }

        private void CloseFormLeave(object sender, EventArgs e)
        {
            panelCloseForm.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            panelImgClose0.Visible = true;
            panelImgClose1.Visible = false;
        }
        /////////////////////////////////////////////////////////



        /////////////////////////////////////////////////////////
        // Boton Cleanmgr (Liberador de espacio en Disco)
        private void Cleanmgr(object sender, EventArgs e)
        {
            //Llamar a Cleanmgr (Limpieza de disco)
            proceso.StartInfo.FileName = "cleanmgr";

            // Parametros del comando a ejecutar
            proceso.StartInfo.Arguments = "/lowdisk";

            proceso.Start();
        }
        private void CleanmgrHover(object sender, EventArgs e)
        {
            textCleanmgr.ForeColor = Color.DarkCyan;
        }
        private void CleanmgrLeave(object sender, EventArgs e)
        {
            textCleanmgr.ForeColor = Color.LightGray;
        }
        /////////////////////////////////////////////////////////



        /////////////////////////////////////////////////////////
        // Boton SFC (Comprobador de Archivos)
        private void SFC(object sender, EventArgs e)
        {
            proceso.StartInfo.FileName = "cmd";
            proceso.StartInfo.Arguments = "/c " + configTerminal + "echo. " +
                "& echo. " +
                "& echo. " +
                "& echo  ▐▓█▀▀▀▀▀▀▀▀▀█▓▌ ▄▄▄▄▄                                      ▄▄▄ " +
                "& echo  ▐▓█         █▓▌ █▄▄▄█ ╔═══════════════════════════════╗  ▄▀ ▄ ▀▄" +
                "& echo  ▐▓█         █▓▌ █▄▄▄█ ║ SFC (Comprobador de Archivos) ║  █ █ ▀ █" +
                "& echo  ▐▓█▄▄▄▄▄▄▄▄▄█▓▌ █████ ╚═══════════════════════════════╝  █ ▀▄▄▀█▄█▄▀" +
                "& echo      ▄▄███▄▄     █████                                   ▄▄█▄▄▄▄███▀" +
                "& echo. " +
                "& echo. " +
                "& SFC /scannow" +
                "& echo. " +
                "& echo. " +
                "& pause";

            proceso.Start();
        }
        private void SFCHover(object sender, EventArgs e)
        {
            textSFC.ForeColor = Color.DarkCyan;
        }
        private void SFCLeave(object sender, EventArgs e)
        {
            textSFC.ForeColor = Color.LightGray;
        }
        /////////////////////////////////////////////////////////



        /////////////////////////////////////////////////////////
        // Eliminación de Temporales
        private void temp(object sender, EventArgs e)
        {
            proceso.StartInfo.FileName = "cmd";
            proceso.StartInfo.Arguments = "/c " + configTerminal + "echo. " +
                "& echo. " +
                "& echo. " +
                "& echo  ▐▓█▀▀▀▀▀▀▀▀▀█▓▌ ▄▄▄▄▄                                      ▄█▄▄▄█▄" +
                "& echo  ▐▓█         █▓▌ █▄▄▄█ ╔═══════════════════════════╗ ▄▀    ▄▌─▄─▄─▐▄    ▀▄" +
                "& echo  ▐▓█         █▓▌ █▄▄▄█ ║ Eliminación de temporales ║ █▄▄█  ▀▌─▀─▀─▐▀  █▄▄█" +
                "& echo  ▐▓█▄▄▄▄▄▄▄▄▄█▓▌ █████ ╚═══════════════════════════╝  ▐▌    ▀▀███▀▀    ▐▌" +
                "& echo      ▄▄███▄▄     █████                               ████ ▄█████████▄ ████" +
                "& echo. " +
                "& C: " +
                "& CD \\ " +
                "& DEL *.TMP /s " +
                "& DEL C:\\Users\\%username%\\AppData\\Local\\Temp /f /s /q" +
                "& RD C:\\Users\\%username%\\AppData\\Local\\Temp /s /q" +
                "& DEL C:\\Windows\\Temp /f /s /q" +
                "& RD C:\\Windows\\Temp /s /q" +
                "& echo." +
                "& echo Finalizado" +
                "& echo. " +
                "& echo cualquier tecla para salir... " +
                "& pause>nul";

            proceso.Start();
        }
        private void tempHover(object sender, EventArgs e)
        {
            textTemp.ForeColor = Color.DarkCyan;
        }
        private void tempLeave(object sender, EventArgs e)
        {
            textTemp.ForeColor = Color.LightGray;
        }
        /////////////////////////////////////////////////////////



        /////////////////////////////////////////////////////////
        // Abrir una Terminal
        private void cmd(object sender, EventArgs e)
        {
            //Abrir terminal cmd
            proceso.StartInfo.FileName = "cmd";
            proceso.StartInfo.Arguments = "/c cd C:\\ & cmd";

            // Inicializar el proceso.
            proceso.Start();
        }
        private void cmdHover(object sender, EventArgs e)
        {
            textCMD.ForeColor = Color.DarkCyan;
        }
        private void cmdLeave(object sender, EventArgs e)
        {
            textCMD.ForeColor = Color.LightGray;
        }
        /////////////////////////////////////////////////////////



        /////////////////////////////////////////////////////////
        // Administrador de Tareas
        private void taskmgr(object sender, EventArgs e)
        {
            //Llamar al Administrador de tareas
            proceso.StartInfo.FileName = "taskmgr";

            // Inicializar el proceso.
            proceso.Start();
        }
        private void taskmgrHover(object sender, EventArgs e)
        {
            textTaskmgr.ForeColor = Color.DarkCyan;
        }
        private void taskmgrLeave(object sender, EventArgs e)
        {
            textTaskmgr.ForeColor = Color.LightGray;
        }
        /////////////////////////////////////////////////////////



        /////////////////////////////////////////////////////////
        // Abrir Configuracion del Sistema
        private void msconfig(object sender, EventArgs e)
        {
            //Abrir msconfig
            proceso.StartInfo.FileName = "msconfig";

            // Inicializar el proceso.
            proceso.Start();
        }
        private void msconfigHover(object sender, EventArgs e)
        {
            textMsconfig.ForeColor = Color.DarkCyan;
        }
        private void msconfigLeave(object sender, EventArgs e)
        {
            textMsconfig.ForeColor = Color.LightGray;
        }
        /////////////////////////////////////////////////////////



        /////////////////////////////////////////////////////////
        // Abrir Visor de Eventos
        private void visorEvents(object sender, EventArgs e)
        {
            //Llamar al Visor de Eventos de Windows
            proceso.StartInfo.FileName = "eventvwr.msc";

            // Inicializar el proceso.
            proceso.Start();
        }
        private void visorEventsHover(object sender, EventArgs e)
        {
            textVisorEvents.ForeColor = Color.DarkCyan;
        }
        private void visorEventsLeave(object sender, EventArgs e)
        {
            textVisorEvents.ForeColor = Color.LightGray;
        }
        /////////////////////////////////////////////////////////



        /////////////////////////////////////////////////////////
        // Abrir Administración de equipos
        private void adminPCs(object sender, EventArgs e)
        {
            //Administrador de equipos
            proceso.StartInfo.FileName = "compmgmt.msc";

            // Inicializar el proceso.
            proceso.Start();
        }
        private void adminPCsHover(object sender, EventArgs e)
        {
            textAdminPCs.ForeColor = Color.DarkCyan;
        }
        private void adminPCsLeave(object sender, EventArgs e)
        {
            textAdminPCs.ForeColor = Color.LightGray;
        }
        /////////////////////////////////////////////////////////
        


        /////////////////////////////////////////////////////////
        // Abrir Panel de Control
        private void panelControl(object sender, EventArgs e)
        {
            // Llamar al Panel de control
            proceso.StartInfo.FileName = "cmd";
            proceso.StartInfo.Arguments = "/c control";

            // Inicializar el proceso.
            proceso.Start();
        }
        private void panelControlHover(object sender, EventArgs e)
        {
            textPanelControl.ForeColor = Color.DarkCyan;
        }
        private void panelControlLeave(object sender, EventArgs e)
        {
            textPanelControl.ForeColor = Color.LightGray;
        }
        /////////////////////////////////////////////////////////



        /////////////////////////////////////////////////////////
        // Abrir Opciones de Carpetas
        private void optionsFolder(object sender, EventArgs e)
        {
            //Abrir terminal cmd
            proceso.StartInfo.FileName = "cmd";
            proceso.StartInfo.Arguments = "/c control folders";

            // Inicializar el proceso.
            proceso.Start();
        }
        private void optionsFolderHover(object sender, EventArgs e)
        {
            textOptionsFolder.ForeColor = Color.DarkCyan;
        }
        private void optionsFolderLeave(object sender, EventArgs e)
        {
            textOptionsFolder.ForeColor = Color.LightGray;
        }
        /////////////////////////////////////////////////////////
    }
}