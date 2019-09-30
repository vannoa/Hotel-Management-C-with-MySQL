-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Sep 30, 2019 at 04:12 PM
-- Server version: 5.7.26
-- PHP Version: 5.6.40

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `manajemen_hotel`
--

-- --------------------------------------------------------

--
-- Table structure for table `tb_client`
--

DROP TABLE IF EXISTS `tb_client`;
CREATE TABLE IF NOT EXISTS `tb_client` (
  `no_identity` varchar(30) NOT NULL,
  `firstname` varchar(50) NOT NULL,
  `lastname` varchar(50) NOT NULL,
  `phone` varchar(20) NOT NULL,
  `country` varchar(30) NOT NULL,
  PRIMARY KEY (`no_identity`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tb_reservation`
--

DROP TABLE IF EXISTS `tb_reservation`;
CREATE TABLE IF NOT EXISTS `tb_reservation` (
  `no_reservation` varchar(20) NOT NULL,
  `client_id` varchar(30) NOT NULL,
  `room_type` varchar(30) NOT NULL,
  `room_price` int(11) NOT NULL,
  `no_room` int(11) NOT NULL,
  `booking_date` date NOT NULL,
  `date_in` date NOT NULL,
  `date_out` date NOT NULL,
  `checkin` datetime DEFAULT NULL,
  `checkout` datetime DEFAULT NULL,
  `billing` int(11) NOT NULL,
  `cara_bayar` varchar(30) NOT NULL,
  `pembayaran` int(11) DEFAULT NULL,
  `kembalian` int(11) DEFAULT NULL,
  `keterangan` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`no_reservation`),
  KEY `fkclientid` (`client_id`),
  KEY `fkroomtype` (`room_type`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tb_room`
--

DROP TABLE IF EXISTS `tb_room`;
CREATE TABLE IF NOT EXISTS `tb_room` (
  `room_id` varchar(30) NOT NULL,
  `type_room` varchar(30) NOT NULL,
  `price_room` int(11) NOT NULL,
  PRIMARY KEY (`type_room`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tb_room`
--

INSERT INTO `tb_room` (`room_id`, `type_room`, `price_room`) VALUES
('0007', 'Bisnis', 5000000),
('0009', 'High', 7000000),
('0004', 'King', 6000000),
('0006', 'Low', 2000000),
('0003', 'Luxury', 8000000),
('0008', 'Middle', 3000000),
('0011', 'Normal', 5500000),
('0001', 'President Suite', 12000000),
('0010', 'Private', 9000000),
('0005', 'Standart', 4000000),
('0002', 'Suite', 10000000);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tb_reservation`
--
ALTER TABLE `tb_reservation`
  ADD CONSTRAINT `fkclientid` FOREIGN KEY (`client_id`) REFERENCES `tb_client` (`no_identity`),
  ADD CONSTRAINT `fkroomtype` FOREIGN KEY (`room_type`) REFERENCES `tb_room` (`type_room`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
