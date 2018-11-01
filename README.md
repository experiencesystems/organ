# Organ

O famoso sistema de gerenciamento de agroneg�cio

##Como editar e colaborar
####Nesse site tamb�m explica direitinho como funciona cada coisa: https://git-scm.com/book/pt-br/v1/Primeiros-passos
###Clonar reposit�rio
Antes de tudo, baixe o SourceTree: https://br.atlassian.com/software/sourcetree

A partir dele, voc� pode clonar o reposit�rio (passar os arquivos pro seu computador) indo em:

+ Arquivo
+ Clonar/Novo (Ctrl+N)
+ Remote
+ Adicionar uma conta
+ Depois de fazer a autentica��o (talvez precise de um tal de OAuth), vai aparecer o reposit�rio Organ
+ Clique em Clone (canto direito do reposit�rio)
+ Procure uma pasta vazia no seu computador e d� um nome
+ Clique em Clonar
###Come�ando a editar
Agora esque�a o SourceTree porque ele � confuso pra caralho.

No canto direito dele tem um bot�o "Terminal", clique nele.

Agora seguinte, a parte que voc� for fazer (como nada � definitivo) n�o vai pro branch principal (master). O master s� serve pra colocar tudo que j� t�
revisado e pronto. Ent�o tem que trabalhar em um branch diferente, e para isso tem que cri�-lo de acordo com o que voc� vai fazer. Por exemplo, se voc�
for fazer a tela colheita, crie um branch pra isso.

**Se for fazer um checkout, fa�a antes de fazer qualquer altera��o (s� de abrir o Visual Studio j� altera um arquivo .suo, ent�o cuidado com isso)**

`git checkout -b 'nome_do_branch_novo'`

Nesse c�digo ele vai fazer checkout (sair do branch que estava, que era o master) e cria um novo branch com o nome escolhido.

Se voc� fosse mudar para um branch j� existente, � s� colocar

`git checkout 'nome_do_branch_existente'`

Fa�a as altera��es no c�digo pelo Visual Studio, mas lembrando, **Apenas a sua parte**, se estiver fazendo Colheita, se alterar o Plantio vai dar erro
pra juntar o c�digo posteriormente e d� erro pra caralho. Se o c�digo da pessoa que estiver fazendo o Plantio estiver errado, crie um Issue no site do
BitBucket pra informar que deu erro.

###Recebendo altera��es
Suponhamos que algu�m terminou uma nova fun��o na tela In�cio. Pra todos terem acesso a isso, pode ir no pr�prio Visual Studio:

+ V� na janela do Team Explorer (se n�o tiver, adicione)
+ Clique na casinha
+ Sincronizar
+ Efetuar pull

Se quiser ver se algo foi alterado, se voc� precisa enviar alguma coisa ou algo do tipo, use

`git status`

Agora voc� j� tem acesso a todas as altera��es

###Enviando mudan�as no c�digo

Lembrando que j� era necess�rio estar no branch que voc� vai enviar as coisas, fazer checkout agora s� vai fuder tudo.

A op��o mais f�cil pra fazer isso � no Terminal com a ajuda do SourceTree.

+ Vai ter uma barrinha com todas as altera��es e voc� clica em preparar tudo
+ No terminal digite `git commit -a -m 'Mudei a tela colheita'`

Agora j� vai ter feito commit (enviado as altera��es).

Ap�s isso, se for mudar outra coisa (se for algo diferente do que tava fazendo antes), fa�a checkout como no in�cio desse texto.

E mano, n�o adianta ir muito al�m disso pq d� merda. � isso.