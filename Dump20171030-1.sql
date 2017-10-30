CREATE DATABASE  IF NOT EXISTS `controlepatrimonio` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `controlepatrimonio`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: controlepatrimonio
-- ------------------------------------------------------
-- Server version	5.7.18-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `__migrationhistory`
--

DROP TABLE IF EXISTS `__migrationhistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `__migrationhistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ContextKey` varchar(300) NOT NULL,
  `Model` longblob NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`,`ContextKey`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__migrationhistory`
--

LOCK TABLES `__migrationhistory` WRITE;
/*!40000 ALTER TABLE `__migrationhistory` DISABLE KEYS */;
INSERT INTO `__migrationhistory` VALUES ('201710301125394_First_Migration','ControlePatrimonio.Models.ApplicationDbContext','�\0\0\0\0\0\0\�\�rܸ�=U�S^�eŎ\�vK�c�\�:\�#��\�Ḧe�<�R��ey\�\'\�� ��$�SZ�^48\Z�Fw�\0��������\��/\n�\���׶C\'r�p{dg\�\���O?���gn�h})\�\�v�g�\��i���Z%\�=@�xN%\�&\�s�`\�h�\��뿮��W��,\�:�������y�ܥ�/#�	)G5\��u�\��l\�6�#ހ4��(�����m�@����-�Q\nR�\�\�	\\�>\�v�C��}\�A\�n��i|��w�\�\�7xF��c	\�ɒ4\n4\���\�F��+\"\"�!b�Ox\�9!\rA\n�Q\�\�\�G�p\�Ǹe���\�,�ѫ�K3\�?\�(�\�,�G!\�\�����\�\�����\�\��\�\��i�ʨ�)@E7q��q��	n\�4.Nmk\��[��nT�b~az�ƶ�\�\�\�·?P�X�Q�!�ь]4\�\�h9/\\�ST�\�\�\�E��a\'\"ٲ�K���\���\�F�\�ֹ�ݲ���9��(�Ni�Av�\�U���k}\�b��4\�<�:�\�\�N�\�WQ\0^^	3An�p��N�n�>� g�c\�D\�\�\�s�;>\�>��?����tȹ�vV\�L�}�k�fq(�l����L��� %_|Wz�IRd�}\�1QMQB�Ql����\�U\�\�\�ȹ�K`�\00�N��\�\����_�Au�d.�U�3�E��\�j\�eYV�U\�\�\�4W{ho�+H� �~�Y\Z�Ś��\�S��\���|9*��\\�S�8�7\�&x�0�\�0�&�L�h\r;�\�\�_@�F�X\�\��0��pV�\�3\Z����\�@\�E\�A�\�\��tW\��\�\���\\\�\�\�\'\�\��ɽ�+�:([\�k\�\�<��O�\�X\Ze\�\�u�\��\�H\�\�\�[��\Z7%F�M\���Y\�\�Ud\�\�/�0\�\�N�\�+<>�� v&ѠS)\�Oϣ	\�y:k\���y\r�\�\�\�.WH�νę\��q���oǿf^Bӹ���\��kF\�A�:Պ\� �JqZ�\�J��7\��\��q���\�^\�q�\0y#p�E�=\Z\�+�s�z?y\�u?9ؿ\����\��\�N��H�|�\��N\\�+a�џy��\� �*y\Z����\���J�\�-\�\n-i2KcPóu	u��]\�����xB&�\�\�N�$\r%�\�ۙ\�w;�x9ka��\�\��gmsO\�	\��\�ϲ�qho`����U:��q\�Etq\�ƋX!�s�����u I��t���ѩ��N#�]� ؍�y��*\�`<\�X�-\�\�o\�9p�c|\�^�\�}��oQ���.��?��hpw0:ǎ�\�13tO�,L��Xc\�m����\�6\Z��|-�\�v���`�)�\�\�&T?F[/\�j\�T�jѢU\�LU����\ZѼA+�E��,\�|��7�s�˷��~t8��/t�K<\�\�gCe$\r�^\Zr�˗�MT�\�\�*\�\����N\�\�>g�\�q�M-\�4�|\Z��\�$�/��ƈ:�d\�G&�\�zZY̅:\�D3B\�\�aqd�I K\�r;�\�R\�,\�}�\�\�\���0�ֱS|t\'8\��)-A�\rc,\�\0{=	M/LE9�B\�\��\r��|\�>���UC�5�pC�f\�֤\�\�\�품D5G�6\"�(.ka>��T\�%\r���QO48P}\�\�\�`@%��8Pvh���\�u\�28�h�g���\�l�f��eDNiDL½\�9y�|�J�]��OĈ\n�]�\�m|�\�\�i�$<\�rr�\�K⽎\���9�I\�\�\�JNj�2\0l�4\�΋J\�I��\�ʒ\�\�1hq@\�u��Ӻ��\'{L8��\�H�x��\�\�X���}.\�c�=O\�p%|L%GSOr:�G�g|\rSއKl�v�E�Y�}X0\�#�*�A�\�\ZS��V�\r@����a�\�%��]\�6@�w\"�R:�- \�5�П�Z��B\��V-@\�\����4�+o�\Z�#V�\��V�,ٛ9���\n\�J?ʣ\�)_\��\�\�X5-��%\�\�0��D=���\�B\�v	5ZNj��\�\���Ŵ�$\�ә\�5��썛H������\��l7Т�ק\�H�Eo��.�E\�tqeu�Yjbd1\Z\�\�x*�TNfp*����J2Jǣ\�E%\��QP��\�\�T\"<\�N$�M�a\��\"k�$l\�5Me,Vu��\"�\Z)8\\)�^�\�\��T\�6Rb�IԶ\��q̂\�\�a�͛�\�Hi�-\�j��G�{q�\��w\0_R���\�Lj\Z+��rH��W��\�.�ҭ=��ĩ p\�\�T\�\�d��\�\�\�\��b���)�H\�gA��\rR�悜р�*\�ኛ�\�	�WvI:-X\�g�\\�o��Xʞʥr���8�\�\�\�\�t��Dc���\�:W�\�!1ch(EIwu\\\r\ZJ]��	i�`CʺC�+h��8��\0.X�Ȕ~�0C|q}�QuG^�\��\�\�ڰDd*�d�<\�\�%Z~\�ш\�\�d���\�`Cʖ��\�O\�\�j ���䴡�\�\�\�\�\�\n4,�|\�$�k�\�\'/z^{e��\�_�,F\Z\�C�a��:/֗Ʀο����҉V�\�B�\�5�1Q�xL�	D	�\\���կ�T?�j�%�\�Tt�\�FG��5\Z\���Xc��� 1[]���J��/�� s\�\r��\��\nmDC�\n\�\�]\�+Yf7R\\\�6A����\�\�\�C4��l9�\\y\�1\�&\'�\�\�éz�glV\�T�ͩ��m�Ǽ�f,��\�\�jxe�\ZTY����\�\0)���U!��Z\��a\�,�G��H64R�\�Mu$��\��yU7��\�W��Ũ&\�%��^b�I\�+�\�\�#i( �\�@nJʹ>\�հkU�@1_/5�q���	8��+��϶~��&k\�?�\�_�V\�HY	�7\�\"\�	P3\�0�>$\�cY5��;ġ�C\0F\�\�ё<\�\� ��;D.\\\r��\���\�� IW�SPT\�BÂ\�p0F�P�\��9gP�6�-���\�U��,�\�s=\�}�.]���<R\Z~�.d�ۭ0\�Q�\�l�TT\��5a��0R�H�R>;\�\�T\�s\�~L���\�CLXV\r5\�BPü�cpǤ\�X	jxz�;*��\��&\�褤�]=>#���\�^�Ml�$\�}���\�\�\��{��\'��V/[\\�\�\��$-d\�o��¥]N\n\�U��\�S��<�\�M�}\�\�Tm�d�@L�pӏ\�m�K\rm�|�&\�h�\�9+�JBu.i�):��)>ْ1.L�#S(u#c<ꤏ�\�)ճec!\�O>J�?�\�&&G|\�f.|~\n\�$�\�ː�%)z1�\�\�\���}\�{�\�n`�P�$z�b����\�l����\�Ib7#��i݌��\�ږ�$|\�~�t\�\����\�\�\�_����\�)�\�k\�\�Cd{3��,���;\�c\� \�\�\�\�\��S��2b\�~�\�\�l\���$/�	rY\�\�\�\�\���\�PĔh��،gCo+Ұ{\�uO�\�\�26)\�\�[]�յ��c�v�N�\�\�\�C�/6����J\�2��6~�U��kv�*\�ue������\\���\�\�A,F\�\�y�\�&�x\������u�|�_3Tq�VK>�`X�˟\�,4oPw�\"UZte�h\�f�	iaSt큍q��\�+Plʞ��\�\r��g$OO�\�BJ+N\�ͳ\�\�E�?H�SrI3\�{�b��@\rC4U#`\�8\�\�p�\�\��\�a�L�cby�q�\�ײ\�{�\�˳u���\�\nH�\�2!�\��q\����zc�\��F̬1\�9z�t\Z\�k�	�\\�\�rx��m\n�\�婋e�\��\�\�ncq�p�����O��is[�\�dK\�_QG��\�3aڊ)3U4|+\���e\"\�ꗠb!\�%!�|6a\Z��yM�\�_\�\\p�\�&\�l$0��\�&L)15��>X8�i%�X�͵\�\�i��\�\�\�@�!q�e%\�k�NIsz�\�s�#۽\�\�x\�\�6D�\�G�r<cT5�\�-�\����B�J(\��\�!@UJ��N�D�6\�@t�l��h���Mi\'�C��\��\0��/�\�Vˆ*2\�\�\�]��U�r���zPu�m~`A\�\n-��՛+1#\'K\�4��N\�46�*\Z\�&m�\�V\�|�&�����8ۢ\Z��P=o\���4�;\�\�s��:\�\�\�2bH\�\�˒ش\�=�\�H�\�p����IK>�6WAy�%\'��(�^T|o<<Q\�\�o1I��|\�\�\�\�\�B|3^�:����A\"�\�Rc�\�\�E��Jc�èl¿��)p�+�8�6�IQ5�ϓ�\�׋غ��\�Ex���,ES���\�\\\�a��i�<i��\���J��B\�Ï	�ß3\�w+�\�%�W\n\�!w\�x-S|��}� ]	їU��*\'\n�d��\�:\\�h�b��p����R�}!X��z`� !0\��\�\'\�a7x���[�\nע�\0\0','6.1.3-40302');
/*!40000 ALTER TABLE `__migrationhistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetroles`
--

DROP TABLE IF EXISTS `aspnetroles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aspnetroles` (
  `Id` varchar(128) NOT NULL,
  `Name` varchar(256) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `RoleNameIndex` (`Name`) USING HASH
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetroles`
--

LOCK TABLES `aspnetroles` WRITE;
/*!40000 ALTER TABLE `aspnetroles` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetroles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetuserclaims`
--

DROP TABLE IF EXISTS `aspnetuserclaims`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aspnetuserclaims` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `UserId` varchar(128) NOT NULL,
  `ClaimType` longtext,
  `ClaimValue` longtext,
  PRIMARY KEY (`Id`),
  KEY `IX_UserId` (`UserId`) USING HASH,
  CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetuserclaims`
--

LOCK TABLES `aspnetuserclaims` WRITE;
/*!40000 ALTER TABLE `aspnetuserclaims` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetuserclaims` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetuserlogins`
--

DROP TABLE IF EXISTS `aspnetuserlogins`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aspnetuserlogins` (
  `LoginProvider` varchar(128) NOT NULL,
  `ProviderKey` varchar(128) NOT NULL,
  `UserId` varchar(128) NOT NULL,
  PRIMARY KEY (`LoginProvider`,`ProviderKey`,`UserId`),
  KEY `IX_UserId` (`UserId`) USING HASH,
  CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetuserlogins`
--

LOCK TABLES `aspnetuserlogins` WRITE;
/*!40000 ALTER TABLE `aspnetuserlogins` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetuserlogins` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetuserroles`
--

DROP TABLE IF EXISTS `aspnetuserroles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aspnetuserroles` (
  `UserId` varchar(128) NOT NULL,
  `RoleId` varchar(128) NOT NULL,
  PRIMARY KEY (`UserId`,`RoleId`),
  KEY `IX_UserId` (`UserId`) USING HASH,
  KEY `IX_RoleId` (`RoleId`) USING HASH,
  CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetuserroles`
--

LOCK TABLES `aspnetuserroles` WRITE;
/*!40000 ALTER TABLE `aspnetuserroles` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetuserroles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetusers`
--

DROP TABLE IF EXISTS `aspnetusers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aspnetusers` (
  `Id` varchar(128) NOT NULL,
  `Region` longtext,
  `UsuarioPerfil` longtext,
  `FilialId` int(11) DEFAULT NULL,
  `Email` varchar(256) DEFAULT NULL,
  `EmailConfirmed` tinyint(1) NOT NULL,
  `PasswordHash` longtext,
  `SecurityStamp` longtext,
  `PhoneNumber` longtext,
  `PhoneNumberConfirmed` tinyint(1) NOT NULL,
  `TwoFactorEnabled` tinyint(1) NOT NULL,
  `LockoutEndDateUtc` datetime DEFAULT NULL,
  `LockoutEnabled` tinyint(1) NOT NULL,
  `AccessFailedCount` int(11) NOT NULL,
  `UserName` varchar(256) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UserNameIndex` (`UserName`) USING HASH
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetusers`
--

LOCK TABLES `aspnetusers` WRITE;
/*!40000 ALTER TABLE `aspnetusers` DISABLE KEYS */;
INSERT INTO `aspnetusers` VALUES ('9e82385f-c17b-4cfb-a360-693ee105d5dc','Goias','Admin',1,'flaviorichman@nfl.com',0,'AAx74WmP8Mbk26P2o7DWmsqhv9m2J1k5H7smHhylbD7AhHEjKta/niPV37vfzMyzhQ==','ab04521c-f700-4110-8e8c-85d557862fcb',NULL,0,0,NULL,1,0,'flaviorichman@nfl.com');
/*!40000 ALTER TABLE `aspnetusers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categorias`
--

DROP TABLE IF EXISTS `categorias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `categorias` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `TipoCategoria` longtext,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categorias`
--

LOCK TABLES `categorias` WRITE;
/*!40000 ALTER TABLE `categorias` DISABLE KEYS */;
/*!40000 ALTER TABLE `categorias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empresas`
--

DROP TABLE IF EXISTS `empresas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `empresas` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` longtext,
  `Telefone` longtext,
  `CNPJ` longtext,
  `Endereco` longtext,
  `Cidade` longtext,
  `UF` longtext,
  `CEP` longtext,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empresas`
--

LOCK TABLES `empresas` WRITE;
/*!40000 ALTER TABLE `empresas` DISABLE KEYS */;
/*!40000 ALTER TABLE `empresas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `filials`
--

DROP TABLE IF EXISTS `filials`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `filials` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `EmpresaId` int(11) NOT NULL,
  `EmpresaNome` longtext,
  `NomeFilial` longtext,
  `Endereco` longtext,
  `Cidade` longtext,
  `Estado` longtext,
  `Telefone` longtext,
  `CNPJ` longtext,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `filials`
--

LOCK TABLES `filials` WRITE;
/*!40000 ALTER TABLE `filials` DISABLE KEYS */;
/*!40000 ALTER TABLE `filials` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fornecedors`
--

DROP TABLE IF EXISTS `fornecedors`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `fornecedors` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` longtext,
  `Telefone` longtext,
  `Observacao` longtext,
  `Endereco` longtext,
  `Email` longtext,
  `Cidade` longtext,
  `UF` longtext,
  `Pais` longtext,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fornecedors`
--

LOCK TABLES `fornecedors` WRITE;
/*!40000 ALTER TABLE `fornecedors` DISABLE KEYS */;
/*!40000 ALTER TABLE `fornecedors` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `patrimonios`
--

DROP TABLE IF EXISTS `patrimonios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `patrimonios` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `EmpresaId` int(11) NOT NULL,
  `EmpresaNome` longtext,
  `FilialId` int(11) NOT NULL,
  `FilialNome` longtext,
  `FornecedorId` int(11) NOT NULL,
  `FornecedorNome` longtext,
  `ProdutoId` int(11) NOT NULL,
  `ProdutoNome` longtext,
  `DataCadastro` datetime NOT NULL,
  `Descricao` longtext,
  `NumeroSerie` longtext,
  `NumeroPatrimonio` longtext,
  `TempoGarantia` int(11) NOT NULL,
  `Licensa` longtext,
  `Observacao` longtext,
  `UserId` longtext,
  `UsuarioEmail` longtext,
  `Regiao` longtext,
  PRIMARY KEY (`Id`),
  KEY `IX_ProdutoId` (`ProdutoId`) USING HASH,
  CONSTRAINT `FK_Patrimonios_Produtoes_ProdutoId` FOREIGN KEY (`ProdutoId`) REFERENCES `produtoes` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patrimonios`
--

LOCK TABLES `patrimonios` WRITE;
/*!40000 ALTER TABLE `patrimonios` DISABLE KEYS */;
/*!40000 ALTER TABLE `patrimonios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `produtoes`
--

DROP TABLE IF EXISTS `produtoes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `produtoes` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `NomeProduto` longtext,
  `CategoriaID` int(11) NOT NULL,
  `Modelo` longtext,
  `Marca` longtext,
  `Obsrvacao` longtext,
  `URLFoto` longtext,
  `Descricao` longtext,
  `Valor` float NOT NULL,
  `NotaFiscal` longtext,
  `TempoGarantia` int(11) NOT NULL,
  `DataAquisicao` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_CategoriaID` (`CategoriaID`) USING HASH,
  CONSTRAINT `FK_Produtoes_Categorias_CategoriaID` FOREIGN KEY (`CategoriaID`) REFERENCES `categorias` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produtoes`
--

LOCK TABLES `produtoes` WRITE;
/*!40000 ALTER TABLE `produtoes` DISABLE KEYS */;
/*!40000 ALTER TABLE `produtoes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'controlepatrimonio'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-10-30 13:38:25
