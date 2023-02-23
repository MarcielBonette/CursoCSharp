using CursoCSharp._2.Fundamentos;
using CursoCSharp.Fundamentos;
using CursoCSharp._2.EstruturaDeControle;
using CursoCSharp._2.ClassesEMetodos;
using CursoCSharp._2.Colecoes;
using CursoCSharp._2.OO;
using CursoCSharp._2.MetodosEFuncoes;
using CursoCSharp._2.Exceções;
using CursoCSharp._2.Api;
using CursoCSharp._2.TopicosAvançados;
namespace CursoCSharp
{
    class Program
    {
       static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos" , Comentários.Executar },
                {"Variáveis e Constantes - Fundamentos" , VariáveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Números - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                { "Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                { "Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                { "Operadores Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                { "Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                { "Operadores Ternários - Fundamentos", OperadorTernarios.Executar},

                //Estruturas de Controle
                { "Estrutura IF - Estruturas de Controle", EstruturaIf.Executar},
                { "Estrutura IF/Else - Estruturas de Controle", EstruturaIfElse.Executar},
                { "Estrutura IF/Else If - Estruturas de Controle", EstruturaIfElseIf.Executar},
                { "Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar},
                { "Estrutura While - Estruturas de Controle", EstruturaWhile.Executar},
                { "Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar},
                { "Estrutura For - Estruturas de Controle", EstruturaFor.Executar},
                { "Estrutura For Each - Estruturas de Controle", EstruturaForEach.Executar},
                { "Usando Break - Estruturas de Controle", UsandoBreak.Executar},
                { "Continue - Estruturas de Controle", UsandoContinue.Executar},

                //Classes e Métodos
                { "Membros - Classes e Métodos", Membros.Executar},
                { "Construtores - Classes e Métodos", Construtores.Executar},
                { "Métodos com Retorno - Classes e Métodos", MetodosComRetorno.Executar},
                { "Métodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar},
                { "Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar},
                { "Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar},
                { "Params - Classes e Métodos", Params.Executar},
                { "Parametros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                { "Get Set - Classes e Métodos", GetSet.Executar},
                { "Props - Classes e Métodos", Props.Executar},
                { "Read Only - Classes e Métodos", Readonly.Executar},
                { "Enum - Classes e Métodos", ExemploEnum.Executar},
                { "Struct - Classes e Métodos", ExemploStruct.Executar},
                { "Struct vs Classe - Classes e Métodos", StructVsClasse.Executar},
                { "Valor vs Referência - Classes e Métodos", ValorVsReferencia.Executar},
                { "Parâmetros por Referência - Classes e Métodos", ParametrosPorReferencia.Executar},
                { "Parâmetros por Valor Padrão - Classes e Métodos", ParametroPadrao.Executar},
                
                //Coleções
                { "Array - Coleções", _2.Colecoes.Array.Executar},
                { "List - Coleções", ColecoesList.Executar},
                { "Array List - Coleções", ColecoesArrayList.Executar},
                { "Set - Coleções", ColecoesSet.Executar},
                { "Queue - Coleções", ColecoesQueue.Executar},
                { "Igualdade - Coleções", Igualdade.Executar},
                { "Stack - Coleções", ColecoesStack.Executar},
                { "Dictionary - Coleções", ColecoesDictionary.Executar},

                //OO
                { "Herança - OO", Heranca.Executar},
                { "Construtor This - OO", ConstrutorThis.Executar},
                { "Encapsulamento - OO", _2.OO.Encapsulamento.Executar},
                { "Polimorfismo - OO", Polimorfismo.Executar},
                { "Abstract - OO", Abstract.Executar},
                { "Interface - OO", Interface.Executar},
                { "Sealed - OO", Sealed.Executar},
                
                // Métodos e Funções
                { "Exemplo Lambda - Métodos e Funções", ExemploLambda.Executar},
                { "Lambda como Delegate - Métodos e Funções", LambdaDelegate.Executar},
                { "Delegate - Métodos e Funções", UsandoDelegates.Executar},
                { "Delegates Como Função Anônima - Métodos e Funções", DelegateFuncAnonima.Executar},
                { "Delegates Como Parâmetros - Métodos e Funções", DelegatesComoParametros.Executar},
                { "Métodos de Extensão - Métodos e Funções", MetodosDeExtensao.Executar},
                
                //Exceções
                { "Primeira Exceção - Exceções", PrimeiraExcecao.Executar},
                { "Exceções Personalizadas - Exceções", ExcecoesPersonalizadas.Executar},
                
                
                // Api
                { "Primeiro Arquivo - Api", PrimeiroArquivo.Executar},
                { "Lendo Arquivos - Api", LendoArquivos.Executar},
                { "Exemplo FileInfo - Api", ExemploFileInfo.Executar},
                { "Diretorios - Api", Diretorios.Executar},
                { "Exemplo Directory Info - Api", ExemploDirectoryInfo.Executar},
                { "Exemplo Path - Api", ExemploPath.Executar},
                { "Exemplo DateTime - Api", ExemploDateTime.Executar},
                { "Exemplo TimeSpan - API", ExemploTimeSpan.Executar},

                //Tópicos Avançados

                { "LINQ #1 - Tópicos Avançados", LINQ1.Executar},
                { "LINQ #2 - Tópicos Avançados", LINQ2.Executar},
                { "Nullables - Tópicos Avançados", Nullables.Executar},
                { "Dynamics - Tópicos Avançados", Dynamics.Executar},
                { "Genéricos - Tópicos Avançados", Genericos.Executar},



            }) ; ;

            central.SelecionarEExecutar();
        }

        internal static double calcularMedia(double v1, double v2, double v3, out string conceito)
        {
            throw new NotImplementedException();
        }
    }
}