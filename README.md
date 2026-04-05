# Exercício Prático: O "Caos na Cantina"

## Cenário

A cantina da universidade lançou um sistema console para agilizar os pedidos. Porém, os alunos estão reclamando que o sistema é uma "armadilha": se você digita algo errado, ele fecha; se você se arrepende de um item, não tem como voltar; e o sistema não explica o que está acontecendo.

---

## O Problema (Código Base)

Imagine um código que pede o Código do Produto, depois a Quantidade, e já finaliza o pedido sem confirmar nada e sem tratar se o usuário digitar uma letra no lugar de um número.

---

## Sua Missão

Você deve criar uma aplicação console em C# (.NET) que resolva esse fluxo, aplicando pelo menos 3 Heurísticas de Nielsen.

---

## Requisitos Técnicos

1. Heurística #1 (Visibilidade do Status): Implemente uma barra de progresso simples ou mensagens que indiquem em qual etapa do pedido o aluno está (ex: [Passo 1 de 3] Seleção de Item).
2. Heurística #3 (Controle e Liberdade): O aluno deve conseguir digitar voltar em qualquer etapa para corrigir a informação anterior, ou cancelar para abortar tudo.
3. Heurística #9 (Ajuda e Erros): Se o aluno digitar um código de produto que não existe, o sistema não pode apenas exibir uma mensagem genérica. Ele deve dizer: "Código 99 não encontrado. Nossos códigos vão de 1 a 10. Tente novamente."
