﻿namespace MiHoYoAssets.Formats
{
    public class ZZZ : Format
    {
        private const string Signature = "UnityFS";

        private static readonly byte[] ExpansionKey = new byte[] { 0x2F, 0xE0, 0x89, 0x14, 0xE8, 0x23, 0x4E, 0xE6, 0x91, 0x6D, 0xED, 0xED, 0x86, 0x62, 0x85, 0x1C, 0xD7, 0x0F, 0x87, 0x2B, 0x64, 0xF3, 0xE0, 0x40, 0xDC, 0x27, 0x17, 0x4C, 0xC2, 0x73, 0x4E, 0x6D, 0x00, 0xE7, 0x91, 0x04, 0x4E, 0x14, 0x60, 0x8D, 0x1A, 0xE8, 0x36, 0x4F, 0xCF, 0xFB, 0x50, 0xA7, 0x5D, 0x89, 0x51, 0x7B, 0xBB, 0xEB, 0x4F, 0x1E, 0x56, 0xA0, 0xB0, 0x1F, 0x48, 0x67, 0x86, 0x21, 0x31, 0xF8, 0xA2, 0xB5, 0xED, 0x90, 0xA4, 0x46, 0xF1, 0x4E, 0x36, 0x38, 0x63, 0x03, 0xA9, 0x8C, 0x05, 0xD3, 0x2B, 0x17, 0xB2, 0x18, 0x93, 0x34, 0xE0, 0xAA, 0x63, 0x2E, 0x39, 0x99, 0x7D, 0x08, 0x33, 0x0C, 0x3F, 0xB0, 0x07, 0xEE, 0xD2, 0xB6, 0x8E, 0x0A, 0xB4, 0x3D, 0xA6, 0xBF, 0x77, 0xAF, 0xBE, 0x17, 0x83, 0xC0, 0x83, 0x2A, 0x57, 0x83, 0xB2, 0xA8, 0xF7, 0xA3, 0xDE, 0xE6, 0x58, 0x4C, 0xA5, 0x33, 0xF1, 0xE0, 0x9B, 0x3D, 0x7B, 0xC7, 0x26, 0x0B, 0x0E, 0x87, 0xAA, 0x10, 0xB8, 0x5B, 0xCD, 0x9D, 0x01, 0x0B, 0x64, 0x92, 0xA8, 0xE4, 0xDE, 0x76, 0xA8, 0xE3, 0xAD, 0xA2, 0xC6, 0xB9, 0x79, 0xBC, 0xEC, 0xF7, 0x37, 0xCF, 0x6C, 0x3D, 0x0D, 0x68, 0xB1, 0x1E, 0xFC, 0x38, 0x43, 0x85 };
        private static readonly byte[] Key = new byte[] { 0xA1, 0x55, 0x38, 0x57, 0xD0, 0xFA, 0x09, 0xEC, 0xB6, 0x74, 0x76, 0xC7, 0x60, 0x0A, 0xF1, 0x6C, 0x4C, 0x45, 0xDC, 0x03, 0x80, 0x18, 0x94, 0xDB, 0x75, 0x2E, 0x35, 0xBF, 0x74, 0x29, 0xAE, 0x2D, 0xFA, 0x37, 0x1A, 0x83, 0x05, 0xAB, 0x2A, 0x47, 0xB8, 0x4D, 0x88, 0xBF, 0xD3, 0x31, 0x96, 0x53, 0xCB, 0xA9, 0x81, 0xD4, 0xAF, 0x3D, 0xE3, 0xBA, 0xC7, 0x84, 0x23, 0xD2, 0xEC, 0xB2, 0xD7, 0x02, 0x4F, 0xC2, 0x45, 0xF4, 0x53, 0x56, 0x6E, 0xD6, 0xA6, 0xE8, 0x8C, 0x1D, 0xAE, 0x22, 0x0B, 0x75, 0xE6, 0xE7, 0x82, 0x88, 0x06, 0x61, 0xB8, 0x4B, 0xA3, 0xCE, 0x52, 0x02, 0x5C, 0x20, 0xE0, 0x19, 0x03, 0x08, 0xD2, 0x4B, 0x84, 0xF4, 0x11, 0x41, 0xC9, 0xF7, 0xE0, 0x0D, 0x86, 0x09, 0x45, 0xF0, 0xF2, 0x31, 0xE2, 0x88, 0xC6, 0xE3, 0x3E, 0x40, 0x17, 0x3A, 0xC0, 0x0C, 0x81, 0x8A, 0x80, 0xC3, 0x76, 0xA4, 0x85, 0x2D, 0x55, 0xB9, 0x6D, 0x32, 0x31, 0xA3, 0xBB, 0xEC, 0xB4, 0x50, 0xA5, 0x7E, 0xA4, 0x87, 0xEA, 0x5B, 0x9A, 0x67, 0x6C, 0xE0, 0x53, 0x4D, 0x58, 0x29, 0x84, 0x99, 0x83, 0xB0, 0x04, 0x0A, 0x43, 0x9C, 0xF6, 0xB8, 0x57, 0x5C, 0x68, 0x34, 0x60, 0x36, 0xE6, 0x73, 0x8C, 0xA8, 0x00, 0xA7, 0x64, 0x91, 0xBE, 0xBE, 0x6F, 0x1E, 0x7B, 0x57, 0x41, 0xB8, 0xAF, 0x13, 0x29, 0x87, 0x27, 0xE1, 0x64, 0xB5, 0x46, 0xA6, 0xFA, 0x9E, 0x71, 0x15, 0x85, 0xB5, 0x0D, 0x00, 0x0D, 0xA9, 0x41, 0xFE, 0x1F, 0x05, 0xD8, 0xF2, 0xFA, 0x74, 0x9F, 0x3D, 0xE8, 0x61, 0xA5, 0x06, 0x0A, 0x8A, 0xC4, 0xF6, 0x64, 0x4F, 0xCE, 0x25, 0x72, 0x81, 0x34, 0xFA, 0x81, 0x0C, 0xC9, 0xC6, 0xF4, 0xA1, 0x28, 0x4F, 0x14, 0xD3, 0x0E, 0xE1, 0xDB, 0x86, 0xE1, 0x1E, 0x3A, 0xA9, 0xB3, 0xF1, 0x17, 0xDE, 0x6E, 0x9D, 0x5B, 0x08, 0x79, 0xE0, 0x93, 0x02, 0xF0, 0xAD, 0x2B, 0x21, 0x68, 0x7A, 0xC7, 0xFE, 0xEB, 0x1E, 0xD9, 0x8B, 0x2C, 0x85, 0xCE, 0x69, 0xDB, 0xDE, 0x6D, 0x30, 0x4B, 0x0E, 0x74, 0x9C, 0xC8, 0x2D, 0x8A, 0xE5, 0x0C, 0x10, 0x6B, 0xF1, 0x11, 0x41, 0x14, 0x69, 0xF9, 0x5F, 0x68, 0xB8, 0x6A, 0xD9, 0x0E, 0x03, 0x72, 0x9C, 0x5F, 0x35, 0x2E, 0xB0, 0x88, 0x66, 0x17, 0xB3, 0xE6, 0xCB, 0xF2, 0xF2, 0xC3, 0xE4, 0x80, 0x4F, 0x6D, 0x07, 0x15, 0x85, 0x31, 0x85, 0x78, 0xC2, 0x60, 0x2E, 0xB5, 0x7A, 0x16, 0xEE, 0x61, 0xEB, 0x9B, 0x33, 0x71, 0xBD, 0x19, 0x4A, 0xBA, 0xA9, 0x72, 0xA1, 0xEC, 0x32, 0xFF, 0x27, 0x79, 0x6F, 0x33, 0x2B, 0xC7, 0xC9, 0x88, 0x7B, 0x99, 0x6F, 0x34, 0xA2, 0xD1, 0x25, 0xC6, 0x8D, 0x91, 0xE7, 0xBA, 0x7E, 0xDD, 0x16, 0x7A, 0x3D, 0x39, 0xC3, 0x07, 0x3A, 0xD5, 0xE7, 0x0D, 0x48, 0xEB, 0x28, 0x46, 0xE0, 0xE8, 0x6E, 0x8F, 0xDF, 0xA4, 0x67, 0x82, 0x8E, 0x4E, 0x95, 0xE1, 0xA3, 0x27, 0x1F, 0x54, 0x47, 0x9D, 0x97, 0xA6, 0x21, 0x00, 0x2B, 0x84, 0xBF, 0xB8, 0x3D, 0x39, 0x74, 0x72, 0x22, 0x9B, 0xC2, 0xDB, 0xEE, 0x3A, 0x9C, 0x9B, 0xB2, 0x79, 0x3D, 0xBE, 0xAC, 0xAA, 0x63, 0x81, 0xC5, 0xC6, 0x22, 0x32, 0x70, 0x51, 0xC5, 0x30, 0xE6, 0x3A, 0x6B, 0xF0, 0xCF, 0x35, 0x3D, 0xA0, 0x24, 0xA7, 0xC4, 0x15, 0xA1, 0x78, 0x3B, 0xB1, 0xE0, 0xFE, 0x0C, 0xF5, 0x9B, 0xBD, 0xA1, 0x5B, 0x5F, 0xE8, 0xAF, 0x76, 0xB7, 0x11, 0x75, 0x12, 0xEF, 0x0A, 0xBF, 0xE9, 0xBF, 0xE2, 0x73, 0xED, 0x4A, 0xE5, 0x23, 0x82, 0xA4, 0xD0, 0x1C, 0x59, 0xCF, 0x8B, 0x24, 0xAB, 0xD8, 0x43, 0xFF, 0x30, 0x70, 0xFA, 0xB8, 0x38, 0x24, 0x5A, 0x50, 0x54, 0x13, 0xEB, 0x68, 0xDD, 0x98, 0xCC, 0xCB, 0x36, 0x65, 0x1A, 0x26, 0x8C, 0xB7, 0x7B, 0x3D, 0x5A, 0x75, 0xE2, 0xD3, 0x7F, 0x42, 0x91, 0xC1, 0xBD, 0x72, 0xFF, 0x7E, 0x18, 0xCC, 0x0D, 0x39, 0xE9, 0x2D, 0x7F, 0x46, 0x90, 0xF1, 0xBD, 0x0B, 0x09, 0x5D, 0xD0, 0x0D, 0xEF, 0xAD, 0x93, 0x52, 0xEB, 0x9A, 0x4B, 0x8D, 0x20, 0x27, 0xD8, 0xE1, 0xE6, 0x30, 0xFD, 0xE2, 0x08, 0xF3, 0x91, 0x61, 0x53, 0x55, 0xC8, 0x14, 0xAB, 0x19, 0x19, 0x4F, 0xF4, 0x05, 0xEA, 0xFE, 0x76, 0x48, 0xBA, 0xD2, 0xE6, 0x8B, 0x7A, 0xA2, 0x63, 0xE1, 0x3A, 0x10, 0xE4, 0x48, 0xEB, 0xA9, 0x3C, 0x61, 0x1E, 0x0C, 0x3D, 0x0E, 0x89, 0x2E, 0xCB, 0x83, 0xEC, 0x15, 0x8E, 0x9B, 0x4D, 0x9F, 0xB9, 0x22, 0xA2, 0x63, 0xAA, 0x59, 0x9F, 0x3E, 0x96, 0xEB, 0x4B, 0x4F, 0x71, 0x56, 0x15, 0xF2, 0xED, 0x5E, 0x7E, 0x10, 0x64, 0x66, 0x3C, 0xB8, 0x90, 0x7A, 0x76, 0x6E, 0x2F, 0x6B, 0x43, 0xAB, 0x49, 0x37, 0xBF, 0x42, 0x93, 0x4C, 0x61, 0x63, 0xF9, 0x92, 0x48, 0x2D, 0xEF, 0x73, 0x86, 0xCC, 0xAC, 0x44, 0x56, 0xC5, 0x53, 0x32, 0x17, 0x7E, 0x6F, 0x03, 0x0A, 0x6A, 0x7A, 0x68, 0x32, 0x83, 0xE8, 0xDD, 0x64, 0x96, 0x2C, 0x58, 0xB0, 0x12, 0xAC, 0x92, 0xCD, 0xFA, 0x86, 0x26, 0x69, 0xE3, 0xDF, 0xD8, 0xE9, 0x5A, 0x5C, 0xEF, 0x0E, 0xBE, 0x77, 0x22, 0xB5, 0xFE, 0xCA, 0x48, 0x67, 0x44, 0xD8, 0xBE, 0x44, 0xF2, 0x92, 0x9C, 0x60, 0x40, 0xFD, 0xE6, 0xC7, 0x80, 0x09, 0x6A, 0xCD, 0x16, 0x2E, 0xF7, 0x4B, 0x6A, 0x72, 0xE1, 0x96, 0x9B, 0xE4, 0x4E, 0x99, 0xD8, 0x7E, 0x37, 0x30, 0x6F, 0xB4, 0x07, 0x63, 0x1A, 0x2F, 0x9F, 0x29, 0xB6, 0x96, 0x08, 0x3A, 0x4C, 0x88, 0x97, 0x8B, 0x83, 0x9A, 0x0F, 0xF7, 0x0B, 0xCD, 0xF5, 0x69, 0x17, 0x69, 0x23, 0xC0, 0x50, 0x56, 0xC7, 0xA7, 0x66, 0x85, 0x68, 0x37, 0x32, 0xAE, 0x3A, 0x70, 0xB9, 0x80, 0xEF, 0x3C, 0x28, 0xF9, 0xFF, 0xC4, 0x17, 0xDA, 0x61, 0xB2, 0x35, 0x5D, 0xBE, 0x87, 0x7C, 0x0B, 0x9F, 0x9E, 0x8A, 0x26, 0x88, 0xA0, 0xB9, 0x2B, 0x90, 0x5E, 0x69, 0x50, 0xFE, 0x16, 0x78, 0x96, 0x12, 0xD8, 0xFE, 0x2B, 0xEA, 0xA1, 0xB3, 0x89, 0x20, 0x1F, 0xB2, 0x59, 0x3A, 0x6A, 0x25, 0x2E, 0xA5, 0xA7, 0x6B, 0x93, 0x5C, 0xC7, 0x91, 0x89, 0xCF, 0x99, 0xEC, 0x5A, 0xAF, 0xCB, 0x8D, 0xC6, 0x79, 0x75, 0x79, 0x32, 0x8A, 0xE0, 0x9A, 0x04, 0xCB, 0xB0, 0x57, 0xB8, 0x75, 0x81, 0xFB, 0x65, 0x1B, 0xFC, 0xB2, 0xA0, 0x9B, 0xCE, 0xD7, 0x5D, 0x1D, 0x06, 0xDB, 0x6C, 0x46, 0x55, 0x7C, 0xBC, 0x45, 0x15, 0x2D, 0xBF, 0xC8, 0x0D, 0xB7, 0x02, 0x33, 0x54, 0x16, 0x14, 0xE4, 0xE3, 0xE1, 0xDF, 0x86, 0x80, 0x7F, 0x4C, 0xE8, 0x8D, 0xA3, 0x97, 0x99, 0xBB, 0x2E, 0x7A, 0x69, 0x60, 0x12, 0x58, 0x71, 0xF4, 0x50, 0xD1, 0xB2, 0xB0, 0x2E, 0x63, 0x29, 0x3A, 0x63, 0x57, 0x09, 0x99, 0x1A, 0x98, 0x39, 0x54, 0x65, 0x94, 0x06, 0xD3, 0xC3, 0x31, 0x99, 0x04, 0xD8, 0xAB, 0x5A, 0x3F, 0xA4, 0xBB, 0xE2, 0x6E, 0x79, 0x70, 0x4D, 0x7A, 0x87, 0x1D, 0x70, 0x55, 0xB0, 0xA6, 0x65, 0x20, 0x44, 0x54, 0x8D, 0x14, 0x33, 0x78, 0x4D, 0x24, 0x0A, 0x67, 0xBB, 0xE9, 0x3E, 0xE7, 0xCA, 0x5E, 0x98, 0x26, 0x49, 0x11, 0x9F, 0xE0, 0x0B, 0xAB, 0x03, 0xD0, 0x0C, 0xD3, 0x38, 0xCA, 0xA0, 0xEF, 0xD9, 0x59, 0xAA, 0x1F, 0xA0, 0x72, 0x8C, 0xC9, 0xBA, 0x99, 0x9D, 0x6F, 0x6B, 0x42, 0x79, 0x3A, 0x9F, 0x3B, 0xBB, 0x9D, 0x22, 0x88, 0xD5, 0x01, 0x93, 0x2F, 0xC4, 0x23, 0x16, 0xD0, 0xA6, 0x35, 0xA3 };
        private static readonly byte[] ConstKey = new byte[] { 0xA1, 0xF2, 0x7E, 0xB3, 0x5E, 0xDC, 0x88, 0xC7, 0xB6, 0x6C, 0xD8, 0x76, 0xD6, 0x7B, 0xB2, 0x69 };

        public ZZZ()
        {
            Name = "ZZZ";
            DisplayName = "Zenless Zone Zero - CB1";
            Pattern = ("*.bundle", "");
            Extension = ("", "");
        }

        protected override (string, string)[] CollectPaths(string input, string output, bool isEncrypt)
        {
            if (File.Exists(input))
            {
                var extension = isEncrypt ? Extension.Item2 : Extension.Item1;
                var fileName = $"{Path.GetFileNameWithoutExtension(input)}{extension}";
                return new (string, string)[] { (input, Path.Combine(output, fileName)) };
            }
            var files = Directory.GetFiles(input, isEncrypt ? Pattern.Item2 : Pattern.Item1, SearchOption.AllDirectories);
            var paths = new List<(string, string)>();
            foreach (var file in files)
            {
                var relativePath = Path.GetRelativePath(input, file);
                relativePath = isEncrypt ? Path.ChangeExtension(relativePath, Extension.Item2) : Path.Combine(Path.GetDirectoryName(relativePath), Path.GetFileNameWithoutExtension(relativePath));
                var outPath = Path.Combine(output, relativePath);
                paths.Add((file, outPath));
            }
            return paths.ToArray();
        }

        protected override void Decrypt(string input, string output)
        {
            var reader = new EndianReader(input, 0, EndianType.BigEndian);
            var signature = reader.ReadStringToNull();
            if (signature != Signature)
            {
                throw new InvalidOperationException($"Expected signature UnityFS, got {signature} instead !!");
            }

            var version = reader.ReadUInt32();
            var unityVersion = reader.ReadStringToNull();
            var unityRevision = reader.ReadStringToNull();
            var header = new Bundle.Header()
            {
                Size = reader.ReadInt64(),
                CompressedBlocksInfoSize = reader.ReadInt32(),
                UncompressedBlocksInfoSize = reader.ReadInt32(),
                Flags = reader.ReadInt32(),
            };
            reader.Align(0x10);
            var bundle = new Bundle(header, true, ExpansionKey, Key, ConstKey);
            bundle.Process(ref reader, output);
        }

        protected override void Encrypt(string input, string output)
        {
            throw new NotImplementedException();
        }
    }
}
