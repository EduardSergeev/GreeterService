using Ir.Common.Configuration.Grpc;

public class GrpcConfiguration : IGrpcServiceConfiguration
{
    public string Address { get; set; } = "http://localhost:5000";
    public ICertificateConfiguration? ClientCertificate => null;
    public ICertificateConfiguration? ServiceCertificate => null;
}
