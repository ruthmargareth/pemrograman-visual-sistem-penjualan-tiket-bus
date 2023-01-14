-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               10.4.22-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win64
-- HeidiSQL Version:             11.3.0.6295
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for formbus
CREATE DATABASE IF NOT EXISTS `formbus` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `formbus`;

-- Dumping structure for table formbus.jenisbus
CREATE TABLE IF NOT EXISTS `jenisbus` (
  `id_bus` int(11) NOT NULL AUTO_INCREMENT,
  `nama_bus` varchar(255) NOT NULL DEFAULT '0',
  `kapasitas_bus` int(11) NOT NULL,
  `jenis_bus` varchar(255) NOT NULL DEFAULT '0',
  `tahun_pembuatan` year(4) NOT NULL,
  PRIMARY KEY (`id_bus`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=47 DEFAULT CHARSET=utf8mb4;

-- Dumping data for table formbus.jenisbus: ~3 rows (approximately)
/*!40000 ALTER TABLE `jenisbus` DISABLE KEYS */;
INSERT INTO `jenisbus` (`id_bus`, `nama_bus`, `kapasitas_bus`, `jenis_bus`, `tahun_pembuatan`) VALUES
	(1, 'pariwisata', 10, 'Normal Deck', '2019'),
	(9, 'pariwisata', 100, 'Ultra High Deck (UHD)', '2019'),
	(45, 'pariwisata', 50, 'Normal Deck', '2020');
/*!40000 ALTER TABLE `jenisbus` ENABLE KEYS */;

-- Dumping structure for table formbus.penumpang
CREATE TABLE IF NOT EXISTS `penumpang` (
  `NIK` int(5) NOT NULL,
  `nama_penumpang` varchar(255) NOT NULL DEFAULT '0',
  `alamat_penumpang` longtext NOT NULL,
  `jenis_kelamin` varchar(50) NOT NULL DEFAULT '0',
  PRIMARY KEY (`NIK`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table formbus.penumpang: ~3 rows (approximately)
/*!40000 ALTER TABLE `penumpang` DISABLE KEYS */;
INSERT INTO `penumpang` (`NIK`, `nama_penumpang`, `alamat_penumpang`, `jenis_kelamin`) VALUES
	(12345, 'ADNAN', 'DI RUMAH', 'Laki laki'),
	(22222, 'IZZA', 'DIRUMAH', 'Laki laki'),
	(33333, 'RUTH MARGARETH', 'BEKASI', 'Perempuan');
/*!40000 ALTER TABLE `penumpang` ENABLE KEYS */;

-- Dumping structure for table formbus.rute
CREATE TABLE IF NOT EXISTS `rute` (
  `id_rute` int(11) NOT NULL AUTO_INCREMENT,
  `asal_rute` varchar(255) NOT NULL DEFAULT '0',
  `destinasi_rute` varchar(255) NOT NULL DEFAULT '0',
  `tarif_rute` varchar(255) NOT NULL DEFAULT '0',
  `jadwal_keberangkatan` time NOT NULL,
  `jadwal_kedatangan` time NOT NULL,
  PRIMARY KEY (`id_rute`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4;

-- Dumping data for table formbus.rute: ~4 rows (approximately)
/*!40000 ALTER TABLE `rute` DISABLE KEYS */;
INSERT INTO `rute` (`id_rute`, `asal_rute`, `destinasi_rute`, `tarif_rute`, `jadwal_keberangkatan`, `jadwal_kedatangan`) VALUES
	(1, 'JAKARTA', 'BANDUNG', 'Rp.125000', '10:25:43', '10:25:43'),
	(2, 'jakarta', 'bali', 'Rp.125000', '22:10:00', '22:05:00'),
	(6, 'DEPOK', 'JAKARTA', 'Rp.50000', '18:24:17', '18:24:17'),
	(14, 'bekasi', 'depok', 'Rp.100000', '09:47:39', '08:47:39');
/*!40000 ALTER TABLE `rute` ENABLE KEYS */;

-- Dumping structure for table formbus.tiket
CREATE TABLE IF NOT EXISTS `tiket` (
  `id_bus` int(11) NOT NULL,
  `id_rute` int(11) NOT NULL,
  `NIK` int(11) NOT NULL,
  `nama_penumpang` varchar(255) NOT NULL DEFAULT '',
  `tanggal` date NOT NULL,
  `jadwal_keberangkatan` time NOT NULL,
  `jadwal_kedatangan` time NOT NULL,
  `tarif_rute` varchar(255) NOT NULL,
  KEY `id_bus` (`id_bus`),
  KEY `id_rute` (`id_rute`),
  KEY `NIK` (`NIK`),
  CONSTRAINT `FK_NIK` FOREIGN KEY (`NIK`) REFERENCES `penumpang` (`NIK`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_bus` FOREIGN KEY (`id_bus`) REFERENCES `jenisbus` (`id_bus`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_rute` FOREIGN KEY (`id_rute`) REFERENCES `rute` (`id_rute`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table formbus.tiket: ~0 rows (approximately)
/*!40000 ALTER TABLE `tiket` DISABLE KEYS */;
/*!40000 ALTER TABLE `tiket` ENABLE KEYS */;

-- Dumping structure for table formbus.users
CREATE TABLE IF NOT EXISTS `users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(255) DEFAULT '',
  `email` varchar(255) DEFAULT '',
  `password` varchar(255) DEFAULT '',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4;

-- Dumping data for table formbus.users: ~2 rows (approximately)
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` (`id`, `username`, `email`, `password`) VALUES
	(1, 'valdez', 'ruthvladez@gmail,com', '827ccb0eea8a706c4c34a16891f84e7b '),
	(2, 'valdez', 'ruthvaldez@gmail.com', '827ccb0eea8a706c4c34a16891f84e7b '),
	(3, 'ruth', 'ruthmargareth@gmail.com', 'def7924e3199be5e18060bb3e1d547a7 '),
	(4, 'adnan', 'adnan@gmail.com', '81dc9bdb52d04dc20036dbd8313ed055 ');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
