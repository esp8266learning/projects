Imports System.IO.Ports

Public Class frmRGBLed
    Dim WithEvents serialPort As New SerialPort


    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        Try
            serialPort.BaudRate = 9600
            serialPort.PortName = cboPorts.SelectedItem.ToString
            serialPort.Parity = Parity.None
            serialPort.DataBits = 8
            serialPort.StopBits = 1
            serialPort.Open()
            serialPort.Encoding = System.Text.Encoding.Default
            If serialPort.IsOpen Then
                btnConnect.Visible = False
                cboPorts.Enabled = False
                btnDisconnect.Visible = True
            End If
        Catch
            serialPort.Close()
        End Try
    End Sub

    Private Sub btnDisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisconnect.Click
        Try
            serialPort.Close()
            btnConnect.Visible = True
            btnDisconnect.Visible = False
            cboPorts.Enabled = True
            Exit Sub
        Catch
            MessageBox.Show("Problem closing port")
        End Try
    End Sub

    Private Sub blnRedOn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles blnRedOn.Click
        serialPort.Write("1")
    End Sub

    Private Sub btnRedOff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRedOff.Click
        serialPort.Write("2")
    End Sub

    Private Sub btnGreenOn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGreenOn.Click
        serialPort.Write("3")
    End Sub

    Private Sub btnGreenOff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGreenOff.Click
        serialPort.Write("4")
    End Sub

    Private Sub btmBlueOn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btmBlueOn.Click
        serialPort.Write("5")
    End Sub

    Private Sub btnBlueOff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBlueOff.Click
        serialPort.Write("6")
    End Sub


    Private Sub GetSerialPortNames()
        For Each sport As String In My.Computer.Ports.SerialPortNames
            cboPorts.Items.Add(sport)
        Next
    End Sub

    Private Sub frmRGBLed_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            GetSerialPortNames()
            cboPorts.SelectedIndex = 0
        Catch
            MsgBox("No ports connected.")
        End Try
    End Sub

End Class
