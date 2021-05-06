# SOLID

### SRP - The Single Responsibility Principle / Principio da Responsabilidade Única.
Uma classe e/ou uma função deve ter um, e somente um, motivo para mudar. Cada Função deve ser responsável por uma única tarefa.

Obs: O nome da função deve trazer ao entendimento aquilo que ela realmente concebe. Se estiver difícil nomear uma função, é provável
que ela esteja fazendo mais do que deveria.

<br>


### OCP - The Open Closed Principle / Princípio Aberto-Fechado
Aberto para extensão, fechado para modificação. Ou seja, precisamos ser capazes de estender um comportamento, adicionar uma nova funcionalidade em um módulo sem precisar modificar a base desse código. As mudanças naquilo que já existe precisam ser mínimas, se possível zero. 

Para isso, primeiramente, precisamos definir uma base de código, ou seja, separar aquilo que é imutável daquilo que é mutável. Podemos chamar a parte imutável de abstração, e a parte mutável de implementação.

Depois disso precisamos proteger aquilo que definimos como imutável. Geralmente as abstrações mais altas (interfaces, classes abstratas, etc) precisam ser protegidas de modificações feitas em componentes de nível mais baixo. Por isso se diz: fechado para modificação.

E não somente as interfaces e classes abstratas precisam ser protegidas, mas todas as entidades precisam ser protegidas de modificação feitas em um nível a baixo. Concluímos então que componentes de nivel mais alto devem ser protegidos de mudanças feitas em componentes de nível mais baixo.

<br>


### LSP - The Liskov Substitution Principle / Principio da Substituição de Liskov
As classes derivadas devem ser capazes de substituir suas classes bases. 

<br>


### ISP - The Interface Segregation Principle / Principio da Segregação por Interface
Nenhuma classe deve ser forçada a implementar métodos que não utiliza. Depender de interfaces específicas é melhor que depender de interfaces genéricas. 

Imagine que uma interface IMethods tenha assinatura de dois métodos: MethodA e MethodB. Uma classe X utilize apenas o MethodA dessa interface. Toda vez que 
uma alteração for feita no MethodB da interface a classe X será impactada com um novo build, mesmo que o MethodB não faça nenhum sentido para ela.

<br>


### DIP - The Dependency Inversion Principle / Principio da Inversão de Dependência.
Boas implementações de software tentam criar interfaces / abstrações estáveis, ou seja, que não sofrem mudança. 
Logo, arquiteturas de software estáveis são aquelas que evitam depender de implementações concretas instáveis. 

<br>
<br>


[Artigo de referência](https://github.com/mviegas/SOLID)
