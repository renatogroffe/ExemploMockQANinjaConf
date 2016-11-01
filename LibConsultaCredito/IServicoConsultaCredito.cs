using System.Collections.Generic;

namespace LibConsultaCredito
{
    public interface IServicoConsultaCredito
    {
        IList<Pendencia> ConsultarPendenciasPorCPF(string cpf);
    }
}
