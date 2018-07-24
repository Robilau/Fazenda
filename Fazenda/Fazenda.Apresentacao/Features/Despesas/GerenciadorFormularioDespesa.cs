using Fazenda.Dominio.Features.Animais;
using Fazenda.Dominio.Features.Despesas;
using Fazenda.Dominio.Features.Fornecedores;
using Fazenda.Dominio.Features.Itens;
using Fazenda.Infra.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fazenda.Apresentacao.Features.Despesas
{
    public class GerenciadorFormularioDespesa : IFormularioDespesa
    {
        private Despesa _despesa;
        private ControleDespesa _controleDespesa;
        private CadastroDespesaForm _dialogo;
        IDespesaServico _despesaServico;
        ICollection<Despesa> _despesas;

        public GerenciadorFormularioDespesa(IAnimalServico animalServico, IItemServico itemServico, IFornecedorServico fornecedorServico, IDespesaServico despesaServico)
        {
            _dialogo = new CadastroDespesaForm(animalServico, itemServico, fornecedorServico, despesaServico);
            _despesaServico = despesaServico;
        }

        public void Adicionar()
        {

            try
            {
                DialogResult resultado = _dialogo.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    _despesa = _dialogo.novaDespesa;
                    _despesaServico.Adicionar(_despesa);
                    MessageBox.Show("Despesa registrada com sucesso!");
                }
                _dialogo.LimparCampos();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Adicionar();
            }
        }

        public void AtualizarLista()
        {
            try
            {
                _despesas = _despesaServico.PegarTodos().OrderBy(p => p.Data).ToList();
                _controleDespesa.CarregarListaDespesa(_despesas);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void AtualizarLista(string[] termoParaPesquisar)
        {
            try
            {
                _despesas = _despesaServico.PegarTodos();
                if (!string.IsNullOrEmpty(termoParaPesquisar[0]))
                    _despesas = _despesas.Where(d => d.Data.ToShortDateString().Contains(termoParaPesquisar[0])).ToList();
                if (!string.IsNullOrEmpty(termoParaPesquisar[1]))
                    _despesas = _despesas.Where(d => d.Fornecedor.Nome.ToUpper().Contains(termoParaPesquisar[1].ToUpper())).ToList();
                if (!string.IsNullOrEmpty(termoParaPesquisar[2]))
                    _despesas = _despesas.Where(d => d.Item.Descricao.ToUpper().Contains(termoParaPesquisar[2].ToUpper())).ToList();
                if (!string.IsNullOrEmpty(termoParaPesquisar[3]))
                    _despesas = _despesas.Where(d => d.PegarTipo().ToUpper().Contains(termoParaPesquisar[3].ToUpper())).ToList();
                if (!string.IsNullOrEmpty(termoParaPesquisar[4]))
                    _despesas = _despesas.Where(d => d.Animal.Especie.ToUpper().Contains(termoParaPesquisar[4].ToUpper())).ToList();
                _controleDespesa.CarregarListaDespesa(_despesas);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public UserControl CarregarListagem()
        {
            if (_controleDespesa == null)
                _controleDespesa = new ControleDespesa();

            return _controleDespesa;
        }

        public void Editar()
        {
            if (_controleDespesa.ObterDespesaSelecionada() == null)
                MessageBox.Show("Precisa selecionar um despesa.");

            else
            {
                try
                {
                    _dialogo.novaDespesa = _controleDespesa.ObterDespesaSelecionada();

                    DialogResult resultado = _dialogo.ShowDialog();
                    if (resultado == DialogResult.OK)
                    {
                        _despesa = _dialogo.novaDespesa;
                        _despesaServico.Atualizar(_despesa);
                        MessageBox.Show("Despesa atualizada com sucesso!");
                    }
                    _dialogo.LimparCampos();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Erro");
                    Editar();
                }
            }
        }

        public void Excluir()
        {
            try
            {
                if (_controleDespesa.ObterDespesaSelecionada() == null)
                    throw new Exception("Precisa selecionar uma despesa.");

                _despesa = _controleDespesa.ObterDespesaSelecionada();
                DialogResult resultado = MessageBox.Show("Confirmar exclusão da despesa: \n" + _despesa.ToString(), "Excluir Despesa", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    _despesaServico.Remover(_despesa);
                    MessageBox.Show("Despesa deletada com sucesso!");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro");
            }
        }

        public void Exportar()
        {
            SaveFileDialog dialog = new SaveFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (_despesas != null)
                {
                    ExportadorXLS.ExportarListaDeDespesas(_despesas, dialog.FileName + ".xls");
                    MessageBox.Show("Exportado com sucesso.");
                }
                else
                {
                    MessageBox.Show("A lista está vazia.");
                }
            }
        }

        public string ObtemTipoCadastro()
        {
            return "Despesas";
        }
    }
}
