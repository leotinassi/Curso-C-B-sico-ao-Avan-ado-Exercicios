using CursoCScharp.Fundamentos;
using CursoCScharp.EstruturaDeControle;
using CursoCScharp.ClassesEMetodos;
using System;
using System.Collections.Generic;
using CursoCScharp.Colecoes;
using CursoCScharp.Orientacao_a_Obj;
using CursoCScharp.MetodosFuncoes;
using static CursoCScharp.Excecoes.Conta;
using CursoCScharp.Excecoes;
using CursoCScharp.API;
using CursoCScharp.TopicoAvancados;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Variaveis E Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"Interpolacao - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Numeros - Fundamentos", FormatandoNumero.Executar},
                {"Conversoes - Fundamentos", Conversoes.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operadores Ternario - Fundamentos", OperadorTernario.Executar},

                // Estrutura de Controle
                {"Estrutura IF - Estrutura de Controle", EstruturaIf.Executar},
                {"Estrutura IF Else - Estrutura de Controle", EstruturaIfElse.Executar},
                {"Estrutura IF ElseIf - Estrutura de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estrutura de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estrutura de Controle", EstruturaWhile.Executar},
                {"Estrutura JogoWhileLula - Estrutura de Controle", JogoWhileLula.Executar},
                {"Estrutura DoWhile - Estrutura de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estrutura de Controle", EstruturaFor.Executar},
                {"Estrutura ForEach - Estrutura de Controle", EstruturaForEach.Executar},
                {"Estrutura UsandoBreak - Estrutura de Controle", EstruturaForEach.Executar},
                {"Estrutura Usando Continue - Estrutura de Controle", UsandoContinue.Executar},

                //Classes e Metodos
                {"Membros - Classes e Metodos", Membros.Executar},
                {"Contrutores - Classes e Metodos", Construtores.Executar},
                {"Metodos com Retorno - Classes e Metodos", MetodosComRetorno.Executar},
                {"Metodos Estaticos - Classes e Metodos", MetodosStaticos.Executar},
                {"Atributos Estaticos - Classes e Metodos", AtributoEstaticos.Executar},
                {"Desafio Atributo - Classes e Metodos", DesafioAtributo.Executar},
                {"Get e Set - Classes e Metodos", GetSet.Executar},
                {"Propriedades - Classes e Metodos", Props.Executar},
                {"Read Only - Classes e Metodos", Readonly.Executar},
                {"Exemplo Enum - Classes e Metodos", ExemploEnum.Executar},
                {"Struct - Classes e Metodos",ExemploStruct.Executar},
                {"Struct vs Classes - Classes e Metodos",StructVsClasse.Executar},
                {"Valor Vs Referencia - Classes e Metodos",ValorVsReferencia.Executar},
                {"Parametros Por Referencia - Classes e Metodos",ParametrosPorReferencia.Executar},

                //Coleções
                {"Array - Coleções",ExArray.Executar},
                {"List - Coleções",ExList.Executar},
                {"ArrayList - Coleções",ExArrayList.Executar},
                {"ExSet - Coleções",ExSet.Executar},
                {"ColecoesQueue - Coleções",ColecoesQueue.Executar},
                {"Stack - Coleções",ExStack.Executar},
                {"Dictionary - Coleções",ColecaoDictionary.Executar},


                //Orientação a Ojs
                {"Herança - Orientação a Objetos ",Heranca.Executar},
                {"Encapsulamento - Orientação a Objetos ",ExEncapsulamento.Executar},
                {"Polimorfismo - Orientação a Objetos ",Polimorfismo.Executar},
                {"Abstract - Orientação a Objetos ",Abstrato.Executar},



                //Metodos e Funções
                {"Lambda - Metodos e Funções ",Exemplo_Lambda.Executar},
                {"Lambda Delegate - Metodos e Funções ",LambdasDelegate.Executar},
                {"Usando Delegates - Metodos e Funções ",UsandoDelegate.Executar},
                {"Delegates com Função Anonima - Metodos e Funções ",DelegateFuncAnonima.Executar},
                {"Delegates como Parametros - Metodos e Funções ",DelegateFuncAnonima.Executar},


                //Exceções
                {"Primeira Exceção - Exceções ", PrimeiraExcecao.Executar},
                {"Primeira Exceção Personalizada - Exceções ", ExcecoesPersonalizadas.Executar},



                //API
                {"Primeria Usando API - API ", PrimeiroArquivo.Executar},


                //Topicos Avançãdos
                {"Linq - Topicos Avançados ", Linq.Executar},
                {"Linq2 - Topicos Avançados ", Linq2.Executar},
                {"Nullables - Topicos Avançados ", Nullables.Executar},
                {"Dynamics - Topicos Avançados ", Dynamics.Executar},
                {"Generics - Topicos Avançados ", Generics.Executar},
                
            });

            central.SelecionarEExecutar();
        }
    }
}