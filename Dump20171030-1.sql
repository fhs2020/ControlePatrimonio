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
INSERT INTO `__migrationhistory` VALUES ('201710301125394_First_Migration','ControlePatrimonio.Models.ApplicationDbContext','‹\0\0\0\0\0\0\í\ÙrÜ¸ñ=UùS^eÅ\ã’vK«c£\Ä:\Ê#»ò\æ‚HÌˆe³<´R¥òey\È\'\å ‰“$ÀSZ—^48\ZFw£\0»ÿ÷Ÿÿşôø\ÖŒ/\n\ìı½×¶C\'r½p{dg\é\æ‡÷öO?şñ‡gnğh})\Û\àv¨g˜\Ù÷iºû°Z%\Î=@²xN%\Ñ&\İs¢`\Ühõ\æõë¿®ö÷W°,\Ë:ü”…©Àüúy…Ü¥ğ/#ú	)G5\ëªu˜\ì€l\Ô6#Ş€4ö‚(ô¢½¢“mû@­¡¿±-†Q\nR„\î‡\Ï	\\£>\áv½CÀ¿}\ÚA\Ônü’i|¨›w\Ñ\ë7xF«ºc	\ÊÉ’4\n4\î­ø\îF„¶+\"\"!b§Ox\Ö9!\rA\n·Q\ì\Û\âGûp\âÇ¸e¡÷ª\î¯,±Ñ«ŠK3\á?\Ô(ó\Ó,†G!\Ì\Òø¯¬›\ì\Î÷œÀ§\Û\è\Â\Ì÷i„Ê¨)@E7q´ƒqúô	n\È4.Nmk\Åö[ñ«nTŸb~azğÆ¶®\Ğ\à\àÎ‡?P´X§Q!ŒÑŒ]4\Ç\Æh9/\\˜ST\ë\Ö\ÛE©‹a\'\"Ù²­Kğø†\Ûôş\ÈFÿ\ÚÖ¹÷İ²„ ò9ô(¢NiœAv´\ÃU½ªk}\ìb˜®4\é<÷:»\ë\ìN·\ÎWQ\0^^	3An¢püN®nş>ú g¡c\èD\ã\Ï\Æs;>\Ñ>Ÿ?“³›¹tÈ¹‡vV\ßL…}¿kfq(ôlûÀL¢ğ %_|WzóIRd®}\ß1QMQBºQl¨ªş\ßU\Ô\ï\ÈÈ¹¾K`ü\00¾N¦½\Î\à¯Œ_Au¼d.µU«3µE«¨\ïj\ëeYV…U\Õ\ã\Ê4W{ho¤+H“ ~ºY\ZõÅš€™\åS‚\à‚‰|9*ƒ·\\ñS˜8±7\Å&x•0\Ö0ö&ğLò±h\r;º\Õ\ì¢_@FıX\é£\çÀ0ú°pVû\ç3\Z©–°‡\É@\ìE\ÓAŸ\à\ÖƒtW\àÁ\Û\æû\\\Å\Ø\Ö\'\è\çõÉ½·+®:([\àk\Õ\ì<‚O‘\ÏX\Ze\í\×u”\Å–\ÃH\Ù\ä\Ä[˜š\Z7%F–M\Ñù»Y\Ó\êUd\Û\â/¯0\Ú\ïNš\å+<>¾— v&Ñ S)\ĞOÏ£	\Öy:k\àğñy\r\á\ë\Û.WH’Î½Ä™\àüqÀı›oÇ¿f^BÓ¹»ı¦\Ü¨kF\ÙA´:ÕŠ\Ú øJqZô\ÚJ‡7\í—\Õ÷q²»‚\é^\Ùq¯\0y#p¿Eñ·=\Z\â+«s¿z?y\Óu?9Ø¿\Û¼û¸\ïş\ŞN¿·H¸|ÿ\ÍûN\\®+a ÑŸyóö\İ £*y\Z‰”Ÿ\éõşJš\Õ-\Ö\n-i2KcPÃ³u	uù¬]\Úú«ö¦xB&’\Ğ\êNŒ$\r%¾\ãÛ™\ãw;´x9kaŠ˜\Ù\ÚgmsO\È	\Èù\ÃÏ²¦qho`¼™À£U:ö»q\èºEtq\æÆ‹X!øs„ø„ú‡u I†tÿ’ûÑ©º†N#Á]§ Øœy…ğ*\î`<\åXƒ-\Í\ío\Ñ9pc|\â^½\á}ŒœoQ–….¶°?§hpw0:Ç“\ä13tO¢,Lû¹Xc\Ïm¢øÀ\ä6\Z··|-›\Övš¼…`«)š\É\ìµ&T?F[/\ì†j\ÙTjÑ¢U\ÒLU¬¦¤¥\ZÑ¼A+E«Á,\à|…†7s°Ë·—~t8—/tüK<\Ò\àgCe$\r¹^\Zr°Ë—†MTü\à¹\Ø*\é\à–øN\í\å>g»\Ìq˜M-\Ì4§|\Z —\ã$‰/—öÆˆ: d\ÑG&œ\ÕzZYÌ…:\ïD3B\î\á½aqdÿI K\Ür;¤\àR\ç§,\ä}›\ç\Ó\ëğú0…Ö±S|t\'8\Åó)Â-A¬\rc,\Ä\0{=	M/LE9ğB\Ç\Û¿\r®£|\Ë>¤ÁˆUCğ5§pC¬f\ÚÖ¤\Ë\Ø\Ìí’ˆD5Gµ6\"®(.ka>ñşT\É%\r—©ûQO48P}\Û\Î\Ú`@%ú8Pvh¨Á\Êu\é28õh”g«˜¤\él»fö†eDNiDLÂ½\â9y›|ñ¢šJğ¢š]—‹OÄˆ\nŸ]µ\æm|½\î\Âiõ$<\Ùrr \àKâ½Â˜\Í›€9›I\Ò\å\ÏJNjº2\0l³4\åÎ‹J\ÊI”¥\ØÊ’\ä\Ù1hq@\×uı¹Óº¥±\'{L8ı¶\ŞH®x“¡\Ç\ÂX³ğ¼ñ}.\êc‘=O\ïp%|L%GSOr:•GŸg|\rSŞ‡Kl«vùE§Yğ}X0\ä#*ŠAˆ\â\ZS¡üVµ\r@õ‚õµa \Ú%‘¢]\Ä6@…w\"…R:ƒ- \È5ĞŸõZ€ğB\Ş°V-@\É\ã ğ4+oš\Z±#V\ØòV¨,Ù›9°”Œ\n\ëJ?Ê£\Ú)_\îñª£\Ë\ÑX5-š›%\Ô\å0Œ‚D=¿©°\îB\Év	5ZNjº\Õ\Ğô Å´‰$\êÓ™\Ô5 ˆì›H‘¶£ƒ®‡\Ôˆl7Ğ¢Á×§\àHôEo¢¨.•E\ÂtqeuœYjbd1\Z\Ô\âx*ˆTNfp*•š«J2JÇ£\êE%\ÎûQP©œ\Ì\àT\"<\ÚN$‰M¯a\Õ÷\"k$l\å5Me,Vu‡«\"ş\Z)8\\)µ^‚\İ\Î·T\à6Rb­IÔ¶\ÖúqÌ‚\Æ\Êa¨Í›¶\ÕHiƒ-\äjñóG{q’\â·÷w\0_R¸\ĞLj\Z+¬ƒrHÁúW²´\Ê.øÒ­=¾šÄ© p\Î\ÑT\ì™\äd»²\Ø\×\Â\áô€bşñÁ)¢H\ägA¨¾\rR÷æ‚œÑ€¸*\æáŠ›\à	¼WvI:-X\åg³\\¥o¢¿XÊÊ¥r¹¥’8“\ê\Ş\Å\Êtÿ¢Dc±«ø\Ì:W¥\İ!1ch(EIwu\\\r\ZJ]ª	iÁ`CÊºCÁ+hø·8ºƒ\0.XŒÈ”~õ0C|q}QuG^¨\Ø‹\Õ\ÅÚ°Dd*ôd¹<\Ò\à%Z~\ÔÑˆ\İ\Âd©Œ\Å`CÊ–­­\æ’O\ê\Øj ­ºä´¡ó\Ë\ß\Û\è\à\n4,º|\Ù$Ÿk°\Ú\'/z^{e¸‰\î_”,F\Z\éC¥a¤‘:/Ö—Æ¦Î¿¿³şÒ‰V—\êB£\Ë5 1Q”xL	D	\\†ôÕ¯¥T?¢j…%¢\ÇTt‡\ÇFG¢²5\Z\ë ¸ºXc¢ƒ 1[]¡¾Jª/šš s\Ø\r‘©\ê³\nmDC«\n\ç\Ú]\Ë+Yf7R\\\Ó6A¡ƒ±°\èš\î\ËC4¬²l9û\\y\İ1\Ğ&\'¿\Ó\é²Ã©zglV\×T¼Í©¸”m‚Ç¼f,«¦\Ç\Ñjxe \ZTY¦¥ˆ£\Ã\0)Š´„U!«¢Z\ÆÁa\ä«,œG¥“H64R¤\ÃMu$–™\êòyU7µ†\ßW©ªÅ¨&\Õ%‰^bI\è+§\æ\î#i( ¸\Ã@nJÍ´>\â…Õ°kU½@1_/5ˆq‰ò	8³õ+…Ï¶~ª·&k\Æ?ö\Ñ_²V\ãHY	„7\Ò\"\á	P3\×0>$\ÖcY5‡“;Ä¡ÁC\0F\Õ\éÑ‘<\Ø\ã º¦;D.\\\r’«\ÒÀ’\ÊÁ IWÁSPT\ŞBÃ‚\Âp0F„P«\áŠ9gP¬6€-Á™¯\ëU³ƒ,©\Ös=\Å}º.]Œ®—<R\Z~³.döÛ­0\ÆQş\ÃlöTT\Æñ«‹5a‘¸0R¾H¦R>;\ë\ËT\Ås\Ü~L¥€¡\ÖCLXV\r5\ÆBPÃ¼¡cpÇ¤\êX	jxz¬;*ƒ\Ïø&\Õè¤¤ú]=>#¿º¤\å^‚Ml«$\ã‘}ù´ş\Õ\ß\Ãõ{ù¿\'¾±V/[\\‚\Ğ\ÛÀ$-d\Øo÷şÂ¥]N\n\ĞU’¸\ÌS‰¦< \ì‚M}\Ó\ÃTmd£@L–pÓ\ÂmñK\rm€|š&\ëhŠ\Ñ9+ºJBu.i“):˜)>Ù’1.L–#S(u#c<ê¤ó±\ì)Õ³ec!\ËO>Jÿ?¦\Ë&&G|\Íf.|~\n\Ã$­\àË%)z1ù\Ì\Ü\ÒÁ²}\î{\×n`±P½$z¶b±´ƒ\Ãl‚˜ù\ÍIb7#Œ¤iİŒù›\ÏÚ–£$|\Ä~t\Ã\ã‘ı¯¼\×\ë\âŸ_«¯¬\ë)\Ök\ë\ßCd{3‰,™›‹;\Íc\ß \Í\æ\å\í\×ıS»›2b\æ¶~ \Ä\Äl\æû‘$/‹	rY\×\æ\ß\×\ØøŒ\æPÄ”h¦°ØŒgCo+Ò°{\ÏuO‘\ä\æ26)\Ä\Ô[]•Õµ—ºc“v™N„\É\É\ÕC¾/6£–±úJ\Ç2ù°6~ôU˜˜kv­*\Íue´½™¥–š\\›„ˆ\Ë\ïA,F\Ò\í‘y©\Ú&ôx\Òø¿¼ø•u‘|½_3Tq‹VK>Ÿ`XšËŸ\Ë,4oPwª\"UZteµh\Ïf³	iaStíq¡\ç+PlÊö\Ô\r“‘g$OOû\ÔBJ+N\ÌÍ³\í\ÜE‘?HªSrI3\é{b¢œ@\rC4U#`\Ê8\í\Ûp—\É\Ëó\ãaªLcbyğ©qº\ë×²\çŒ{¨\äË³u…–µ\é\nHŒ\İ2!Á\ÈÀq\Ëû“™zc°\ÍşFÌ¬1\ì9zŒt\Z\Âk‰	ó\\ñ\Írx…’m\n±\Ôå©‹e\ã¦\Ã\è¾ncqp˜¬£Oº•is[¼\ädK\É_QG®•\à3aÚŠ)3U4|+\Õõüe\"\æê— b!\Õ%!ˆ|6a\ZŠ©yMõ\Ô_\ã\\pù\É&\Æl$0µ‚\Ù&L)15³©>X8³i%X¯Íµ\Î\Ìi·\Ğ\Ù\Ó@ˆ!qùe%\ßkğNIsz‡\âsŠ#Û½\Ã\Öx\á\Ç6D‰\çG©r<cT5²\ê¬-ğ\Ë¹ø²B½J(\Ñœ\Ê!@UJ¡“N´D»6\Â@t¥l †h÷ª¼Mi\'¤C•’\Ôü\0¬•/Œ\ÂVË†*2\Ş\Ê\Ã]««UrÀº‰zPuœm~`A\ã\n-š‡Õ›+1#\'K\Ú4«ˆN\ß46±*\Z\Ç&mš\ÇV\Ä|Ÿ&­† ü¸8Û¢\Z—P=o\äñ’4£;\Â\Êsº«:\Í\Í\â2bH\ã\éË’Ø´\Ø=Š\ÏH¥\ép–œƒ™IK>6WAy%\'¼„(Œ^T|o<<Q\Æ\Êo1I†|\â§\Ã\È\Ö\ÎB|3^ü:…‰·­A\"˜\ÈRc¬\ìª\ÍE¸‰JcŸÃ¨lÂ¿Š„)pñ+¹8õ6ÀIQ5¾Ï“±\ç×‹Øº½ƒ\îEx¥»,ES†Á\Ï\\\Îa§¡iü<i‹ó\áõÿJ†˜B\ÓÃ	®ÃŸ3\Ïw+¼\Ï%÷W\n\Ø!w\Îx-S|÷¼}ª ]	Ñ—U€ù*\'\n¿dô°\ä:\\ƒh‚b¿pœ§ú¶R¤}!X²z`ƒ !0\êş\è\'\âa7xüñÿ[ó\n×¢³\0\0','6.1.3-40302');
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
