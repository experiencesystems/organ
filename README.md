# Organ

O famoso sistema de gerenciamento de agronegócio

##Como editar e colaborar
####Nesse site também explica direitinho como funciona cada coisa: https://git-scm.com/book/pt-br/v1/Primeiros-passos
###Clonar repositório
Antes de tudo, baixe o SourceTree: https://br.atlassian.com/software/sourcetree

A partir dele, você pode clonar o repositório (passar os arquivos pro seu computador) indo em:

+ Arquivo
+ Clonar/Novo (Ctrl+N)
+ Remote
+ Adicionar uma conta
+ Depois de fazer a autenticação (talvez precise de um tal de OAuth), vai aparecer o repositório Organ
+ Clique em Clone (canto direito do repositório)
+ Procure uma pasta vazia no seu computador e dê um nome
+ Clique em Clonar
###Começando a editar
Agora esqueça o SourceTree porque ele é confuso pra caralho.

No canto direito dele tem um botão "Terminal", clique nele.

Agora seguinte, a parte que você for fazer (como nada é definitivo) não vai pro branch principal (master). O master só serve pra colocar tudo que já tá
revisado e pronto. Então tem que trabalhar em um branch diferente, e para isso tem que criá-lo de acordo com o que você vai fazer. Por exemplo, se você
for fazer a tela colheita, crie um branch pra isso.

**Se for fazer um checkout, faça antes de fazer qualquer alteração (só de abrir o Visual Studio já altera um arquivo .suo, então cuidado com isso)**

`git checkout -b 'nome_do_branch_novo'`

Nesse código ele vai fazer checkout (sair do branch que estava, que era o master) e cria um novo branch com o nome escolhido.

Se você fosse mudar para um branch já existente, é só colocar

`git checkout 'nome_do_branch_existente'`

Faça as alterações no código pelo Visual Studio, mas lembrando, **Apenas a sua parte**, se estiver fazendo Colheita, se alterar o Plantio vai dar erro
pra juntar o código posteriormente e dá erro pra caralho. Se o código da pessoa que estiver fazendo o Plantio estiver errado, crie um Issue no site do
BitBucket pra informar que deu erro.

###Recebendo alterações
Suponhamos que alguém terminou uma nova função na tela Início. Pra todos terem acesso a isso, pode ir no próprio Visual Studio:

+ Vá na janela do Team Explorer (se não tiver, adicione)
+ Clique na casinha
+ Sincronizar
+ Efetuar pull

Se quiser ver se algo foi alterado, se você precisa enviar alguma coisa ou algo do tipo, use

`git status`

Agora você já tem acesso a todas as alterações

###Enviando mudanças no código

Lembrando que já era necessário estar no branch que você vai enviar as coisas, fazer checkout agora só vai fuder tudo.

A opção mais fácil pra fazer isso é no Terminal com a ajuda do SourceTree.

+ Vai ter uma barrinha com todas as alterações e você clica em preparar tudo
+ No terminal digite `git commit -a -m 'Mudei a tela colheita'`

Agora já vai ter feito commit (enviado as alterações).

Após isso, se for mudar outra coisa (se for algo diferente do que tava fazendo antes), faça checkout como no início desse texto.

E mano, não adianta ir muito além disso pq dá merda. É isso.