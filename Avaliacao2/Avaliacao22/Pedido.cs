namespace Avaliacao22.Models;

class Pedido {
    public int CodPedido { get; set; }
    public DateTime PrazoEntrega { get; set; }
    public DateTime DataPedido = DateTime.Now;
    public int PedidoCodCliente { get; set; }
    public int PedidoCodVendedor { get; set; }

    public Pedido(int codpedido, DateTime prazoentrega, DateTime datapedido, int pedidocodcliente, int pedidocodvendedor) {
        CodPedido = codpedido;
        PrazoEntrega = prazoentrega;
        DataPedido = datapedido;
        PedidoCodCliente = pedidocodcliente;
        PedidoCodVendedor = pedidocodvendedor;
    }
}