-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 07 Jan 2023 pada 15.37
-- Versi server: 10.4.24-MariaDB
-- Versi PHP: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `rentalvcd`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `kategori`
--

CREATE TABLE `kategori` (
  `No` int(10) NOT NULL,
  `Kategori_Film` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `kategori`
--

INSERT INTO `kategori` (`No`, `Kategori_Film`) VALUES
(1, 'DRAMA'),
(3, 'COMEDY'),
(5, 'HOROR');

-- --------------------------------------------------------

--
-- Struktur dari tabel `pelanggan`
--

CREATE TABLE `pelanggan` (
  `Id_Pelanggan` varchar(10) NOT NULL,
  `Nama` varchar(50) NOT NULL,
  `Alamat` varchar(100) NOT NULL,
  `No_Hp` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `pelanggan`
--

INSERT INTO `pelanggan` (`Id_Pelanggan`, `Nama`, `Alamat`, `No_Hp`) VALUES
('1', 'SATRIA', 'prembun', '123456789'),
('2', 'KOESWARA', 'selang', '0987654321'),
('3', 'TIO K', 'bumirejo kebumen', '09812345678');

-- --------------------------------------------------------

--
-- Struktur dari tabel `pengguna`
--

CREATE TABLE `pengguna` (
  `Id_User` varchar(10) NOT NULL,
  `Nama_User` varchar(50) NOT NULL,
  `Status_User` varchar(15) NOT NULL,
  `Password` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `pengguna`
--

INSERT INTO `pengguna` (`Id_User`, `Nama_User`, `Status_User`, `Password`) VALUES
('7', 'admin', 'Admin', 'admin');

-- --------------------------------------------------------

--
-- Struktur dari tabel `type`
--

CREATE TABLE `type` (
  `No` int(10) NOT NULL,
  `Type_Film` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `type`
--

INSERT INTO `type` (`No`, `Type_Film`) VALUES
(1, 'ACTION'),
(2, 'ANIMASI'),
(3, 'COMEDY'),
(5, 'FIKSI');

-- --------------------------------------------------------

--
-- Struktur dari tabel `vcd`
--

CREATE TABLE `vcd` (
  `Kode` int(12) NOT NULL,
  `Judul_Film` varchar(100) NOT NULL,
  `Negara` varchar(50) NOT NULL,
  `Type_Film` varchar(50) NOT NULL,
  `Kategori_Film` varchar(50) NOT NULL,
  `Stock` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `vcd`
--

INSERT INTO `vcd` (`Kode`, `Judul_Film`, `Negara`, `Type_Film`, `Kategori_Film`, `Stock`) VALUES
(1, 'AVATAR 2022\r\n', 'AMERIKA SERIKAT', 'ANIMASI', 'DRAMA', '5'),
(2222, 'KKN di DESA PENARI\r\n', 'INDONESIA', 'FIKSI', 'HOROR', '5');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `kategori`
--
ALTER TABLE `kategori`
  ADD PRIMARY KEY (`No`);

--
-- Indeks untuk tabel `pelanggan`
--
ALTER TABLE `pelanggan`
  ADD PRIMARY KEY (`Id_Pelanggan`);

--
-- Indeks untuk tabel `pengguna`
--
ALTER TABLE `pengguna`
  ADD PRIMARY KEY (`Id_User`);

--
-- Indeks untuk tabel `type`
--
ALTER TABLE `type`
  ADD PRIMARY KEY (`No`);

--
-- Indeks untuk tabel `vcd`
--
ALTER TABLE `vcd`
  ADD PRIMARY KEY (`Kode`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `kategori`
--
ALTER TABLE `kategori`
  MODIFY `No` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT untuk tabel `type`
--
ALTER TABLE `type`
  MODIFY `No` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
