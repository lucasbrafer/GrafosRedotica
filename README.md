# Grafos - Desafio do Rede Ótica 🏕️
Código desenvolvido para resolução do desafio https://br.spoj.com/problems/REDOTICA/

## Problema - Rede Ótica interligando as tabas 🖧
Os caciques da região de Tutuaçu pretendem integrar suas tribos à chamada “aldeia global”. A primeira providência foi a distribuição de telefones celulares a todos os pajés. Agora, planejam montar uma rede de fibra ótica interligando todas as tabas. Esta empreitada requer que sejam abertas novas picadas na mata, passando por reservas de flora e fauna. Conscientes da necessidade de preservar o máximo possível o meio ambiente, os caciques encomendaram um estudo do impacto ambiental do projeto. Será que você consegue ajudá-los a projetar a rede de fibra ótica?

## Desenvolvimento da Solução :dart:
Feito toda a modelagem e desenvolvimento do problema, foi gerado a solução de se utilizar um **Árvore Geradora Mínima**,  onde seus vértices do grafo são definidos pelas tabas e o peso das arestas que os conectam é definido pelo impacto ambiental. A fim de obter a Árvore Geradora Mínima de um grafo, dois algoritmos conhecidos apresentam um bom desempenho e possuem o mesmo resultado, sendo esses: **Kruskal** e **Prim** porém para fins didáticos foi desenvolvido uma solução própria baseada no **Union-Find**, o qual mantém o controle de um conjunto de elementos particionados em subconjuntos disjuntos (não sobre-posicionados).
1. [:orange_book: Relátorio em Documento da Solução](documento.pdf)
1. [:blue_book: Apresentação em Slide da Solução](apresentacao.pdf)

## Confirmação da Solução :+1:
![image](image.png)

## O Código :pushpin:
1. [:computer: Código da Solução](codigo.cs)

## Licença
Este projeto está sob a Licença [MIT](LICENSE.md)

