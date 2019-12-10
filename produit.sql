/*
Navicat MySQL Data Transfer

Source Server         : localhost_3306
Source Server Version : 50724
Source Host           : localhost:3306
Source Database       : gestion

Target Server Type    : MYSQL
Target Server Version : 50724
File Encoding         : 65001

Date: 2019-12-10 01:27:26
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for panier
-- ----------------------------
DROP TABLE IF EXISTS `panier`;
CREATE TABLE `panier` (
  `UtilisateurID` int(11) NOT NULL,
  `ProduitID` int(11) NOT NULL,
  `Quantite` int(11) DEFAULT NULL,
  PRIMARY KEY (`UtilisateurID`,`ProduitID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of panier
-- ----------------------------
INSERT INTO `panier` VALUES ('1', '1', '18');
INSERT INTO `panier` VALUES ('1', '2', '16');
INSERT INTO `panier` VALUES ('1', '3', '15');

-- ----------------------------
-- Table structure for produit
-- ----------------------------
DROP TABLE IF EXISTS `produit`;
CREATE TABLE `produit` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Nom` varchar(255) DEFAULT NULL,
  `Prix` int(255) DEFAULT NULL,
  `Quantite` int(255) DEFAULT NULL,
  `Description` varchar(255) DEFAULT NULL,
  `Image` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of produit
-- ----------------------------
INSERT INTO `produit` VALUES ('1', 'Gilles', '100', '1', 'Il est unique', 'yapasdimage');
INSERT INTO `produit` VALUES ('2', 'Fabien', '1', '100', 'inutile', 'etouais');
INSERT INTO `produit` VALUES ('3', 'Femelle', '2', '2000', 'fait de le ménage', 'caca');

-- ----------------------------
-- Table structure for promotion
-- ----------------------------
DROP TABLE IF EXISTS `promotion`;
CREATE TABLE `promotion` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Nom` varchar(255) DEFAULT NULL,
  `Montant` int(11) DEFAULT NULL,
  `Code` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of promotion
-- ----------------------------
INSERT INTO `promotion` VALUES ('1', 'BlackFriday', '20', 'BLACK20');

-- ----------------------------
-- Table structure for utilisateur
-- ----------------------------
DROP TABLE IF EXISTS `utilisateur`;
CREATE TABLE `utilisateur` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Nom` varchar(255) DEFAULT NULL,
  `Prenom` varchar(255) DEFAULT NULL,
  `Mail` varchar(255) DEFAULT NULL,
  `Password` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of utilisateur
-- ----------------------------
INSERT INTO `utilisateur` VALUES ('1', 'Annet', 'Lilian', 'lilian.annet.pro@gmail.com', '2303');
INSERT INTO `utilisateur` VALUES ('2', 'DelTesta', 'Fabien', 'lilian.annet.pro@gmail.com', '2303');
SET FOREIGN_KEY_CHECKS=1;
