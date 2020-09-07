
# Perguntas teóricas de introdução
1. **Em quais linguagens o C# foi inspirado?**
 
- C# (C-Sharp) é uma linguagem de programação orientada a objetos desenvolvida pela Microsoft, e está entre as mais utilizadas no mundo. Possui uma sintaxe bem parecida com outras linguagens populares como C, C++, Java e Object Pascal. É considerada por programadores como simples de aprender. O C# Foi desenvolvida pela Microsoft por uma equipe liderada por Anders Hejlsberg (responsável também pelo desenvolvimento do Delphi e Turbo Pascal), que inicialmente a denominou como linguagem Cool. O desenvolvimento iniciou em 1999 e a linguagem foi lançada em 2002 como parte da plataforma .NET. 

2. **Inicialmente o C# foi criado para qual finalidade?**
- O C# surgiu com a finalidade de possibilitar a criação de soluções executáveis sobre a plataforma .NET Framework, com o intuito de flexibilizar o desenvolvimento de aplicativos. Dessa maneira, o desenvolvedor não cria soluções para um dispositivo eletrônico específico, e sim para a plataforma .NET Framework.

3. **Quais os principais motivos para a Microsoft ter migrado para o Core?**
-  Plataforma cruzada: É executado em sistemas operacionaisWindows, MacOS e Linux.
-  Código-fonte aberto: O .NET Core Framework é um software livre, usando as licenças MIT e Apache 2. O .NET Core é um projeto do .NET Foundation.
-  Moderno: Ele implementa paradigmas modernos como programação assíncrona, padrões sem cópia usando structs e governança de recursos para contêineres.
-  Desempenho: Fornece alto desempenho com recursos como intrínsecos de hardware, compilação em camadase span <T> .
-  Consistente entre ambientes: Executa o código com o mesmo comportamento em vários sistemas operacionais e arquiteturas, incluindo x64, x86 e ARM.
-  Ferramentas de linha de comando: Inclui ferramentas de linha de comando fáceis de usar que podem ser usadas para o desenvolvimento local e para a integração contínua.
-  Implantação flexível: Você pode incluir o .NET Core em seu aplicativo ou instalá-lo lado a lado (instalações em todo o usuário ou todo o sistema). Pode ser usado com os contêineres do Docker.
  
4. **Cite as principais diferenças entre .Net Full Framework e .Net Core.**
- O .NET Framework é usado para desenvolvimento de aplicações Windows usando Windows Forms , WPF e de aplicações Web usando ASP .NET MVC.
  - Use o .NET Framework para o aplicativo para servidores se:
    - *Seu aplicativo usar o .NET Framework atualmente (a recomendação é estender em vez de migrar).*
    - *Seu aplicativo usa bibliotecas .NET de terceiros ou pacotes NuGet não disponíveis para o .NET Core.*
    - *Seu aplicativo usa tecnologias .NET que não estão disponíveis para o .NET Core.*
    - *Seu aplicativo usa uma plataforma que não oferece suporte ao .NET Core. Windows, macOS e Linux dão suporte ao .NET Core.*
- O .NET Core é open-source e multiplataforma e suporta UWP e as bibliotecas da ASP .NET Core. A UWP é usada para criar aplicação Windows 10 e a ASP .NET Core é usada para criar aplicações Web para Windows, Linux e Mac.
  - Use o .NET Core para o aplicativo para servidores se:
    - *Você tiver necessidades de plataforma cruzada.*
    - *Você está direcionando para os microserviços.*
    - *Você está usando contêineres do Docker.*
    - *Você precisar de alto desempenho e sistemas escalonáveis.*
    - *Você precisar de versões do .NET correspondentes a cada aplicativo*.

# Utilizando POO
## **Responda e demonstre no código os itens abaixo:**

1. **O que é POO?**
   - Programação orientada a objetos(**POO**) é um paradigma de programação baseado no conceito de "**objetos**", que podem conter dados na forma de campos, também conhecidos como atributos, e códigos, na forma de procedimentos, também conhecidos como métodos. Uma característica de objetos é que um procedimento de objeto pode acessar, e geralmente modificar, os campos de dados do objeto com o qual eles estão associados (objetos possuem uma noção de "*this*" (este) ou "*self*" (próprio)). Em POO, programas de computadores são projetados por meio da composição de objetos que interagem com outros.Há uma diversidade significante de linguagens de POO, mas as mais populares são aquelas baseadas em classes, significando que objetos são instâncias de classes, que, normalmente, também determinam seu tipo.
   - Os quatros pilares da POO são:
     - *Abstração*;
     - *Encapsulamento*;
     - *Herança*; 
     - *Polimorfismo*.
2. **O que é polimorfismo?**
   - O conceito é a propriedade de duas ou mais classes derivadas de uma mesma superclasse responderem a mesma mensagem, cada uma de uma forma diferente. Ocorre quando uma subclasse redefine um método existente na superclasse, ou seja, quando temos os métodos sobrescritos (overriding).
3. **O que é abstração?**
   - É o processo de identificar as qualidades ou propriedades importantes do problema que está sendo modelado. Através de um modelo abstrato, pode-se concentrar nas características relevantes e ignorar as irrelevante.
4. **O que é encapsulamento?**
   - É o conceito de separar o programa em partes, o mais isoladas possível. A ideia é tornar o software mais flexível, fácil de modificar e de criar novas implementações.
5. **Quando usar uma classe abstrata e quando devo usar uma interface?**
   - Usamos Interface quando precisamos que classes de diferentes origens (herança) tenham métodos em comum e possam ser acessados através de uma mesma variável. A classe abstrata é utilizada quando você quer que uma classe que herde dela implemente alguns métodos, mas que também possam ter métodos implementados na própria classe abstrata.
6. **O que faz as interfaces IDisposable, IComparable, ICloneable e IEnumerable?**
   - *IDisposable*: O uso principal dessa interface é para liberar recursos não-gerenciados. O coletor de lixo automaticamente libera a memória alocada para um objeto gerenciado quando esse objeto não é mais usado. No entanto, não é possível prever quando ocorrerá a coleta de lixo. Além disso, o coletor de lixo não tem conhecimento de recursos não gerenciados, como identificadores de janela, ou abrir arquivos e fluxos.
   - *IComparable*: A interface IComparable define um método genérico de comparação específica de tipo que um tipo de valor ou classe implementa para ordenar ou classificar suas instâncias. Essa interface é implementada por tipos cujos valores podem ser ordenados ou classificados. Ela requer que os tipos de implementação definam um único método, CompareTo(Object) , que indica se a posição     da instância atual na ordem de classificação é antes, depois, ou o mesmo que um segundo objeto do mesmo tipo.
   - *ICloneable*: A interface ICloneable dá suporte à clonagem, que cria uma nova instância de uma classe com o mesmo valor de uma instância existente.Esta interface contém o método Clone que dá suporte à clonagem além do que é fornecido pelo método  Object.MemberwiseClone que cria uma cópia superficial de Object atual.
   - *IEnumerable*: A interface IEnumerable suporta uma iteração sobre uma coleção não genérica. A interface possui apenas o método GetEnumerator que retorna um enumerador que itera sobre a coleção.
7. **Existe herança múltipla (de classes) em C#?**
   - A linguagem C# não suporta herança múltipla de classes. Para superar esse problema, podemos usar interfaces onde uma classe pode implementar mais de uma interface ou de uma classe e de uma ou mais de uma interface.

# Trabalhando com testes
1. Quais os principais frameworks que podemos usar no desenvolvimento de testes?
   - OS frameworks de testes disponíveis para o .NET Core 3.0 e 3.1:
     - xUnit, 
     - MS Test, 
     - NUnit, 
     - Moq, 
     - NSubstitute, 
     - Fluent Assertions e 
     - Selenium WebDriver





# Referências
- https://www.portalgsti.com.br/csharp/sobre/
- https://docs.microsoft.com/pt-br/dotnet/standard/choosing-core-framework-server
- http://www.macoratti.net/16/11/net_framcore1.htm#:~:text=NET%20Framework%20%C3%A9%20usado%20para,e%20as%20bibliotecas%20da%20ASP%20.
- https://docs.microsoft.com/pt-br/dotnet/core/about
- http://www.macoratti.net/18/12/netcore_netframe1.htm#:~:text=NET%20Core%20%C3%A9%20uma%20plataforma,como%20Windows%2C%20Mac%20e%20Linux.&text=NET%20correspondentes%20a%20cada%20aplicativo.
- https://pt.wikipedia.org/wiki/Programa%C3%A7%C3%A3o_orientada_a_objetos
- http://www.facom.ufu.br/~flavio/poo/files/2004-01/Poo-tad.pdf
- https://pt.wikibooks.org/wiki/Programa%C3%A7%C3%A3o_Orientada_a_Objetos/Encapsulamento#:~:text=Encapsulamento%20vem%20de%20encapsular%2C%20que,e%20de%20criar%20novas%20implementa%C3%A7%C3%B5es.
- https://www.guj.com.br/t/quando-usar-a-classe-abstrata-e-a-interface/48122/3
- http://www.macoratti.net/19/05/c_iclone1.htm
- https://docs.microsoft.com/pt-br/dotnet/api/system.icloneable?view=netcore-3.1
- http://www.macoratti.net/18/01/c_uinterf1.htm
- http://www.macoratti.net/18/06/c_tiphera1.htm#:~:text=A%20linguagem%20C%23%20n%C3%A3o%20suporta,ou%20mais%20de%20uma%20interface.
- https://medium.com/@renato.groffe/testes-de-software-com-net-core-3-x-exemplos-de-utiliza%C3%A7%C3%A3o-7174560bc5e0