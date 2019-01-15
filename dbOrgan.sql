create database dbOrgan;
GO

use dbOrgan; 
GO


create table tbEndereco(
cep char(8) not null,
numero int not null,
rua varchar(50) not null,
bairro varchar(50) not null,
complemento varchar(20),
cidade varchar(50) not null,
uf char(2) not null,
constraint PK_tbEndereco primary key clustered (cep, numero)
);
GO

create table tbEstoque (
cod_estoque int identity(1,1) constraint PK_tbEstoque primary key,
qtd_estoque int not null,
unidade_medida char(3) not null
); 
GO

create table tbFornecedor (
cod_fornecedor int identity(1,1) constraint PK_tbFornecedor primary key,
nome_fantasia varchar(50) not null,
cnpj_forn char(15) not null,
status_forn char(7) not null constraint DF_tbFornecedor_status default 'Ativo', --ativo ou inativo (ADICIONADO)
razao_social varchar(70),
tel_forn char(11),
email_forn varchar(100),
site_forn varchar(200),
cep_forn char(8) not null,
num_forn int not null,
constraint FK_tbFornecedor_tbEndereco foreign key(cep_forn, num_forn) references tbEndereco(cep,numero)
);
GO

create table tbHistorico_Estoque (
cod_estoque int,
data_alteracao datetime constraint DF_tbHistorico_data default GETDATE(),
qtd_antiga int constraint DF_tbHistorico_qtdantiga default 0,
qtd_alt int constraint DF_tbHistorico_qtdalt default 0,
unidade_medida char(3) not null,
desc_hist varchar(200),
constraint FK_tbHistorico_tbEstoque foreign key(cod_estoque) references tbEstoque(cod_estoque),
);
GO

create table tbTalhao (
cod_talhao int identity(1,1) constraint PK_tbTalhao primary key,
nome_tal varchar(50),
tam_tal int not null,
tipo_solo_tal varchar(25) not null,
inc_solar_tal decimal(5,2),
inc_vento_tal decimal(5,2),
acidez_tal decimal(5,2),
disponivel_tal char(12) not null,
constraint CK_tbTalhao_tam check (tam_tal > 0)
);
GO

create table tbFuncionario (
cod_funcionario int identity(1,1) constraint PK_tbFuncionario primary key,
nome_func varchar(70) not null,
cpf_func char(11) not null,
rg_func char(9) not null,
status_func char(8) not null constraint DF_tbFuncionario_status default 'Ativo', --ativo ou demitido (ADICIONADO)
data_nasc_func date not null,
tel_func char(10),
cel_func char(11),
email_func varchar(100),
cargo_func varchar(30) not null,
salario_func money not null,
cep_func char(8) not null,
numcasa_func int not null,
constraint FK_tbFuncionario_tbEndereco foreign key(cep_func, numcasa_func) references tbEndereco(cep,numero),
constraint CK_tbFuncionario_salario check(salario_func >= 0.00),
);
GO

create table tbLogin (
cod_login int identity(1,1) constraint PK_tbLogin primary key,
nome_login varchar(25) not null,
senha varchar(20) not null,
data_cadastro datetime not null constraint DF_tbLogin_data default getdate()
);
GO

create table tbUsuario (
cod_usuario int identity(1,1) constraint PK_tbUsuario primary key,
nome_usuario varchar(25) not null,
ativacao_usuario bit not null constraint DF_tbUsuario_ativo default 0,
data_cadastro datetime not null constraint DF_tbUsuario_data default getdate(),
cod_login int not null,
cod_funcionario int not null,
constraint FK_tbUsuario_tbLogin foreign key(cod_login) references tbLogin(cod_login),
constraint FK_tbUsuario_tbFuncionario foreign key(cod_funcionario) references tbFuncionario(cod_funcionario)
);
GO
	
create table tbFerramenta (
cod_ferramenta int identity(1,1) constraint PK_tbFerramenta primary key,
nome_ferra varchar(50) not null,
desc_ferra varchar(200),
marca_ferra varchar(50),
cod_estoque int not null,
cod_fornecedor int not null,
constraint FK_tbFerramenta_tbFornecedor foreign key(cod_fornecedor) references tbFornecedor(cod_fornecedor),
constraint FK_tbFerramenta_tbEstoque foreign key(cod_estoque) references tbEstoque(cod_estoque)
);
GO

create table tbMaquina (
cod_maquina int identity(1,1) constraint PK_tbMaquina primary key,
nome_maq varchar(50) not null,
desc_maq varchar(200),
marca_maq varchar(50),
cod_estoque int not null,
cod_fornecedor int not null,
constraint FK_tbMaquina_tbFornecedor foreign key(cod_fornecedor) references tbFornecedor(cod_fornecedor),
constraint FK_tbMaquina_tbEstoque foreign key(cod_estoque) references tbEstoque(cod_estoque)        
);
GO

create table tbRelatorio (
cod_relatorio int identity(1,1) constraint PK_tbRelatorio primary key,
titulo_rel varchar(50),
data_rel datetime not null default getdate(),
desc_rel varchar(200) not null,
cod_funcionario int not null,
constraint FK_tbRelatorio_tbFuncionario foreign key(cod_funcionario) references tbFuncionario(cod_funcionario)
);
GO

create table tbSemente (
cod_semente int identity(1,1) constraint PK_tbSemente primary key,
nome_sem varchar(50) not null,
tipo_solo_sem varchar(50),
acidez_sem decimal(5,2),
inc_vento_sem decimal(5,2),
inc_solar_sem decimal(5,2),
cod_estoque int not null,
cod_fornecedor int not null,
constraint FK_tbSemente_tbEstoque foreign key(cod_estoque) references tbEstoque(cod_estoque),
constraint FK_tbSemente_tbFornecedor foreign key(cod_fornecedor) references tbFornecedor(cod_fornecedor),
constraint CK_tbSemente_vento check(inc_vento_sem >= 0.00),
constraint CK_tbSemente_solar check(inc_solar_sem >= 0.00)
);
GO

create table tbPraga (
cod_praga int identity(1,1) constraint PK_tbPraga primary key,
nome_praga varchar(70) not null,
desc_praga varchar(200),
cod_semente int not null constraint FK_tbPraga_tbSemente foreign key references tbSemente(cod_semente)
);
GO 

create table tbDoenca (
cod_doenca int identity(1,1) constraint PK_tbDoenca primary key,
nome_doenca varchar(70),
desc_doenca varchar(200),
cod_semente int not null constraint FK_tbDoenca_tbSemente foreign key references tbSemente(cod_semente)
);
GO

create table tbDefensivo (
cod_defensivo int identity(1,1) constraint PK_tbDefensivo primary key,
nome_def varchar(70) not null,
marca_def varchar(50),
desc_def varchar(200),
cod_praga int,
cod_doenca int,
cod_estoque int not null,
cod_fornecedor int,
constraint FK_tbDefensivo_tbPraga foreign key(cod_praga) references tbPraga(cod_praga),
constraint FK_tbDefensivo_tbDoenca foreign key(cod_doenca) references tbDoenca(cod_doenca),
constraint FK_tbDefensivo_tbFornecedor foreign key(cod_fornecedor) references tbFornecedor (cod_fornecedor),
constraint FK_tbDefensivo_tbEstoque foreign key(cod_estoque) references tbEstoque (cod_estoque)
);
GO

create table tbFertilizante(
cod_fertilizante int identity(1,1) constraint PK_tbFertilizante primary key,
nome_fert varchar(70),
marca_fert varchar(50),
desc_fert varchar(200),
cod_estoque int not null,
cod_fornecedor int,
constraint FK_tbFertilizante_tbEstoque foreign key(cod_estoque) references tbEstoque (cod_estoque),
constraint FK_tbFertilizante_tbFornecedor foreign key(cod_fornecedor) references tbFornecedor (cod_fornecedor)
);
GO

create table tbPlantio (
cod_plantio int identity(1,1) constraint PK_tbPlantio primary key,
nome_plantio varchar(25) not null,
data_inicio datetime constraint DF_tbPlantio_datainicio default getdate(),
data_colheita date,
cod_funcionario int not null,
cod_funcionario2 int,
cod_funcionario3 int,
cod_semente int not null,
cod_fertilizante int,
cod_defensivo int,
cod_talhao int not null,
cod_talhao2 int,
cod_talhao3 int,
constraint FK_tbPlantio_tbFuncionario foreign key(cod_funcionario) references tbFuncionario(cod_funcionario),
constraint FK_tbPlantio_tbFuncionario2 foreign key(cod_funcionario2) references tbFuncionario(cod_funcionario),
constraint FK_tbPlantio_tbFuncionario3 foreign key(cod_funcionario3) references tbFuncionario(cod_funcionario),
constraint FK_tbPlantio_tbSemente foreign key(cod_semente) references tbSemente(cod_semente),
constraint FK_tbPlantio_tbFertilizante foreign key(cod_fertilizante) references tbFertilizante(cod_fertilizante),
constraint FK_tbPlantio_tbDefensivo foreign key(cod_defensivo) references tbDefensivo(cod_defensivo),
constraint FK_tbPlantio_tbTalhao foreign key(cod_talhao) references tbTalhao(cod_talhao),
constraint FK_tbPlantio_tbTalhao2 foreign key(cod_talhao2) references tbTalhao(cod_talhao),
constraint FK_tbPlantio_tbTalhao3 foreign key(cod_talhao3) references tbTalhao(cod_talhao),
);
GO

create table tbColheita (
cod_plantio int,
data_colheita datetime constraint DF_tbColheita_data default getdate(),
qtd_colheita int,
cod_estoque int,
constraint PK_tbColheita primary key clustered(cod_plantio,data_colheita),
constraint FK_tbColheita_tbPlantio foreign key(cod_plantio) references tbPlantio(cod_plantio),
constraint FK_tbColheita_tbEstoque foreign key(cod_estoque) references tbEstoque(cod_estoque),
constraint CK_tbColheita_qtd check(qtd_colheita > 0)
);
GO  


create trigger trg_insert_estoque on tbEstoque 
after insert as
begin
 declare @qtd_estoque int = (select qtd_estoque from inserted);
		if(@qtd_estoque>=0)
		begin
		declare @desc_hist varchar(50) = 'Item adicionado',
				@cod_estoque int = (select cod_estoque from inserted),
				@unidade_medida char(3) = (select unidade_medida from inserted);
		
		insert into tbHistorico_Estoque(cod_estoque, qtd_alt, desc_hist, unidade_medida) 
				values(@cod_estoque, @qtd_estoque, @desc_hist, @unidade_medida);

		end
		else
		print('Impossível inserir um valor menor que zero, por favor insira novamente com outro valor.')
end
GO

create trigger trg_update_estoque on tbEstoque
for update as 
begin
	declare @cod_estoque int = (select cod_estoque from inserted),
			@qtd_estoque int = (select qtd_estoque from inserted),
			@unidade_medida char(3) = (select unidade_medida from inserted);
	if(exists(select cod_estoque from tbEstoque where cod_estoque = @cod_estoque ))
	begin
		if(@qtd_estoque >= 0)
		begin
		declare @qtd_alterada int = (select qtd_estoque from deleted where cod_estoque = @cod_estoque) - @qtd_estoque,
				@qtd_antiga int = (select qtd_estoque from deleted where cod_estoque = @cod_estoque);
		insert into tbHistorico_Estoque(cod_estoque, qtd_alt, qtd_antiga, unidade_medida) 
				values(@cod_estoque, -@qtd_alterada, @qtd_antiga, @unidade_medida);
		end
		else
		print('Impossivel realizar esta operaçao, tente novamente com um valor maior que zero!');
	end
end
GO

create trigger trg_delete_estoque on tbEstoque 
instead of delete as
begin 
 declare @cod_estoque int = (select cod_estoque from deleted);
	if(exists(select cod_estoque from tbEstoque where cod_estoque = @cod_estoque ))
	begin

		alter table tbHistorico_Estoque nocheck constraint FK_tbHistorico_tbEstoque; 
		delete from tbEstoque where cod_estoque = @cod_estoque;
		declare @qtd_alterada int = (select qtd_estoque from deleted where cod_estoque = @cod_estoque), 
				@descricao_hist varchar(25) = 'Item deletado',
				@qtd_antiga int = (select qtd_estoque from deleted where cod_estoque = @cod_estoque),
				@unidade_medida char(3) = (select unidade_medida from deleted where cod_estoque = @cod_estoque);

		insert into tbHistorico_Estoque(cod_estoque, qtd_alt, desc_hist, qtd_antiga, unidade_medida) 
		        values(@cod_estoque, -@qtd_alterada, @descricao_hist, @qtd_antiga, @unidade_medida);

	end
	else
	print('Impossivel realizar esta operaçao, pois o codigo '+convert(varchar(20), @cod_estoque)+' nao existe na tabela tbEstoque, tente novamente com um codigo valido!');;
end
GO

create proc sp_insert_ferramenta(

	@nome_ferra varchar(50),
	@desc_ferra varchar(200),
	@marca_ferra varchar(50),
	@cod_fornecedor int, 
	@qtd_estoque int,
	@unidade_medida char(3)
) as 
  begin
	if(@qtd_estoque>=0)
		begin
			insert into tbEstoque(qtd_estoque, unidade_medida) values(@qtd_estoque, @unidade_medida);
			declare @cod_estoque int = (select top 1 cod_estoque from tbEstoque order by cod_estoque desc);	

			if(@desc_ferra = '')set @desc_ferra = 'Sem descriçao';	
			if(@marca_ferra = '')set @marca_ferra = 'Marca nao registrada';

			insert into tbFerramenta (nome_ferra, desc_ferra, marca_ferra, cod_estoque, cod_fornecedor)
						 values(@nome_ferra, @desc_ferra, @marca_ferra, @cod_estoque, @cod_fornecedor);
		end
		else
		print('Impossivel inserir um valor menor que zero, por favor insira novamente com outro valor.')
 end
 
 
 GO

create proc sp_delete_ferramenta(
@cod_ferramenta int
)as
begin
    delete from tbFerramenta where cod_ferramenta = @cod_ferramenta;
end
GO

create trigger trg_delete_ferramenta on tbFerramenta
for delete 
as begin
delete from tbEstoque where cod_estoque = (select cod_estoque from deleted);
end
GO

create proc sp_insert_maquina(
	@nome_maq varchar(50),
	@desc_maq varchar(200),
	@marca_maq varchar(50),
	@cod_fornecedor int,
	@qtd_estoque int,
	@unidade_medida char(3)
)as 
 begin
	if(@qtd_estoque >= 0)
	begin
		insert into tbEstoque(qtd_estoque, unidade_medida) values(@qtd_estoque, @unidade_medida);
		declare @cod_estoque int = (select top 1 cod_estoque from tbEstoque order by cod_estoque desc);

		if(@desc_maq = '')set @desc_maq = 'Sem descriçao';	
		if(@marca_maq = '')set @marca_maq = 'Marca nao registrada';

		insert into tbMaquina (nome_maq, desc_maq, marca_maq, cod_estoque, cod_fornecedor)
				values(@nome_maq, @desc_maq, @marca_maq, @cod_estoque, @cod_fornecedor);
	end
	else
	print('Impossivel inserir um valor menor que zero, por favor insira novamente com outro valor.');
 end
 GO

 create proc sp_delete_maquina
@cod_maquina int
as
begin
    delete from tbMaquina where cod_maquina = @cod_maquina;
end
GO

create trigger trg_delete_maquina on tbMaquina
for delete 
as begin
delete from tbEstoque where cod_estoque = (select cod_estoque from deleted);
end
GO

create proc sp_insert_defensivo(
	@nome_def varchar(50),
	@desc_def varchar(200),
	@marca_def varchar(50),
	@cod_doenca int = null,
	@cod_praga int = null,
	@cod_fornecedor int = null,
	@qtd_estoque int,
	@unidade_medida char(3)
)as 
 begin
	if(@qtd_estoque >= 0)
	begin
		insert into tbEstoque(qtd_estoque, unidade_medida) values(@qtd_estoque, @unidade_medida);
		declare @cod_estoque int = (select top 1 cod_estoque from tbEstoque order by cod_estoque desc);

		if(@desc_def = '')set @desc_def = 'Sem descriçao';	
		if(@marca_def = '')set @marca_def = 'Marca nao registrada';

		insert into tbDefensivo (nome_def, desc_def, marca_def, cod_estoque, cod_doenca, cod_praga, cod_fornecedor)
				values(@nome_def, @desc_def, @marca_def, @cod_estoque, @cod_doenca, @cod_praga, @cod_fornecedor);
	end
	else
	print('Impossivel inserir um valor menor que zero, por favor insira novamente com outro valor.');
 end
 GO

create trigger trg_delete_defensivo on tbDefensivo
for delete 
as begin
delete from tbEstoque where cod_estoque = (select cod_estoque from deleted);
end
GO

 create proc sp_delete_defensivo
@cod_defensivo int
as
begin
    delete from tbDefensivo where cod_defensivo = @cod_defensivo
end
GO

create proc sp_insert_semente(
	@nome_sem varchar(50),
	@tipo_solo_sem varchar(50),
	@acidez_sem decimal(5,2),
	@inc_vento_sem decimal(5,2),
	@inc_solar_sem decimal(5,2),
	@cod_fornecedor int,
	@qtd_estoque int,
	@unidade_medida char(3)
)as 
 begin
	if(@qtd_estoque >= 0)
	begin
		insert into tbEstoque(qtd_estoque, unidade_medida) values(@qtd_estoque, @unidade_medida);
		declare @cod_estoque int = (select top 1 cod_estoque from tbEstoque order by cod_estoque desc);

		if(@tipo_solo_sem = '')set @tipo_solo_sem = 'Solo nao especificado';	

		insert into tbSemente(nome_sem, tipo_solo_sem, acidez_sem, inc_vento_sem, inc_solar_sem, cod_estoque, cod_fornecedor)
					values(@nome_sem, @tipo_solo_sem, @acidez_sem, @inc_vento_sem, @inc_solar_sem, @cod_estoque, @cod_fornecedor);
	end
	else
	print('Impossivel inserir um valor menor que zero, por favor insira novamente com outro valor.');
 end
GO

create proc sp_delete_semente
@cod_semente int
as
begin
    delete from tbSemente where cod_semente = @cod_semente;
end
GO

create trigger trg_delete_semente on tbSemente
for delete 
as begin
delete from tbEstoque where cod_estoque = (select cod_estoque from deleted);
delete from tbPraga where cod_semente = (select cod_semente from deleted);
delete from tbDoenca where cod_semente = (select cod_semente from deleted);
end
GO

create proc sp_insert_fertilizante(
	@nome_fert varchar(50),
	@desc_fert varchar(200),
	@marca_fert varchar(50),
	@cod_fornecedor int, 
	@qtd_estoque int, 
	@unidade_medida char(3)
)as 
 begin
	insert into tbEstoque(qtd_estoque, unidade_medida) values(@qtd_estoque, @unidade_medida);
	declare @cod_estoque int = (select top 1 cod_estoque from tbEstoque order by cod_estoque desc);

	if(@marca_fert = '')set @marca_fert='Marca nao especificada';
	if(@desc_fert = '')set @desc_fert='Sem descriçao';

	insert into tbFertilizante (nome_fert, desc_fert, marca_fert, cod_estoque, cod_fornecedor)
			values(@nome_fert, @desc_fert, @marca_fert, @cod_estoque, @cod_fornecedor);
 end
 GO
 
 create proc sp_delete_fertilizante
@cod_fertilizante int
as
begin
    delete from tbFertilizante where cod_fertilizante = @cod_fertilizante;
end
GO

create trigger trg_delete_fertilizante on tbFertilizante
for delete 
as begin
delete from tbEstoque where cod_estoque = (select cod_estoque from deleted);
end
GO

create procedure sp_insert_colheita(
	@cod_plantio int,
	@qtd_colheita int,
	@unidade_medida char(3),
	@data_colheita date
)as 
 begin

	declare @cod_estoque int ;
	update tbPlantio set data_colheita = @data_colheita;
		if(exists(select * from tbColheita where cod_plantio = @cod_plantio))
		begin
			set @cod_estoque = (select cod_estoque from tbColheita where cod_plantio = @cod_plantio);
			declare @qtd_antiga int = (select qtd_estoque from  tbEstoque where cod_estoque = @cod_estoque);
		
			update tbEstoque set qtd_estoque = (@qtd_antiga + @qtd_colheita) where cod_estoque = @cod_estoque;
		end
		else
		begin
			insert into tbEstoque(qtd_estoque, unidade_medida) values(@qtd_colheita, @unidade_medida);
			set @cod_estoque = (select top 1 cod_estoque from tbEstoque order by cod_estoque desc);
		
			insert into tbColheita (cod_plantio, qtd_colheita, cod_estoque)
					values(@cod_plantio, @qtd_colheita, @cod_estoque);
		end	
	end
GO

create proc sp_finalizar_colheita(
 @cod_plantio int,
 @qtd_colheita int,
 @unidade_medida char(3)
)as
 begin
	declare @cod_estoque int;
		if(exists(select * from tbColheita where cod_plantio = @cod_plantio))
		begin
			set @cod_estoque = (select cod_estoque from tbColheita where cod_plantio = @cod_plantio);
			declare @qtd_antiga int = (select qtd_estoque from  tbEstoque where cod_estoque = @cod_estoque);
		
			update tbEstoque set qtd_estoque = (@qtd_antiga + @qtd_colheita) where cod_estoque = @cod_estoque;

			alter table tbColheita nocheck constraint FK_tbColheita_tbPlantio;
			delete from tbPlantio where cod_plantio = @cod_plantio;

		end
		else
		begin
			insert into tbEstoque(qtd_estoque, unidade_medida) values(@qtd_colheita, @unidade_medida);
			set @cod_estoque = (select top 1 cod_estoque from tbEstoque order by cod_estoque desc);
		
			insert into tbColheita (cod_plantio, qtd_colheita, cod_estoque)
					values(@cod_plantio, @qtd_colheita, @cod_estoque);

			alter table tbColheita nocheck constraint FK_tbColheita_tbPlantio;
			delete from tbPlantio where cod_plantio = @cod_plantio;
		end	
	end
GO

create proc sp_delete_colheita
@cod_plantio int
as
begin
    delete from tbColheita where cod_plantio = @cod_plantio;
end
GO

create trigger trg_delete_colheita on tbColheita
for delete 
as begin
delete from tbEstoque where cod_estoque = (select cod_estoque from deleted);
end
GO

create proc sp_insert_plantio(
 @nome_plantio varchar(25),
 @data_colheita date,
 @cod_funcionario int,
 @cod_funcionario2 int = null,
 @cod_funcionario3 int = null,
 @cod_semente int,
 @qtd_semente int,
 @cod_fertilizante int = null,
 @qtd_fertilizante int = null,
 @cod_defensivo int = null,
 @qtd_defensivo int = null,
 @cod_talhao int,
 @cod_talhao2 int = null,
 @cod_talhao3 int = null
)as
begin
declare
@cod_est_fert int,
@qtd_est_fert int,
@cod_est_def int,
@qtd_est_def int;

	insert into tbPlantio(nome_plantio, data_colheita, cod_funcionario, cod_funcionario2, cod_funcionario3, cod_semente, cod_fertilizante, cod_defensivo, cod_talhao, cod_talhao2, cod_talhao3)
	values (@nome_plantio, @data_colheita, @cod_funcionario, @cod_funcionario2, @cod_funcionario3, @cod_semente, @cod_fertilizante, @cod_defensivo, @cod_talhao, @cod_talhao2, @cod_talhao3);

	declare @cod_est_sem int = (select cod_estoque from tbSemente where cod_semente = @cod_semente);
	declare @qtd_est_sem int = (select qtd_estoque from tbEstoque where cod_estoque = @cod_est_sem);
	
	update tbEstoque set qtd_estoque = (@qtd_est_sem - @qtd_semente) where cod_estoque = @cod_est_sem;

	if(@cod_fertilizante != null)
	begin
			set @cod_est_fert = (select cod_estoque from tbFertilizante where cod_fertilizante = @cod_fertilizante);
			set @qtd_est_fert = (select qtd_estoque from tbEstoque where cod_estoque = @cod_est_fert);
			update tbEstoque set qtd_estoque = (@qtd_est_fert - @qtd_fertilizante) where cod_estoque = @cod_est_fert;
	end;

	if(@cod_defensivo != null)
	begin
			set @cod_est_def = (select cod_estoque from tbDefensivo where cod_defensivo = @cod_defensivo);
			set @qtd_est_def = (select qtd_estoque from tbEstoque where cod_estoque = @cod_est_def);
			update tbEstoque set qtd_estoque = (@qtd_est_def - @qtd_defensivo) where cod_estoque = @cod_est_def;
	end
end
GO

create trigger trg_talhaoD_plantio on tbPlantio
for insert as
begin
	update tbTalhao set disponivel_tal = 'Indisponivel' where cod_talhao = (select cod_talhao from inserted);
	if((select cod_talhao2 from inserted) is not null)
	begin
	update tbTalhao set disponivel_tal = 'Indisponivel' where cod_talhao = (select cod_talhao2 from inserted);
	end
	if((select cod_talhao3 from inserted) is not null)
	begin
	update tbTalhao set disponivel_tal = 'Indisponivel' where cod_talhao = (select cod_talhao3 from inserted);
	end
end
GO

create trigger trg_talhaoNP_plantio on tbPlantio
for delete as 
begin
	update tbTalhao set disponivel_tal = 'Disponivel' where cod_talhao = (select cod_talhao from deleted);
	if((select cod_talhao2 from deleted) is not null)
	begin
	update tbTalhao set disponivel_tal = 'Disponivel' where cod_talhao = (select cod_talhao2 from deleted);
	end
	if((select cod_talhao3 from deleted) is not null)
	begin
	update tbTalhao set disponivel_tal = 'Disponivel' where cod_talhao = (select cod_talhao3 from deleted);
	end
end
GO

create proc sp_insert_fornecedor(
 @cep char(8),
 @numero int,
 @rua varchar(50),
 @bairro varchar(50),
 @complemento varchar(20),--DEFAULT
 @cidade varchar(50),	
 @uf char(2),
 @nome_fantasia varchar(50),
 @cnpj_forn char(15),
 @razao_social varchar(50), --DEFAULT
 @tel_forn char(11),
 @email_forn varchar(100), --DEFAULT
 @site_forn varchar(200)--DEFAULT
)as
begin
	if(@complemento = '')set @complemento = 'Sem complemento';
	if(@razao_social = '')set @razao_social = 'Razao social nao registrada';
	if(@email_forn = '')set @email_forn = 'Email nao registrado';
	if(@site_Forn = '')set @site_forn = 'Site nao registrado';

	insert into tbEndereco (cep, numero, rua, bairro, complemento, cidade, uf)
			values (@cep, @numero, @rua, @bairro, @complemento, @cidade, @uf);
	insert into tbFornecedor (nome_fantasia, cnpj_forn, razao_social, tel_forn, email_forn, site_forn, cep_forn, num_forn)
			values (@nome_fantasia, @cnpj_forn, @razao_social, @tel_forn, @email_forn, @site_forn, @cep, @numero);
end
GO 

create proc sp_delete_fornecedor
@cod_fornecedor int
as
begin
    update tbFornecedor set status_forn = 'Inativo' where cod_fornecedor = @cod_fornecedor;
end
GO

create procedure sp_insert_funcionario(
 @cep char(8),
 @numero int,
 @rua varchar(50),
 @bairro varchar(50),
 @complemento varchar(20),--DEFAULT
 @cidade varchar(50),	
 @uf char(2),
 @nome_func varchar(50),
 @cpf_func char(11),
 @rg_func char(9), --DEFAULT
 @data_nasc date,
 @tel_func char(10),
 @cel_func char(11), --DEFAULT
 @email_func varchar(100),
 @cargo_func varchar(30),
 @salario_func money
)as
begin
	if(@tel_func = '') set @tel_func = null;
	if(@cel_func = '') set @cel_func = null;
	if(@complemento = '')set @complemento = 'Sem complemento';
	if(@email_func = '')set @email_func = 'Email nao registrado';

		insert into tbEndereco (cep, numero, rua, bairro, complemento, cidade, uf)
				values (@cep, @numero, @rua, @bairro, @complemento, @cidade, @uf);
		insert into tbFuncionario(nome_func, cpf_func, rg_func, data_nasc_func, tel_func, email_func, cargo_func, salario_func, cel_func, cep_func, numcasa_func)
				values (@nome_func, @cpf_func, @rg_func, @data_nasc, @tel_func, @email_func, @cargo_func, @salario_func,@cel_func, @cep, @numero);

end
GO

create proc sp_delete_funcionario
@cod_funcionario int
as
begin
    update tbFuncionario set status_func = 'Demitido' where @cod_funcionario = @cod_funcionario;
	delete from tbUsuario where cod_funcionario = @cod_funcionario;
end
GO

create proc sp_insert_login(
 @nome_login varchar(25),
 @senha varchar(20)
)as
begin
	insert into tbLogin(nome_login, senha)values(@nome_login, @senha);
end
GO

create proc sp_update_senha @cod_login int, @senha varchar(20) as 
begin
update tbLogin set senha = @senha where cod_login = @cod_login;
end
GO

create proc sp_insert_usuario(
 @nome_usuario varchar(25),
 @cod_login int, 
 @cod_funcionario int
)as
begin
	insert into tbUsuario(nome_usuario, cod_login, cod_funcionario) values(@nome_usuario, @cod_login, @cod_funcionario);
end
GO

create proc sp_insert_praga(
 @nome_praga varchar(70),
 @cod_semente int,
 @desc_praga varchar(200)
)as
begin
	if(@desc_praga = '')set @desc_praga = 'Sem descriçao';
	insert into tbPraga(nome_praga, desc_praga, cod_semente)values(@nome_praga, @desc_praga, @cod_semente);
end
GO

create proc sp_delete_praga(
 @cod_praga int
)as
begin
	delete from tbPraga where cod_praga = @cod_praga;
end
GO

create proc sp_insert_doenca(
 @nome_doenca varchar(70),
 @desc_doenca varchar(200),
 @cod_semente int
)as
begin
	if(@desc_doenca = '')set @desc_doenca = 'Sem descriçao';
	insert into tbDoenca(nome_doenca, desc_doenca, cod_semente)values(@nome_doenca, @desc_doenca, @cod_semente);
end
GO

create proc sp_delete_doenca(
 @cod_doenca int
)as
begin
	delete from tbDoenca where cod_doenca = @cod_doenca;
end
GO

create proc sp_insert_relatorio(
 @titulo_rel varchar(50),
 @desc_rel varchar(200),
 @cod_funcionario int
)as
begin
	insert into tbRelatorio(titulo_rel, desc_rel, cod_funcionario) values(@titulo_rel, @desc_rel, @cod_funcionario);
end
GO

create proc sp_delete_relatorio(
 @cod_relatorio int
)as
begin
	delete from tbRelatorio where cod_relatorio = @cod_relatorio;
end
GO

create proc sp_update_estoque(
 @cod_estoque int,
 @qtd_estoque int, 
 @unidade_medida char(3)
)as
begin
	update tbEstoque 
	set qtd_estoque = @qtd_estoque, unidade_medida = @unidade_medida
	where cod_estoque = @cod_estoque;
end
GO

create proc sp_update_talhao(
 @cod_talhao int,
 @nome_tal varchar(50), 
 @tam_tal int,
 @tipo_solo_tal varchar(25),
 @inc_solar_tal decimal(5,2),
 @inc_vento_tal decimal(5,2),
 @acidez_tal decimal(5,2)
)as
begin
	update tbTalhao
	set nome_tal = @nome_tal, tam_tal = @tam_tal, tipo_solo_tal = @tipo_solo_tal, inc_solar_tal = @inc_solar_tal, inc_vento_tal = @inc_vento_tal,
	 acidez_tal = @acidez_tal
	where cod_talhao = @cod_talhao;
end
GO

CREATE PROC SP_SELECT_PLANTIO
AS
BEGIN											  
SELECT P.cod_plantio AS [Codigo], P.nome_plantio AS [Nome], S.nome_sem AS [Semente], P.data_inicio AS [Data inicio], P.data_colheita AS [Data colheita], 
			F1.nome_func AS [Funcionario 1], F2.nome_func AS [Funcionario 2], F3.nome_func AS [Funcionario 3], F.nome_fert AS [Fertilizante], D.nome_def AS [Defensivo], 
			T1.nome_tal AS [Talhao 1], T2.nome_tal AS [Talhao 2], T3.nome_tal AS [Talhao 3]
			FROM tbPlantio P
			INNER JOIN tbSemente S ON P.cod_semente = S.cod_semente
			INNER JOIN tbFuncionario F1 ON P.cod_funcionario = F1.cod_funcionario
			LEFT JOIN tbFuncionario F2 ON P.cod_funcionario2 = F2.cod_funcionario
			LEFT JOIN tbFuncionario F3 ON P.cod_funcionario3 = F3.cod_funcionario
			LEFT JOIN tbFertilizante F ON P.cod_fertilizante = F.cod_fertilizante
			LEFT JOIN tbDefensivo D ON P.cod_defensivo = D.cod_defensivo
			INNER JOIN tbTalhao T1 ON P.cod_talhao = T1.cod_talhao
			LEFT JOIN tbTalhao T2 ON P.cod_talhao2 = T2.cod_talhao
			LEFT JOIN tbTalhao T3 ON P.cod_talhao3 = T3.cod_talhao
END
GO

CREATE PROC SP_SELECT_COLHEITA
AS
BEGIN
			SELECT C.cod_plantio AS [Codigo], C.data_colheita AS [Data colheita], C.qtd_colheita AS [Quantidade colhida], P.nome_plantio AS [Nome], S.nome_sem AS [Semente], 
			P.data_inicio AS [Data inicio], F1.nome_func AS [Funcionario 1], F2.nome_func AS [Funcionario 2], F3.nome_func AS [Funcionario 3], 
			F.nome_fert AS [Fertilizante], D.nome_def AS [Defensivo], T1.nome_tal AS [Talhao 1], T2.nome_tal AS [Talhao 2], T3.nome_tal AS [Talhao 3]
			FROM tbColheita C
			LEFT JOIN tbPlantio P ON C.cod_plantio = P.cod_plantio
			LEFT JOIN tbSemente S ON P.cod_semente = S.cod_semente	
			LEFT JOIN tbFuncionario F1 ON P.cod_funcionario = F1.cod_funcionario
			LEFT JOIN tbFuncionario F2 ON P.cod_funcionario2 = F2.cod_funcionario
			LEFT JOIN tbFuncionario F3 ON P.cod_funcionario3 = F3.cod_funcionario
			LEFT JOIN tbFertilizante F ON P.cod_fertilizante = F.cod_fertilizante
			LEFT JOIN tbDefensivo D ON P.cod_defensivo = D.cod_defensivo
			LEFT JOIN tbTalhao T1 ON P.cod_talhao = T1.cod_talhao
			LEFT JOIN tbTalhao T2 ON P.cod_talhao2 = T2.cod_talhao
			LEFT JOIN tbTalhao T3 ON P.cod_talhao3 = T3.cod_talhao
END
GO

CREATE PROC SP_SELECT_ESTOQUE
AS
BEGIN
SELECT E.cod_estoque AS [Codigo], S.nome_sem AS [Item], E.qtd_estoque AS [Quantidade], E.unidade_medida as [Unidade de medida]
FROM tbEstoque E
INNER JOIN tbSemente S ON E.cod_estoque = S.cod_estoque
UNION
SELECT E.cod_estoque AS [Codigo],M.nome_maq, E.qtd_estoque, E.unidade_medida as [Unidade de medida]
FROM tbEstoque E
INNER JOIN tbMaquina M ON E.cod_estoque = M.cod_estoque
UNION
SELECT E.cod_estoque AS [Codigo],F.nome_ferra, E.qtd_estoque, E.unidade_medida as [Unidade de medida]
FROM tbEstoque E
INNER JOIN tbFerramenta F ON E.cod_estoque = F.cod_estoque
UNION
SELECT E.cod_estoque AS [Codigo],D.nome_def, E.qtd_estoque, E.unidade_medida as [Unidade de medida]
FROM tbEstoque E
INNER JOIN tbDefensivo D ON E.cod_estoque = D.cod_estoque
UNION
SELECT E.cod_estoque AS [Codigo],FE.nome_fert, E.qtd_estoque, E.unidade_medida as [Unidade de medida]
FROM tbEstoque E
INNER JOIN tbFertilizante FE ON E.cod_estoque = FE.cod_estoque
UNION
SELECT E.cod_estoque AS [Codigo],P.nome_plantio, E.qtd_estoque, E.unidade_medida as [Unidade de medida]
FROM tbEstoque E
INNER JOIN tbColheita C ON E.cod_estoque = C.cod_estoque
INNER JOIN tbPlantio P ON C.cod_plantio = P.cod_plantio
END
GO

create proc sp_select_historico
as begin
select nome_sem [Item], H.qtd_antiga[Quantidade Antiga], H.qtd_alt [Quantidade Alterada], E.qtd_estoque [Quantidade Atual],
E.unidade_medida [Unidade de medida], H.data_alteracao
from tbSemente S
inner join tbEstoque E on E.cod_estoque = S.cod_estoque
inner join tbHistorico_Estoque H on H.cod_estoque = E.cod_estoque
union
select nome_maq [Item], qtd_antiga[Quantidade Antiga], qtd_alt [Quantidade Alterada], qtd_estoque [Quantidade Atual],
E.unidade_medida [Unidade de medida], data_alteracao
from tbMaquina M
inner join tbEstoque E on E.cod_estoque = M.cod_estoque
inner join tbHistorico_Estoque H on H.cod_estoque = E.cod_estoque
union
select nome_ferra [Item], qtd_antiga[Quantidade Antiga], qtd_alt [Quantidade Alterada], qtd_estoque [Quantidade Atual],
E.unidade_medida [Unidade de medida], data_alteracao
from tbFerramenta F
inner join tbEstoque E on E.cod_estoque = F.cod_estoque
inner join tbHistorico_Estoque H on H.cod_estoque = E.cod_estoque
union
select nome_def [Item], qtd_antiga[Quantidade Antiga], qtd_alt [Quantidade Alterada], qtd_estoque [Quantidade Atual],
E.unidade_medida [Unidade de medida], data_alteracao
from tbDefensivo D
inner join tbEstoque E on E.cod_estoque = D.cod_estoque
inner join tbHistorico_Estoque H on H.cod_estoque = E.cod_estoque
union
select nome_ferra [Item], qtd_antiga[Quantidade Antiga], qtd_alt [Quantidade Alterada], qtd_estoque [Quantidade Atual],
E.unidade_medida [Unidade de medida], data_alteracao
from tbFerramenta FE
inner join tbEstoque E on E.cod_estoque = FE.cod_estoque
inner join tbHistorico_Estoque H on H.cod_estoque = E.cod_estoque
union
select nome_plantio [Item], qtd_antiga[Quantidade Antiga], qtd_alt [Quantidade Alterada], qtd_estoque [Quantidade Atual],
E.unidade_medida [Unidade de medida], data_alteracao
from tbPlantio P
inner join tbColheita C on C.cod_plantio = P.cod_plantio
inner JOIN tbEstoque E on E.cod_estoque = C.cod_estoque
inner join tbHistorico_Estoque H on H.cod_estoque = E.cod_estoque
end 
GO


exec sp_insert_funcionario 055451, 561, 'Rua', 'Bairro', 'Complemento', 'City', 'AM', 'Rogeirinho', 123123123, 1312312, '19991023', 123123, 1212312, 'email', 'trabalhador', '1230';
GO
exec sp_insert_login 'usuario', 'senha';
GO
exec sp_insert_usuario 'Mayro', 1, 1;
GO

insert into tbTalhao(nome_tal, disponivel_tal, tam_tal, tipo_solo_tal) values
('Talhao 1', 'Disponivel', 15, 'Argiloso'),
('Talhao 2', 'Disponivel', 15, 'Argiloso'),
('Talhao 3', 'Disponivel', 15, 'Argiloso'),
('Talhao 4', 'Disponivel', 15, 'Argiloso'),
('Talhao 5', 'Disponivel', 15, 'Argiloso'),
('Talhao 6', 'Disponivel', 15, 'Argiloso'),
('Talhao 7', 'Disponivel', 15, 'Argiloso'),
('Talhao 8', 'Disponivel', 15, 'Argiloso'),
('Talhao 9', 'Disponivel', 15, 'Argiloso'),
('Talhao 10', 'Disponivel', 15, 'Argiloso'),
('Talhao 11', 'Disponivel', 15, 'Argiloso');
go