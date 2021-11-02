using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginCondominio
{
    //Cria os atributos da classe, construtor da classe e os gets and sets
    public class Moradores
    {
        private System.String nomeCompleto;
        private System.String dataNascimento;
        private System.String cpf;
        private System.String rg;

        public Moradores(){} //construtor vazio

        //sets
        public void setNomeCompleto(System.String nomeCompleto)
        { this.nomeCompleto = nomeCompleto; }

        public void setDataNascimento(System.String dataNascimento)
        { this.dataNascimento = dataNascimento; }

        public void setCpf(System.String cpf)
        { this.cpf = cpf; }

        public void setRG(System.String rg)
        { this.rg = rg; }

        //gets
        public String getNomeCompleto(System.String nomeCompleto)
        { return nomeCompleto; }

        public String getDataNascimento(System.String dataNascimento)
        { return dataNascimento; }

        public String getCpf(System.String cpf)
        { return cpf; }

        public String getRG(System.String rg)
        { return rg; }

    }
}
