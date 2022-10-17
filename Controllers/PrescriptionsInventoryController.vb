Imports System.Net
Imports System.Web.Http
Imports Sfarm.DAL.Entities.Prescriptions

Namespace Controllers
    Public Class PrescriptionsInventoryController
        Inherits ApiController

        Public Function GetValues() As String
            Return "PrescriptionsInventoryController"
        End Function

        <HttpPost>
        Public Sub PostValue(<FromBody()> ByVal req As RequestInventory)
            If System.Web.HttpContext.Current.Request.Headers.Get(HttpRequestHeader.Authorization.ToString) IsNot Nothing AndAlso
               String.Compare(System.Web.HttpContext.Current.Request.Headers.Get(HttpRequestHeader.Authorization.ToString), PrescriptionsHelpers.authToken, True) = 0 Then

                If req Is Nothing Then
                    DataHelper.GetJsonResultWithStatusCode("Structure parsing error", HttpStatusCode.BadRequest)
                ElseIf String.IsNullOrEmpty(req.mo) Then
                    DataHelper.GetJsonResultWithStatusCode("Incorrect OID", HttpStatusCode.BadRequest)
                End If

                Try
                    Dim rez = PrescriptionsHelpers.OwnerInventoryGet(req)
                    DataHelper.GetJsonResultWithStatusCode(rez, HttpStatusCode.OK)
                Catch
                    DataHelper.GetJsonResultWithStatusCode("Internal server error", HttpStatusCode.InternalServerError)
                End Try
            Else
                DataHelper.GetJsonResultWithStatusCode("Bad autorizization token", HttpStatusCode.Unauthorized)
            End If
        End Sub

    End Class
End Namespace