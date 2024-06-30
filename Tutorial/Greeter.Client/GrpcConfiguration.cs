using Ir.Common.Configuration.Grpc;
namespace Greeter.Client;

public class GrpcConfiguration : IGrpcServiceConfiguration
{
    public string Address { get; set; } = "http://localhost:5000";
    public ICertificateConfiguration? ClientCertificate => null;
    public ICertificateConfiguration? ServiceCertificate => null;
}
