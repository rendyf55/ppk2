-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 27, 2019 at 02:04 PM
-- Server version: 10.4.6-MariaDB
-- PHP Version: 7.3.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `seteguk`
--

-- --------------------------------------------------------

--
-- Table structure for table `stgk_bahan_baku`
--

CREATE TABLE `stgk_bahan_baku` (
  `id` int(11) NOT NULL,
  `nama_bahan` varchar(225) NOT NULL,
  `stok` int(11) NOT NULL,
  `satuan` varchar(50) NOT NULL,
  `harga_satuan` decimal(10,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `stgk_bahan_baku`
--

INSERT INTO `stgk_bahan_baku` (`id`, `nama_bahan`, `stok`, `satuan`, `harga_satuan`) VALUES
(1, 'Air', 1, 'galon', '20000'),
(2, 'Gula', 10, 'kg', '15000'),
(3, 'Bubuk Green Tea', 1, 'kg', '198000'),
(4, 'Cup Plastik', 100, 'cups', '600'),
(5, 'Bubuk Espresso', 1, 'kg', '50000'),
(6, 'Ice Cube', 10, 'kg', '15000'),
(7, 'Susu Kental Manis', 1, 'kaleng', '12800'),
(8, 'a', 12, 'kaleng', '12000');

-- --------------------------------------------------------

--
-- Table structure for table `stgk_detail_menu`
--

CREATE TABLE `stgk_detail_menu` (
  `id_detail_menu` int(11) NOT NULL,
  `id_menu` int(11) NOT NULL,
  `id_bahan_baku` int(11) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `satuan` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `stgk_detail_menu`
--

INSERT INTO `stgk_detail_menu` (`id_detail_menu`, `id_menu`, `id_bahan_baku`, `jumlah`, `satuan`) VALUES
(1, 2, 1, 30, 'ml'),
(2, 2, 5, 10, 'gr'),
(3, 1, 4, 1, 'cup'),
(4, 1, 2, 2, 'gr'),
(5, 1, 1, 100, 'ml'),
(6, 2, 4, 1, 'cup'),
(7, 1, 3, 10, 'gr'),
(8, 1, 6, 4, 'pcs');

-- --------------------------------------------------------

--
-- Table structure for table `stgk_menu`
--

CREATE TABLE `stgk_menu` (
  `id_menu` int(11) NOT NULL,
  `nama_menu` varchar(225) NOT NULL,
  `harga` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `stgk_menu`
--

INSERT INTO `stgk_menu` (`id_menu`, `nama_menu`, `harga`) VALUES
(1, 'Green Tea', 13000),
(2, 'Americano', 15000);

-- --------------------------------------------------------

--
-- Table structure for table `stgk_pemesanan`
--

CREATE TABLE `stgk_pemesanan` (
  `id_pemesanan` int(11) NOT NULL,
  `nama_pembeli` varchar(50) NOT NULL,
  `jumlah_orang` int(11) NOT NULL,
  `total_harga` double NOT NULL,
  `tanggal` datetime NOT NULL,
  `status` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `stgk_pemesanan`
--

INSERT INTO `stgk_pemesanan` (`id_pemesanan`, `nama_pembeli`, `jumlah_orang`, `total_harga`, `tanggal`, `status`) VALUES
(4, 'bella', 2, 0, '2019-09-26 00:00:00', '');

-- --------------------------------------------------------

--
-- Table structure for table `stgk_satuan`
--

CREATE TABLE `stgk_satuan` (
  `id_satuan` int(11) NOT NULL,
  `satuan` varchar(50) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `satuan_detail` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `stgk_satuan`
--

INSERT INTO `stgk_satuan` (`id_satuan`, `satuan`, `jumlah`, `satuan_detail`) VALUES
(1, 'kg', 1000, 'gr'),
(2, 'galon', 19, 'liter'),
(3, 'liter', 1000, 'ml'),
(4, 'kaleng', 370, 'ml'),
(5, 'cup', 1, 'cup'),
(6, 'pcs', 1, 'pcs');

-- --------------------------------------------------------

--
-- Table structure for table `stgk_sementara`
--

CREATE TABLE `stgk_sementara` (
  `id` int(11) NOT NULL,
  `id_pembeli` int(11) NOT NULL,
  `kode_pesan` varchar(50) NOT NULL,
  `id_menu` int(11) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `harga` double NOT NULL,
  `total_pesan` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `stgk_sementara`
--

INSERT INTO `stgk_sementara` (`id`, `id_pembeli`, `kode_pesan`, `id_menu`, `jumlah`, `harga`, `total_pesan`) VALUES
(6, 4, 'STGK-01', 1, 3, 13000, 39000),
(7, 4, 'STGK-01', 2, 5, 15000, 75000);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `stgk_bahan_baku`
--
ALTER TABLE `stgk_bahan_baku`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `stgk_detail_menu`
--
ALTER TABLE `stgk_detail_menu`
  ADD PRIMARY KEY (`id_detail_menu`),
  ADD KEY `id_bahan_baku` (`id_bahan_baku`),
  ADD KEY `id_menu` (`id_menu`);

--
-- Indexes for table `stgk_menu`
--
ALTER TABLE `stgk_menu`
  ADD PRIMARY KEY (`id_menu`);

--
-- Indexes for table `stgk_pemesanan`
--
ALTER TABLE `stgk_pemesanan`
  ADD PRIMARY KEY (`id_pemesanan`);

--
-- Indexes for table `stgk_satuan`
--
ALTER TABLE `stgk_satuan`
  ADD PRIMARY KEY (`id_satuan`);

--
-- Indexes for table `stgk_sementara`
--
ALTER TABLE `stgk_sementara`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_menu` (`id_menu`),
  ADD KEY `id_pembeli` (`id_pembeli`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `stgk_bahan_baku`
--
ALTER TABLE `stgk_bahan_baku`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `stgk_detail_menu`
--
ALTER TABLE `stgk_detail_menu`
  MODIFY `id_detail_menu` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `stgk_menu`
--
ALTER TABLE `stgk_menu`
  MODIFY `id_menu` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `stgk_pemesanan`
--
ALTER TABLE `stgk_pemesanan`
  MODIFY `id_pemesanan` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `stgk_satuan`
--
ALTER TABLE `stgk_satuan`
  MODIFY `id_satuan` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `stgk_sementara`
--
ALTER TABLE `stgk_sementara`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `stgk_detail_menu`
--
ALTER TABLE `stgk_detail_menu`
  ADD CONSTRAINT `stgk_detail_menu_ibfk_1` FOREIGN KEY (`id_bahan_baku`) REFERENCES `stgk_bahan_baku` (`id`),
  ADD CONSTRAINT `stgk_detail_menu_ibfk_2` FOREIGN KEY (`id_menu`) REFERENCES `stgk_menu` (`id_menu`);

--
-- Constraints for table `stgk_sementara`
--
ALTER TABLE `stgk_sementara`
  ADD CONSTRAINT `stgk_sementara_ibfk_2` FOREIGN KEY (`id_menu`) REFERENCES `stgk_menu` (`id_menu`),
  ADD CONSTRAINT `stgk_sementara_ibfk_3` FOREIGN KEY (`id_pembeli`) REFERENCES `stgk_pemesanan` (`id_pemesanan`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
