# SOLID

### SRP - The Single Responsibility Principle / Principio da Responsabilidade Única.
        Uma classe deve ter um, e somente um, motivo para mudar.
        Cada Função deve ser responsável por uma única tarefa.        
        Obs: Colocar no nome da Função tudo o que ela faz. Se for difícil dar um nome pra ela, revisá-la.


### OCP - The Open Closed Principle / Princípio Aberto-Fechado
        Aberto para extensão, fechado para modificação.
        Você deve ser capaz de estender um comportamento de uma classe, sem modificá-la.
        Obs: Utiliza a sobrescrita (abstract ou virtual) de método para os métodos que podem ter diferentes comportamentos nas classes derivadas.


### LSP - The Liskov Substitution Priciple / Principio da Substituição de Liskov
        As classes derivadas devem poder substituir suas classes bases. 
        Isso faz você pensar se a classe base está fornecendo somente aquilo que é comum para todas as suas subclasses.
        Esse princípio vai te forçar a respeitar o princpipio anterior (Open Closed Principle).
        Obs: No C# isso só é possível se a classe base NÃO for Abstract. Pois, esse tipo de classe não pode ser instanciado, 
        logo não há o que se falar de substituí-la.


### ISP - The Interface Segregation Principle / Principio da Segregação por Interface
        Não tente reaproveitar todas as suas interfaces. 
        Pois, "Nenhuma classe deve ser forçada a implementar métodos que não utiliza."
        Faça interfaces específicas para classes diferentes. 


### DIP - The Dependency Inversion Principle / Principio da Inversão de Dependência.
        Dependa de uma abstração e não de uma implementação.
        Nunca dependa dos detalhes de uma implementação de outro módulo. Crie uma abstração entre eles. No caso, a interface. 
