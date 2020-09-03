# Grafos - Desafio do Rede Ótica 🏕️
Código desenvolvido para resolução do desafio https://br.spoj.com/problems/DRAGAOMG/

## Problema - Rede Ótica interligando as tabas 🖧
Os caciques da região de Tutuaçu pretendem integrar suas tribos à chamada “aldeia global”. A primeira providência foi a distribuição de telefones celulares a todos os pajés. Agora, planejam montar uma rede de fibra ótica interligando todas as tabas. Esta empreitada requer que sejam abertas novas picadas na mata, passando por reservas de flora e fauna. Conscientes da necessidade de preservar o máximo possível o meio ambiente, os caciques encomendaram um estudo do impacto ambiental do projeto. Será que você consegue ajudá-los a projetar a rede de fibra ótica?

## Desenvolvimento da Solução :dart:
  Para solucionar problemas baseados em encontrar o menor custo de
conexão entre diferentes pontos, a Teoria dos Grafos apresenta soluções
plausíveis de serem implementadas em computadores em forma de
algoritmos.<br/>
  Sendo assim, o problema apresentado foi estudado e as entradas de
dados foram analisadas. Após isso, a melhor solução encontrada pelo grupo
foi criar uma Árvore Geradora Mínima, em que os vértices do grafo são
definidos pelas tabas e o peso das arestas que os conectam é definido pelo
impacto ambiental.<br/>
  A fim de obter a Árvore Geradora Mínima de um grafo, dois algoritmos
conhecidos apresentam um bom desempenho e possuem o mesmo
resultado, sendo esses: Kruskal e Prim. A priori, escolhemos o Algoritmo de
Kruskal, o qual efetua a conexão de todos os vértices do grafo com o menor
custo possível, sem gerar ciclos. Entretanto, tendo em vista que solucionar o
problema dessa maneira seria uma tarefa simples, optamos por não utilizar
nenhum destes algoritmos, desenvolvendo outra solução.<br/>
  Portanto, a solução desenvolvida baseia-se no algoritmo Union-Find,
o qual mantém o controle de um conjunto de elementos particionados em
subconjuntos disjuntos (não sobre-posicionados). Ele fornece operações com
tempo quase constante (delimitadas pela inversa função de Ackermann) para
adicionar novos conjuntos, para mesclar conjuntos existentes e para
determinar se os elementos estão no mesmo conjunto.
1. [:orange_book: Relátorio em Documento da Solução](documento.pdf)
1. [:blue_book: Apresentação em Slide da Solução](apresentacao.pdf)

## Confirmação da Solução :+1:
![image](image.png)

## O Código :pushpin:
1. [:computer: Código da Solução](codigo.cs)

## Licença
Este projeto está sob a Licença [MIT](LICENSE.md)

