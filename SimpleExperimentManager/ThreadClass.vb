
Public Delegate Sub CallbackDelegate(ByVal strStatus As String)
Public Delegate Sub ThreadFunctionDelegate()

Public Class CallbackThread
    Implements IDisposable

    Private objBaseControl As Control, objThreadFunction As ThreadFunctionDelegate, objCallbackFunction As CallbackDelegate
    Private objThread As Threading.Thread, bolDisposedValue As Boolean = False, bolStartedValue As Boolean = False

    Public Sub New(ByRef objCaller As Control, ByRef objThreadMethod As ThreadFunctionDelegate, ByRef objLocalCallback As CallbackDelegate)
        objBaseControl = objCaller
        objThreadFunction = objThreadMethod
        objCallbackFunction = objLocalCallback
        objThread = New Threading.Thread(AddressOf ThreadFunction)
    End Sub

    Public Sub Start()
        If Not bolStartedValue Then
            objThread.Start()
            bolStartedValue = True
        Else
            Throw New Exception("This thread is already running!")
        End If
    End Sub

    Private Sub ThreadFunction()
        objThreadFunction.Invoke()
        bolStartedValue = False
    End Sub

    Public Sub UpdateUI(ByVal strMessage As String)
        If objBaseControl IsNot Nothing AndAlso objCallbackFunction IsNot Nothing Then
            objBaseControl.Invoke(objCallbackFunction, New Object() {strMessage})
        End If
    End Sub

    Protected Overridable Sub Dispose(ByVal bolDisposing As Boolean)
        If Not Me.bolDisposedValue Then
            If bolDisposing Then
                If objThread.ThreadState <> Threading.ThreadState.Stopped Then
                    objThread.Abort()
                End If
            End If
            objThread = Nothing
            objBaseControl = Nothing
            objCallbackFunction = Nothing
        End If
        Me.bolDisposedValue = True
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub

End Class
