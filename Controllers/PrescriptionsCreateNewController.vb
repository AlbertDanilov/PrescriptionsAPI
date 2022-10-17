Imports System.Net
Imports System.Web.Http
Imports Sfarm.DAL.Entities.Prescriptions

Namespace Controllers
    Public Class PrescriptionsCreateNewController
        Inherits ApiController

        Public Function GetValues() As String
            Return "PrescriptionsCreateNewController"
        End Function

        <HttpPost>
        Public Sub PostValue(<FromBody()> ByVal prescription As RequestNewPrescription)
            If System.Web.HttpContext.Current.Request.Headers.Get(HttpRequestHeader.Authorization.ToString) IsNot Nothing AndAlso
               String.Compare(System.Web.HttpContext.Current.Request.Headers.Get(HttpRequestHeader.Authorization.ToString), PrescriptionsHelpers.authToken, True) = 0 Then

                Try
                    If prescription Is Nothing Then
                        DataHelper.GetJsonResultWithStatusCode("Structure parsing error", HttpStatusCode.BadRequest)
                    Else
                        Dim rd As Sfarm.DAL.Entities.ResponseData = Sfarm.DAL.Helpers.PrescriptionHelper.PrescriptionsCreate(prescription)

                        If rd Is Nothing OrElse rd.IsError Then
                            DataHelper.GetJsonResultWithStatusCode(prescription.prescriptionId, HttpStatusCode.InternalServerError)
                        Else
                            DataHelper.GetJsonResultWithStatusCode(prescription.prescriptionId, HttpStatusCode.OK)
                        End If
                    End If
                Catch
                    DataHelper.GetJsonResultWithStatusCode("Internal server error", HttpStatusCode.InternalServerError)
                End Try
            Else
                DataHelper.GetJsonResultWithStatusCode("Bad autorizization token", HttpStatusCode.Unauthorized)
            End If
        End Sub

    End Class
End Namespace