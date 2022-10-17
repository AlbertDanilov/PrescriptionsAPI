Imports System.Net
Imports System.Web.Http

Namespace Controllers
    Public Class PrescriptionsDivisionsController
        Inherits ApiController

        Public Function GetValues() As String
            Return "PrescriptionsDivisionsController"
        End Function

        <HttpPost>
        Public Sub PostValue(<FromBody()> ByVal mo As String)
            If System.Web.HttpContext.Current.Request.Headers.Get(HttpRequestHeader.Authorization.ToString) IsNot Nothing AndAlso
               String.Compare(System.Web.HttpContext.Current.Request.Headers.Get(HttpRequestHeader.Authorization.ToString), PrescriptionsHelpers.authToken, True) = 0 Then

                If String.IsNullOrEmpty(mo) Then
                    DataHelper.GetJsonResultWithStatusCode("Incorrect OID", HttpStatusCode.BadRequest)
                End If

                Try
                    Dim rez = PrescriptionsHelpers.OwnerSkladsGet(mo)
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