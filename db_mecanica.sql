-- MySQL dump 10.13  Distrib 8.0.38, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: db_mecanica
-- ------------------------------------------------------
-- Server version	5.5.5-10.4.32-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `tbl_cliente`
--

DROP TABLE IF EXISTS `tbl_cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_cliente` (
  `id_cliente` int(11) NOT NULL AUTO_INCREMENT,
  `nome_cliente` varchar(100) NOT NULL,
  `tipo_cliente` varchar(20) NOT NULL,
  `cpf_cnpj_cliente` varchar(18) NOT NULL,
  `data_nasc_cliente` date NOT NULL,
  `email_cliente` varchar(100) NOT NULL,
  `senha_cliente` varchar(20) NOT NULL,
  `telefone_cliente` varchar(14) NOT NULL,
  `endereco_cliente` varchar(100) NOT NULL,
  `bairro_cliente` varchar(30) NOT NULL,
  `cidade_cliente` varchar(30) NOT NULL,
  `id_uf` int(11) NOT NULL,
  `id_status` int(11) NOT NULL,
  PRIMARY KEY (`id_cliente`),
  UNIQUE KEY `cpf_cnpj_cliente` (`cpf_cnpj_cliente`),
  UNIQUE KEY `email_cliente` (`email_cliente`),
  KEY `fk_cliente_status` (`id_status`),
  KEY `fk_cliente_uf` (`id_uf`),
  CONSTRAINT `fk_cliente_status` FOREIGN KEY (`id_status`) REFERENCES `tbl_status` (`id_status`),
  CONSTRAINT `fk_cliente_uf` FOREIGN KEY (`id_uf`) REFERENCES `tbl_uf` (`id_uf`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_cliente`
--

LOCK TABLES `tbl_cliente` WRITE;
/*!40000 ALTER TABLE `tbl_cliente` DISABLE KEYS */;
INSERT INTO `tbl_cliente` VALUES (1,'João Silva','Pessoa Física','123.456.789-00','1990-01-15','joao.silva@email.com','senha123','(11)98765-4321','Rua A, 123','Centro','São Paulo',25,1),(2,'Maria Oliveira','Pessoa Física','234.567.890-11','1985-05-20','maria.oliveira@email.com','senha456','(21)97654-3210','Rua B, 456','Jardim','Rio de Janeiro',19,1),(3,'Pedro Santos','Pessoa Física','345.678.901-22','1982-08-30','pedro.santos@email.com','senha789','(31)96543-2109','Rua C, 789','Bairro Alto','Belo Horizonte',13,1),(4,'Ana Costa','Pessoa Física','456.789.012-33','1995-12-10','ana.costa@email.com','senha012','(41)95432-1098','Rua D, 101','Centro','Curitiba',16,1),(5,'Lucas Almeida','Pessoa Física','567.890.123-44','1992-02-22','lucas.almeida@email.com','senha345','(51)94321-0987','Rua E, 202','Jardim','Porto Alegre',21,1),(6,'Fernanda Lima','Pessoa Física','678.901.234-55','1994-07-07','fernanda.lima@email.com','senha678','(61)93210-9876','Rua F, 303','Bairro Novo','Brasília',7,1),(7,'Carlos Pereira','Pessoa Jurídica','12.345.678/0001-99','2000-03-15','carlos.pereira@email.com','senha901','(71)91234-5678','Avenida G, 404','Centro','Salvador',5,1),(8,'Sofia Mendes','Pessoa Física','789.012.345-66','1988-11-11','sofia.mendes@email.com','senha234','(81)92123-4567','Rua H, 505','Jardim','Recife',17,1),(9,'Ricardo Rocha','Pessoa Jurídica','98.765.432/0001-88','1993-09-09','ricardo.rocha@email.com','senha567','(91)93213-4567','Rua I, 606','Centro','Belém',14,1),(10,'Juliana Martins','Pessoa Física','456.123.789-11','1991-06-30','juliana.martins@email.com','senha890','(41)91234-5678','Rua J, 707','Bairro Novo','Fortaleza',6,1);
/*!40000 ALTER TABLE `tbl_cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_especialidade`
--

DROP TABLE IF EXISTS `tbl_especialidade`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_especialidade` (
  `id_especialidade` int(11) NOT NULL AUTO_INCREMENT,
  `nome_especialidade` varchar(30) NOT NULL,
  PRIMARY KEY (`id_especialidade`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_especialidade`
--

LOCK TABLES `tbl_especialidade` WRITE;
/*!40000 ALTER TABLE `tbl_especialidade` DISABLE KEYS */;
INSERT INTO `tbl_especialidade` VALUES (1,'Mecânica de Automóveis'),(2,'Eletricidade Automotiva'),(3,'Suspensão e Direção'),(4,'Transmissão'),(5,'Motor'),(6,'Freios'),(7,'Arrefecimento'),(8,'Injeção Eletrônica'),(9,'Alinhamento e Balanceamento'),(10,'Pintura e Funilaria'),(11,'Diagnóstico e Análise'),(12,'Sistemas de Escape'),(13,'Manutenção Preventiva');
/*!40000 ALTER TABLE `tbl_especialidade` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_fornecedor`
--

DROP TABLE IF EXISTS `tbl_fornecedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_fornecedor` (
  `id_fornecedor` int(11) NOT NULL AUTO_INCREMENT,
  `nome_fornecedor` varchar(100) NOT NULL,
  `tipo_fornecedor` varchar(20) NOT NULL,
  `cpf_cnpj_fornecedor` varchar(18) NOT NULL,
  `data_cad_fornecedor` date NOT NULL,
  `email_fornecedor` varchar(100) NOT NULL,
  `site_fornecedor` varchar(100) NOT NULL,
  `telefone_fornecedor` varchar(15) NOT NULL,
  `endereco_fornecedor` varchar(100) NOT NULL,
  `bairro_fornecedor` varchar(30) NOT NULL,
  `cidade_fornecedor` varchar(30) NOT NULL,
  `id_uf` int(11) NOT NULL,
  `id_status` int(11) NOT NULL,
  PRIMARY KEY (`id_fornecedor`),
  UNIQUE KEY `cpf_cnpj_fornecedor` (`cpf_cnpj_fornecedor`),
  UNIQUE KEY `email_fornecedor` (`email_fornecedor`),
  KEY `fk_fornecedor_status` (`id_status`),
  KEY `fk_fornecedor_uf` (`id_uf`),
  CONSTRAINT `fk_fornecedor_status` FOREIGN KEY (`id_status`) REFERENCES `tbl_status` (`id_status`),
  CONSTRAINT `fk_fornecedor_uf` FOREIGN KEY (`id_uf`) REFERENCES `tbl_uf` (`id_uf`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_fornecedor`
--

LOCK TABLES `tbl_fornecedor` WRITE;
/*!40000 ALTER TABLE `tbl_fornecedor` DISABLE KEYS */;
INSERT INTO `tbl_fornecedor` VALUES (1,'Peças Auto Ltda','Pessoa Jurídica','12.345.678/0001-99','2023-01-15','contato@pecasauto.com.br','www.pecasauto.com.br','(11)91234-5678','Rua das Flores, 123','Centro','São Paulo',25,1),(2,'Fornecedora de Peças','Pessoa Jurídica','23.456.789/0001-88','2023-02-20','contato@fornecedora.com.br','www.fornecedora.com.br','(21)92345-6789','Av. das Américas, 456','Jardim','Rio de Janeiro',19,1),(3,'Auto Peças Brasil','Pessoa Jurídica','34.567.890/0001-77','2023-03-25','contato@autopecas.com.br','www.autopecas.com.br','(31)93456-7890','Rua do Comércio, 789','Bairro Alto','Belo Horizonte',13,1),(4,'Peças e Acessórios Ltda','Pessoa Jurídica','45.678.901/0001-66','2023-04-30','contato@pecaseacessorios.com.br','www.pecaseacessorios.com.br','(41)94567-8901','Rua das Palmeiras, 101','Centro','Curitiba',16,1),(5,'Global Auto Parts','Pessoa Jurídica','56.789.012/0001-55','2023-05-05','contato@globalautoparts.com.br','www.globalautoparts.com.br','(51)95678-9012','Rua das Oliveiras, 202','Jardim','Porto Alegre',21,1),(6,'Fornecedor de Peças','Pessoa Jurídica','67.890.123/0001-44','2023-06-10','contato@fornecedor.com.br','www.fornecedor.com.br','(61)96789-0123','Av. Brasil, 303','Bairro Novo','Brasília',7,1),(7,'Peças Rápidas','Pessoa Jurídica','78.901.234/0001-33','2023-07-15','contato@pecasrapidas.com.br','www.pecasrapidas.com.br','(71)97890-1234','Rua das Torres, 404','Centro','Salvador',5,1),(8,'Auto Peças Nordeste','Pessoa Jurídica','89.012.345/0001-22','2023-08-20','contato@autopecasnordeste.com.br','www.autopecasnordeste.com.br','(81)98901-2345','Rua do Sol, 505','Jardim','Recife',17,1),(9,'Supply Auto','Pessoa Jurídica','90.123.456/0001-11','2023-09-25','contato@supplyauto.com.br','www.supplyauto.com.br','(91)99012-3456','Rua da Luz, 606','Centro','Belém',14,1),(10,'Premium Peças','Pessoa Jurídica','01.234.567/0001-00','2023-10-30','contato@premiumpecas.com.br','www.premiumpecas.com.br','(41)99123-4567','Rua das Acácias, 707','Bairro Novo','Fortaleza',6,1);
/*!40000 ALTER TABLE `tbl_fornecedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_funcionario`
--

DROP TABLE IF EXISTS `tbl_funcionario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_funcionario` (
  `id_funcionario` int(11) NOT NULL AUTO_INCREMENT,
  `nome_funcionario` varchar(100) NOT NULL,
  `tipo_funcionario` varchar(20) NOT NULL,
  `cpf_cnpj_funcionario` varchar(18) NOT NULL,
  `data_adm_funcionario` date NOT NULL,
  `email_funcionario` varchar(100) NOT NULL,
  `senha_funcionario` varchar(20) NOT NULL,
  `telefone_funcionario` varchar(14) NOT NULL,
  `endereco_funcionario` varchar(100) NOT NULL,
  `bairro_funcionario` varchar(30) NOT NULL,
  `cidade_funcionario` varchar(30) NOT NULL,
  `id_uf` int(11) NOT NULL,
  `id_especialidade` int(11) NOT NULL,
  `salario_funcionario` decimal(10,2) NOT NULL,
  `id_status` int(11) NOT NULL,
  PRIMARY KEY (`id_funcionario`),
  UNIQUE KEY `cpf_cnpj_funcionario` (`cpf_cnpj_funcionario`),
  UNIQUE KEY `email_funcionario` (`email_funcionario`),
  KEY `fk_funcionario_status` (`id_status`),
  KEY `fk_funcionario_uf` (`id_uf`),
  KEY `fk_funcionario_especialidade` (`id_especialidade`),
  CONSTRAINT `fk_funcionario_especialidade` FOREIGN KEY (`id_especialidade`) REFERENCES `tbl_especialidade` (`id_especialidade`),
  CONSTRAINT `fk_funcionario_status` FOREIGN KEY (`id_status`) REFERENCES `tbl_status` (`id_status`),
  CONSTRAINT `fk_funcionario_uf` FOREIGN KEY (`id_uf`) REFERENCES `tbl_uf` (`id_uf`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_funcionario`
--

LOCK TABLES `tbl_funcionario` WRITE;
/*!40000 ALTER TABLE `tbl_funcionario` DISABLE KEYS */;
INSERT INTO `tbl_funcionario` VALUES (1,'Carlos Silva','Funcionário','123.456.789-00','2022-01-10','carlos.silva@email.com','senha123','(11)91234-5678','Rua das Palmeiras, 123','Centro','São Paulo',25,1,2500.00,1),(2,'Ana Costa','Funcionário','234.567.890-11','2022-02-15','ana.costa@email.com','senha456','(21)92345-6789','Av. das Américas, 456','Jardim','Rio de Janeiro',19,2,2800.00,1),(3,'Pedro Santos','Mecânico','345.678.901-22','2022-03-20','pedro.santos@email.com','senha789','(31)93456-7890','Rua do Comércio, 789','Bairro Alto','Belo Horizonte',13,3,3000.00,1),(4,'Fernanda Lima','Mecânico','456.789.012-33','2022-04-25','fernanda.lima@email.com','senha012','(41)94567-8901','Rua das Flores, 101','Centro','Curitiba',16,1,2700.00,1),(5,'Lucas Almeida','Gerente','567.890.123-44','2022-05-30','lucas.almeida@email.com','senha345','(51)95678-9012','Rua das Oliveiras, 202','Jardim','Porto Alegre',21,2,4000.00,1),(6,'Sofia Mendes','Funcionário','678.901.234-55','2022-06-10','sofia.mendes@email.com','senha678','(61)96789-0123','Av. Brasil, 303','Bairro Novo','Brasília',7,1,2500.00,2),(7,'Ricardo Rocha','Mecânico','789.012.345-66','2022-07-15','ricardo.rocha@email.com','senha901','(71)97890-1234','Rua das Torres, 404','Centro','Salvador',5,3,2900.00,1),(8,'Juliana Martins','Funcionário','890.123.456-77','2022-08-20','juliana.martins@email.com','senha234','(81)98901-2345','Rua do Sol, 505','Jardim','Recife',17,1,2600.00,1),(9,'Gustavo Oliveira','Funcionário','901.234.567-88','2022-09-25','gustavo.oliveira@email.com','senha567','(91)99012-3456','Rua da Luz, 606','Centro','Belém',14,1,2500.00,1),(10,'Mariana Ferreira','Gerente','012.345.678-99','2022-10-30','mariana.ferreira@email.com','senha890','(41)99123-4567','Rua das Acácias, 707','Bairro Novo','Fortaleza',6,2,4500.00,1);
/*!40000 ALTER TABLE `tbl_funcionario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_marca`
--

DROP TABLE IF EXISTS `tbl_marca`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_marca` (
  `id_marca` int(11) NOT NULL AUTO_INCREMENT,
  `nome_marca` varchar(40) NOT NULL,
  PRIMARY KEY (`id_marca`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_marca`
--

LOCK TABLES `tbl_marca` WRITE;
/*!40000 ALTER TABLE `tbl_marca` DISABLE KEYS */;
INSERT INTO `tbl_marca` VALUES (1,'Volkswagem'),(2,'Ford'),(3,'Chevrolet'),(4,'Fiat'),(5,'Toyota'),(6,'Honda'),(7,'Nissan'),(8,'Hyundai'),(9,'Renault'),(10,'Kia'),(11,'Subaru'),(12,'Mercedes-Benz'),(13,'BMW'),(14,'Audi'),(15,'Peugeot'),(16,'Citroën'),(17,'Land Rover'),(18,'Mitsubishi'),(19,'Lexus'),(20,'Chrysler');
/*!40000 ALTER TABLE `tbl_marca` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_modelo`
--

DROP TABLE IF EXISTS `tbl_modelo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_modelo` (
  `id_modelo` int(11) NOT NULL AUTO_INCREMENT,
  `nome_modelo` varchar(40) NOT NULL,
  `id_marca` int(11) NOT NULL,
  PRIMARY KEY (`id_modelo`),
  KEY `fk_modelo_marca` (`id_marca`),
  CONSTRAINT `fk_modelo_marca` FOREIGN KEY (`id_marca`) REFERENCES `tbl_marca` (`id_marca`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_modelo`
--

LOCK TABLES `tbl_modelo` WRITE;
/*!40000 ALTER TABLE `tbl_modelo` DISABLE KEYS */;
INSERT INTO `tbl_modelo` VALUES (1,'Gol',1),(2,'Polo',1),(3,'Fiesta',2),(4,'Focus',2),(5,'Onix',3),(6,'Tracker',3),(7,'Palio',4),(8,'Argo',4),(9,'Corolla',5),(10,'Civic',6),(11,'Sentra',7),(12,'HB20',8),(13,'Duster',9),(14,'Seltos',10),(15,'Outback',11),(16,'X1',13),(17,'A3',14),(18,'300C',20),(19,'L200',18),(20,'RAV4',5);
/*!40000 ALTER TABLE `tbl_modelo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_ordem`
--

DROP TABLE IF EXISTS `tbl_ordem`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_ordem` (
  `id_ordem` int(11) NOT NULL AUTO_INCREMENT,
  `id_veiculo` int(11) NOT NULL,
  `data_abertura_ordem` datetime NOT NULL,
  `data_fechamento_ordem` datetime NOT NULL,
  `status_ordem` varchar(20) NOT NULL,
  `obs_ordem` text NOT NULL,
  PRIMARY KEY (`id_ordem`),
  KEY `fk_ordem_veiculo` (`id_veiculo`),
  CONSTRAINT `fk_ordem_veiculo` FOREIGN KEY (`id_veiculo`) REFERENCES `tbl_veiculo` (`id_veiculo`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_ordem`
--

LOCK TABLES `tbl_ordem` WRITE;
/*!40000 ALTER TABLE `tbl_ordem` DISABLE KEYS */;
INSERT INTO `tbl_ordem` VALUES (1,7,'2024-10-25 00:00:00','2024-10-28 00:00:00','FINALIZADO','Problemas no freio');
/*!40000 ALTER TABLE `tbl_ordem` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_peca`
--

DROP TABLE IF EXISTS `tbl_peca`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_peca` (
  `id_peca` int(11) NOT NULL AUTO_INCREMENT,
  `nome_peca` varchar(100) NOT NULL,
  `descricao_peca` text NOT NULL,
  `id_fornecedor` int(11) NOT NULL,
  `valor_peca` decimal(10,2) NOT NULL,
  `qtde_estoque_peca` int(11) NOT NULL,
  `foto_peca` varchar(150) NOT NULL,
  `id_status` int(11) NOT NULL,
  PRIMARY KEY (`id_peca`),
  KEY `fk_peca_fornecedor` (`id_fornecedor`),
  KEY `fk_peca_status` (`id_status`),
  CONSTRAINT `fk_peca_fornecedor` FOREIGN KEY (`id_fornecedor`) REFERENCES `tbl_fornecedor` (`id_fornecedor`),
  CONSTRAINT `fk_peca_status` FOREIGN KEY (`id_status`) REFERENCES `tbl_status` (`id_status`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_peca`
--

LOCK TABLES `tbl_peca` WRITE;
/*!40000 ALTER TABLE `tbl_peca` DISABLE KEYS */;
INSERT INTO `tbl_peca` VALUES (1,'Filtro de Óleo','Filtro de óleo para motores 1.6',1,50.00,100,'img/pecas/filtro_oleo.png',1),(2,'Pastilha de Freio','Pastilha de freio dianteira',2,120.00,50,'img/pecas/pastilha_freio.png',1),(3,'Vela de Ignição','Vela de ignição de alto desempenho',1,35.00,200,'img/pecas/vela_ignicao.png',2),(4,'Correia Dentada','Correia dentada para motor 2.0',3,75.00,80,'img/pecas/correia_dentada.png',1),(5,'Bateria 60Ah','Bateria automotiva 60Ah',2,350.00,30,'img/pecas/bateria_60ah.png',1),(6,'Amortecedor Dianteiro','Amortecedor dianteiro para sedan',1,250.00,40,'img/pecas/amortecedor_dianteiro.png',2),(7,'Radiador','Radiador para sistemas de arrefecimento',3,450.00,20,'img/pecas/radiador.png',1),(8,'Embreagem','Kit de embreagem completo',2,650.00,15,'img/pecas/embreagem.png',1),(9,'Disco de Freio','Disco de freio ventilado',4,180.00,100,'img/pecas/disco_freio.png',3),(10,'Retrovisor Elétrico','Retrovisor elétrico esquerdo',1,200.00,60,'img/pecas/retrovisor_eletrico.png',2),(11,'Parafuso de Roda','Jogo de parafusos de roda',3,25.00,500,'img/pecas/parafuso_roda.png',1),(12,'Kit Farol de Milha','Kit farol de milha com lâmpadas LED',4,280.00,25,'img/pecas/farol_milha.png',1);
/*!40000 ALTER TABLE `tbl_peca` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_peca_utilizada`
--

DROP TABLE IF EXISTS `tbl_peca_utilizada`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_peca_utilizada` (
  `id_peca_utilizada` int(11) NOT NULL AUTO_INCREMENT,
  `id_ordem` int(11) NOT NULL,
  `id_peca` int(11) NOT NULL,
  `valor_peca` decimal(10,2) NOT NULL,
  `qtde_utilizada` int(11) NOT NULL,
  `valor_peca_utilizada` decimal(10,2) NOT NULL,
  PRIMARY KEY (`id_peca_utilizada`),
  KEY `fk_peca_utilizada_ordem` (`id_ordem`),
  KEY `fk_peca_utilizada_peca` (`id_peca`),
  CONSTRAINT `fk_peca_utilizada_ordem` FOREIGN KEY (`id_ordem`) REFERENCES `tbl_ordem` (`id_ordem`),
  CONSTRAINT `fk_peca_utilizada_peca` FOREIGN KEY (`id_peca`) REFERENCES `tbl_peca` (`id_peca`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_peca_utilizada`
--

LOCK TABLES `tbl_peca_utilizada` WRITE;
/*!40000 ALTER TABLE `tbl_peca_utilizada` DISABLE KEYS */;
INSERT INTO `tbl_peca_utilizada` VALUES (1,1,2,120.00,2,240.00);
/*!40000 ALTER TABLE `tbl_peca_utilizada` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_servico`
--

DROP TABLE IF EXISTS `tbl_servico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_servico` (
  `id_servico` int(11) NOT NULL AUTO_INCREMENT,
  `nome_servico` varchar(50) NOT NULL,
  `descricao_servico` text NOT NULL,
  `preco_base_servico` decimal(10,2) NOT NULL,
  `tempo_estimado_servico` time NOT NULL,
  `foto_servico` varchar(150) NOT NULL,
  `id_especialidade` int(11) NOT NULL,
  `id_status` int(11) NOT NULL,
  PRIMARY KEY (`id_servico`),
  KEY `fk_servico_especialidade` (`id_especialidade`),
  KEY `fk_servico_status` (`id_status`),
  CONSTRAINT `fk_servico_especialidade` FOREIGN KEY (`id_especialidade`) REFERENCES `tbl_especialidade` (`id_especialidade`),
  CONSTRAINT `fk_servico_status` FOREIGN KEY (`id_status`) REFERENCES `tbl_status` (`id_status`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_servico`
--

LOCK TABLES `tbl_servico` WRITE;
/*!40000 ALTER TABLE `tbl_servico` DISABLE KEYS */;
INSERT INTO `tbl_servico` VALUES (1,'Troca de Óleo','Serviço completo de troca de óleo do motor',120.00,'00:45:00','img/servicos/troca_oleo.png',1,1),(2,'Alinhamento e Balanceamento','Alinhamento e balanceamento das rodas',100.00,'01:00:00','img/servicos/alinhamento.png',2,1),(3,'Revisão Completa','Revisão geral dos sistemas do veículo',450.00,'04:00:00','img/servicos/revisao.png',3,2),(4,'Troca de Pastilha de Freio','Substituição das pastilhas de freio',150.00,'01:30:00','img/servicos/troca_pastilha.png',1,1),(5,'Troca de Amortecedor','Troca do amortecedor dianteiro e traseiro',300.00,'02:30:00','img/servicos/troca_amortecedor.png',4,1),(6,'Revisão de Suspensão','Inspeção e manutenção do sistema de suspensão',220.00,'02:00:00','img/servicos/revisao_suspensao.png',5,3),(7,'Troca de Bateria','Substituição da bateria automotiva',180.00,'00:40:00','img/servicos/troca_bateria.png',2,1),(8,'Troca de Correia Dentada','Troca da correia dentada do motor',250.00,'03:00:00','img/servicos/troca_correia.png',3,2),(9,'Pintura Automotiva','Pintura completa do veículo',1500.00,'12:00:00','img/servicos/pintura.png',6,1),(10,'Higienização de Ar-condicionado','Limpeza e higienização do ar-condicionado',90.00,'00:30:00','img/servicos/higienizacao_ac.png',4,1),(11,'Inspeção de Freios','Verificação e ajustes do sistema de freios',80.00,'01:20:00','img/servicos/inspecao_freios.png',1,2),(12,'Polimento Automotivo','Polimento completo da lataria do veículo',350.00,'03:30:00','img/servicos/polimento.png',6,1);
/*!40000 ALTER TABLE `tbl_servico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_servico_executado`
--

DROP TABLE IF EXISTS `tbl_servico_executado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_servico_executado` (
  `id_servico_executado` int(11) NOT NULL AUTO_INCREMENT,
  `id_ordem` int(11) NOT NULL,
  `id_servico` int(11) NOT NULL,
  `valor_servico_executado` decimal(10,2) NOT NULL,
  `tempo_servico_executado` time NOT NULL,
  `id_funcionario` int(11) NOT NULL,
  PRIMARY KEY (`id_servico_executado`),
  KEY `fk_servico_executado_ordem` (`id_ordem`),
  KEY `fk_servico_executado_servico` (`id_servico`),
  KEY `fk_servico_executado_funcionario` (`id_funcionario`),
  CONSTRAINT `fk_servico_executado_funcionario` FOREIGN KEY (`id_funcionario`) REFERENCES `tbl_funcionario` (`id_funcionario`),
  CONSTRAINT `fk_servico_executado_ordem` FOREIGN KEY (`id_ordem`) REFERENCES `tbl_ordem` (`id_ordem`),
  CONSTRAINT `fk_servico_executado_servico` FOREIGN KEY (`id_servico`) REFERENCES `tbl_servico` (`id_servico`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_servico_executado`
--

LOCK TABLES `tbl_servico_executado` WRITE;
/*!40000 ALTER TABLE `tbl_servico_executado` DISABLE KEYS */;
INSERT INTO `tbl_servico_executado` VALUES (1,1,4,150.00,'01:30:00',6);
/*!40000 ALTER TABLE `tbl_servico_executado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_status`
--

DROP TABLE IF EXISTS `tbl_status`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_status` (
  `id_status` int(11) NOT NULL AUTO_INCREMENT,
  `nome_status` varchar(11) NOT NULL,
  PRIMARY KEY (`id_status`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_status`
--

LOCK TABLES `tbl_status` WRITE;
/*!40000 ALTER TABLE `tbl_status` DISABLE KEYS */;
INSERT INTO `tbl_status` VALUES (1,'Ativo'),(2,'Inativo'),(3,'Desativado');
/*!40000 ALTER TABLE `tbl_status` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_uf`
--

DROP TABLE IF EXISTS `tbl_uf`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_uf` (
  `id_uf` int(11) NOT NULL AUTO_INCREMENT,
  `nome_uf` varchar(20) NOT NULL,
  `sigla_uf` varchar(2) NOT NULL,
  PRIMARY KEY (`id_uf`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_uf`
--

LOCK TABLES `tbl_uf` WRITE;
/*!40000 ALTER TABLE `tbl_uf` DISABLE KEYS */;
INSERT INTO `tbl_uf` VALUES (1,'Acre','AC'),(2,'Alagoas','AL'),(3,'Amapá','AP'),(4,'Amazonas','AM'),(5,'Bahia','BA'),(6,'Ceará','CE'),(7,'Distrito Federal','DF'),(8,'Espírito Santos','ES'),(9,'Goiás','GO'),(10,'Maranhão','MA'),(11,'Mato Grosso','MT'),(12,'Mato Grosso do Sul','MS'),(13,'Minas Gerais','MG'),(14,'Pará','PA'),(15,'Paraiba','PB'),(16,'Paraná','PR'),(17,'Pernambuco','PE'),(18,'Piauí','PI'),(19,'Rio de Janeiro','RJ'),(20,'Rio Grande do Norte','RN'),(21,'Rio Grande do Sul','RS'),(22,'Rondônia','RO'),(23,'Roraima','RR'),(24,'Santa Catarina','SC'),(25,'São Paulo','SP'),(26,'Sergipe','SE'),(27,'Tocantins','TO');
/*!40000 ALTER TABLE `tbl_uf` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_veiculo`
--

DROP TABLE IF EXISTS `tbl_veiculo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_veiculo` (
  `id_veiculo` int(11) NOT NULL AUTO_INCREMENT,
  `id_cliente` int(11) NOT NULL,
  `id_modelo` int(11) NOT NULL,
  `placa_veiculo` varchar(7) NOT NULL,
  `ano_veiculo` year(4) NOT NULL,
  `combustivel_veiculo` varchar(10) NOT NULL,
  `chassi_veiculo` varchar(30) NOT NULL,
  `cor_veiculo` varchar(20) NOT NULL,
  `km_veiculo` int(11) NOT NULL,
  `id_status` int(11) NOT NULL,
  PRIMARY KEY (`id_veiculo`),
  UNIQUE KEY `placa_veiculo` (`placa_veiculo`),
  UNIQUE KEY `chassi_veiculo` (`chassi_veiculo`),
  KEY `fk_veiculo_cliente` (`id_cliente`),
  KEY `fk_veiculo_modelo` (`id_modelo`),
  KEY `fk_veiculo_status` (`id_status`),
  CONSTRAINT `fk_veiculo_cliente` FOREIGN KEY (`id_cliente`) REFERENCES `tbl_cliente` (`id_cliente`),
  CONSTRAINT `fk_veiculo_modelo` FOREIGN KEY (`id_modelo`) REFERENCES `tbl_modelo` (`id_modelo`),
  CONSTRAINT `fk_veiculo_status` FOREIGN KEY (`id_status`) REFERENCES `tbl_status` (`id_status`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_veiculo`
--

LOCK TABLES `tbl_veiculo` WRITE;
/*!40000 ALTER TABLE `tbl_veiculo` DISABLE KEYS */;
INSERT INTO `tbl_veiculo` VALUES (1,1,3,'ABC1234',2020,'Gasolina','1HGCM82633A004352','Preto',45000,1),(2,2,5,'DEF5678',2018,'Flex','1J4GZB8S5X1234567','Branco',60000,2),(3,3,2,'GHI9876',2022,'Diesel','4T1BG22KXWU304692','Prata',30000,1),(4,4,4,'JKL4321',2017,'Flex','2HGEJ667XWH598392','Vermelho',80000,1),(5,1,1,'MNO8765',2019,'Gasolina','1C3CCBBB1FN112233','Azul',52000,2),(6,2,3,'PQR3456',2021,'Flex','3HGCM56427G789014','Preto',22000,3),(7,3,6,'STU6543',2020,'Diesel','5N1AA0NC6EN345678','Cinza',46000,1),(8,4,7,'VWX1239',2016,'Gasolina','1FTEX1CMXKE987654','Verde',95000,2),(9,1,8,'YZA7654',2019,'Flex','JH4DC4461RS012345','Branco',37000,1),(10,2,4,'BCD9876',2018,'Diesel','1HGCG2258XA456789','Prata',78000,3),(11,3,9,'EFG3457',2022,'Flex','5XYKT3A12EG112233','Azul',12000,1),(12,4,1,'HIJ1234',2021,'Gasolina','1FTSW21PXYEG234567','Cinza',31000,2),(13,1,5,'KLM8765',2019,'Diesel','2G1WC581789987654','Preto',41000,1),(14,2,2,'NOP4321',2020,'Flex','1G1BL52P7TR567890','Vermelho',29000,3),(15,3,3,'QRS6543',2021,'Gasolina','5TDBT48A85S345678','Branco',13000,2);
/*!40000 ALTER TABLE `tbl_veiculo` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-05-12 19:03:25
