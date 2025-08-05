using ControleDeBar.Dominio.ModuloProduto;
using System.ComponentModel.DataAnnotations;

namespace ControleDeBar.WebApp.Models;

public class CadastrarProdutoViewModel
{
    [Required(ErrorMessage = "O campo \"Nome\" é obrigatório.")]
    [MinLength(3, ErrorMessage = "O campo \"Nome\" precisa conter ao menos 3 caracteres.")]
    [MaxLength(100, ErrorMessage = "O campo \"Nome\" precisa conter no máximo 100 caracteres.")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O campo \"Valor\" é obrigatório.")]
    [DataType(DataType.Currency)]
    [Range(0, double.MaxValue,
        ErrorMessage = "O campo \"Valor\" precisa conter um valor positivo.")]
    public decimal Valor { get; set; }

    public CadastrarProdutoViewModel() { }

    public CadastrarProdutoViewModel(string nome, decimal valor) : this()
    {
        Nome = nome;
        Valor = valor;
    }
}

public class EditarProdutoViewModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "O campo \"Nome\" é obrigatório.")]
    [MinLength(3, ErrorMessage = "O campo \"Nome\" precisa conter ao menos 3 caracteres.")]
    [MaxLength(100, ErrorMessage = "O campo \"Nome\" precisa conter no máximo 100 caracteres.")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O campo \"Valor\" é obrigatório.")]
    [DataType(DataType.Currency)]
    [Range(0, double.MaxValue,
        ErrorMessage = "O campo \"Valor\" precisa conter um valor positivo.")]
    public decimal Valor { get; set; }
    public EditarProdutoViewModel() { }

    public EditarProdutoViewModel(int id, string nome, decimal valor) : this()
    {
        Id = id;
        Nome = nome;
        Valor = valor;
    }
}

public class ExcluirProdutoViewModel
{
    public int Id { get; set; }
    public string Nome { get; set; }

    public ExcluirProdutoViewModel() { }

    public ExcluirProdutoViewModel(int id, string nome)
    {
        Id = id;
        Nome = nome;
    }
}

public class VisualizarProdutosViewModel
{
    public List<DetalhesProdutoViewModel> Registros { get; set; }

    public VisualizarProdutosViewModel(List<Produto> produtos)
    {
        Registros = new List<DetalhesProdutoViewModel>();

        foreach (var p in produtos)
        {
            DetalhesProdutoViewModel produtoVm = new DetalhesProdutoViewModel(
                p.Id,
                p.Nome,
                p.Valor
            );

            Registros.Add(produtoVm);
        }
    }
}

public class DetalhesProdutoViewModel
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public decimal Valor { get; set; }

    public DetalhesProdutoViewModel(int id, string nome, decimal valor)
    {
        Id = id;
        Nome = nome;
        Valor = valor;
    }
}