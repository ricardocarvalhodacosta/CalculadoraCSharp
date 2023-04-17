# CalculadoraCSharp

Afim de criar um método para estudar e evoluir com a linguagem C#, resolvi recriar alguns projetos meus aqui do GitHub.
Inicialmente comecei pela calculadora em C, que agora é a CalculadoraC#. Futuramente irei criar uma interface gráfica para ela,
por enquanto ela é utilizada apenas em uma aplicação de console. Segue um exemplo abaixo:

#Vídeo Demonstrativo da aplicação em Console

https://user-images.githubusercontent.com/115588683/232607210-49b3ddb5-9da9-4663-9472-344689a0cf51.mp4

#Explicando

As funções que foram adicionadas para a Calculadora foram:

1. Adição;
2. Subtração;
3. Divisão;
4. Multiplicação;
5. Porcentagem;

O programa inicia perguntando qual operação matemática o usuário gostaria de utilizar e pede o número correspondente (1, 2, 3...).
Então, entramos em um looping while que mantem o usuário dentro da calculadora até que ele deseje encerrar o programa.
É solicitado os valores de X e Y para fazer os calculos e logo é impresso o resultado.
Ao ser impresso o resultado, é perguntado ao usuário de ele deseja continuar fazendo operações e caso seja digitado "s/S",
o looping começa e retorna para a escolha de operações. A qualquer momento do termino de uma operação, se o usuário digitar "n/N",
a calculadora return 0 e encerra o seu funcionamento.
