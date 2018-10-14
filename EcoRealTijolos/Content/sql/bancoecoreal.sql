CREATE TABLE `tbl_cliente` (
  `cli_id` int(11) NOT NULL AUTO_INCREMENT,
  `cli_nome` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `cli_cpf` varchar(14) COLLATE utf8_unicode_ci NOT NULL,
  `cli_telefone` varchar(13) COLLATE utf8_unicode_ci NOT NULL,
  `cli_email` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `cli_endereco` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`cli_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

CREATE TABLE `tbl_funcionario` (
  `fun_id` int(11) NOT NULL AUTO_INCREMENT,
  `fun_nome` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `fun_cpf` varchar(14) COLLATE utf8_unicode_ci NOT NULL,
  `fun_telefone` varchar(13) COLLATE utf8_unicode_ci NOT NULL,
  `fun_dtNasc` date NOT NULL,
  `fun_endereco` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `fun_email` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`fun_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

CREATE TABLE `tbl_fornecedor` (
  `for_id` int(11) NOT NULL,
  `for_nome` varchar(45) NOT NULL,
  `telefone` varchar(13) NOT NULL,
  `email` varchar(55) DEFAULT NULL,
  PRIMARY KEY (`for_id`)
);

CREATE TABLE `tbl_materia` (
  `mat_id` int(11) NOT NULL AUTO_INCREMENT,
  `mat_nome` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `mat_quantidade` int(11) NOT NULL,
  PRIMARY KEY (`mat_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

CREATE TABLE `tbl_pedido` (
  `ped_id` int(11) NOT NULL AUTO_INCREMENT,
  `ped_data` datetime NOT NULL,
  `ped_idCliente` int(11) NOT NULL,
  `ped_endereco` varchar(445) COLLATE utf8_unicode_ci NOT NULL,
  `ped_obs` text COLLATE utf8_unicode_ci,
  PRIMARY KEY (`ped_id`),
  KEY `tbl_pedido_ibfk_1` (`ped_idCliente`),
  CONSTRAINT `tbl_pedido_ibfk_1` FOREIGN KEY (`ped_idCliente`) REFERENCES `tbl_cliente` (`cli_id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

CREATE TABLE `tbl_produto` (
  `prod_id` int(11) NOT NULL AUTO_INCREMENT,
  `prod_nome` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `prod_quantTotal` int(11) NOT NULL,
  `prod_valorUnitario` decimal(6,2) NOT NULL,
  PRIMARY KEY (`prod_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

CREATE TABLE `tbl_pedidoproduto` (
  `pedpro_id` int(11) NOT NULL AUTO_INCREMENT,
  `ped_id` int(11) NOT NULL,
  `prod_id` int(11) NOT NULL,
  `pedpro_quantidade` int(11) NOT NULL,
  `pedprod_subtotal` decimal(6,2) NOT NULL,
  PRIMARY KEY (`pedpro_id`),
  KEY `tbl_pedido_ibfk_1` (`pedpro_id`),
  KEY `ped_id` (`ped_id`),
  KEY `prod_id` (`prod_id`),
  CONSTRAINT `ped_id` FOREIGN KEY (`ped_id`) REFERENCES `tbl_pedido` (`ped_id`),
  CONSTRAINT `prod_id` FOREIGN KEY (`prod_id`) REFERENCES `tbl_produto` (`prod_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;


