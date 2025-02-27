using Microsoft.EntityFrameworkCore;
using TennisSim.Models;

namespace TennisSim.Data
{
    public static class PlayerAttributeSeedData
    {
        public static void SeedPlayerAttributes(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlayerAttribute>().HasData(
                // Iga Świątek (POL)
                new PlayerAttribute { Id = 1, PlayerId = 1, AttributeType = "Backhand", Value = 90 },
                new PlayerAttribute { Id = 2, PlayerId = 1, AttributeType = "Forehand", Value = 95 },
                new PlayerAttribute { Id = 3, PlayerId = 1, AttributeType = "Speed", Value = 93 },
                new PlayerAttribute { Id = 4, PlayerId = 1, AttributeType = "Stamina", Value = 92 },
                new PlayerAttribute { Id = 5, PlayerId = 1, AttributeType = "Mental", Value = 94 },
                new PlayerAttribute { Id = 6, PlayerId = 1, AttributeType = "Volley", Value = 85 },
                new PlayerAttribute { Id = 7, PlayerId = 1, AttributeType = "Return", Value = 90 },

                // Aryna Sabalenka (BLR)
                new PlayerAttribute { Id = 8, PlayerId = 2, AttributeType = "Backhand", Value = 88 },
                new PlayerAttribute { Id = 9, PlayerId = 2, AttributeType = "Forehand", Value = 93 },
                new PlayerAttribute { Id = 10, PlayerId = 2, AttributeType = "Speed", Value = 89 },
                new PlayerAttribute { Id = 11, PlayerId = 2, AttributeType = "Stamina", Value = 90 },
                new PlayerAttribute { Id = 12, PlayerId = 2, AttributeType = "Mental", Value = 91 },
                new PlayerAttribute { Id = 13, PlayerId = 2, AttributeType = "Volley", Value = 88 },
                new PlayerAttribute { Id = 14, PlayerId = 2, AttributeType = "Return", Value = 92 },

                // Cori Gauff (USA)
                new PlayerAttribute { Id = 15, PlayerId = 3, AttributeType = "Backhand", Value = 85 },
                new PlayerAttribute { Id = 16, PlayerId = 3, AttributeType = "Forehand", Value = 90 },
                new PlayerAttribute { Id = 17, PlayerId = 3, AttributeType = "Speed", Value = 94 },
                new PlayerAttribute { Id = 18, PlayerId = 3, AttributeType = "Stamina", Value = 89 },
                new PlayerAttribute { Id = 19, PlayerId = 3, AttributeType = "Mental", Value = 90 },
                new PlayerAttribute { Id = 20, PlayerId = 3, AttributeType = "Volley", Value = 84 },
                new PlayerAttribute { Id = 21, PlayerId = 3, AttributeType = "Return", Value = 87 },

                // Elena Rybakina (KAZ)
                new PlayerAttribute { Id = 22, PlayerId = 4, AttributeType = "Backhand", Value = 90 },
                new PlayerAttribute { Id = 23, PlayerId = 4, AttributeType = "Forehand", Value = 91 },
                new PlayerAttribute { Id = 24, PlayerId = 4, AttributeType = "Speed", Value = 89 },
                new PlayerAttribute { Id = 25, PlayerId = 4, AttributeType = "Stamina", Value = 92 },
                new PlayerAttribute { Id = 26, PlayerId = 4, AttributeType = "Mental", Value = 90 },
                new PlayerAttribute { Id = 27, PlayerId = 4, AttributeType = "Volley", Value = 86 },
                new PlayerAttribute { Id = 28, PlayerId = 4, AttributeType = "Return", Value = 89 },

                // Jessica Pegula (USA)
                new PlayerAttribute { Id = 29, PlayerId = 5, AttributeType = "Backhand", Value = 85 },
                new PlayerAttribute { Id = 30, PlayerId = 5, AttributeType = "Forehand", Value = 88 },
                new PlayerAttribute { Id = 31, PlayerId = 5, AttributeType = "Speed", Value = 87 },
                new PlayerAttribute { Id = 32, PlayerId = 5, AttributeType = "Stamina", Value = 88 },
                new PlayerAttribute { Id = 33, PlayerId = 5, AttributeType = "Mental", Value = 89 },
                new PlayerAttribute { Id = 34, PlayerId = 5, AttributeType = "Volley", Value = 83 },
                new PlayerAttribute { Id = 35, PlayerId = 5, AttributeType = "Return", Value = 85 },

                // Ons Jabeur (TUN)
                new PlayerAttribute { Id = 36, PlayerId = 6, AttributeType = "Backhand", Value = 87 },
                new PlayerAttribute { Id = 37, PlayerId = 6, AttributeType = "Forehand", Value = 89 },
                new PlayerAttribute { Id = 38, PlayerId = 6, AttributeType = "Speed", Value = 85 },
                new PlayerAttribute { Id = 39, PlayerId = 6, AttributeType = "Stamina", Value = 90 },
                new PlayerAttribute { Id = 40, PlayerId = 6, AttributeType = "Mental", Value = 88 },
                new PlayerAttribute { Id = 41, PlayerId = 6, AttributeType = "Volley", Value = 84 },
                new PlayerAttribute { Id = 42, PlayerId = 6, AttributeType = "Return", Value = 85 },

                // Marketa Vondrousova (CZE)
                new PlayerAttribute { Id = 43, PlayerId = 7, AttributeType = "Backhand", Value = 89 },
                new PlayerAttribute { Id = 44, PlayerId = 7, AttributeType = "Forehand", Value = 91 },
                new PlayerAttribute { Id = 45, PlayerId = 7, AttributeType = "Speed", Value = 90 },
                new PlayerAttribute { Id = 46, PlayerId = 7, AttributeType = "Stamina", Value = 91 },
                new PlayerAttribute { Id = 47, PlayerId = 7, AttributeType = "Mental", Value = 93 },
                new PlayerAttribute { Id = 48, PlayerId = 7, AttributeType = "Volley", Value = 87 },
                new PlayerAttribute { Id = 49, PlayerId = 7, AttributeType = "Return", Value = 89 },

                // Karolina Muchova (CZE)
                new PlayerAttribute { Id = 50, PlayerId = 8, AttributeType = "Backhand", Value = 88 },
                new PlayerAttribute { Id = 51, PlayerId = 8, AttributeType = "Forehand", Value = 90 },
                new PlayerAttribute { Id = 52, PlayerId = 8, AttributeType = "Speed", Value = 89 },
                new PlayerAttribute { Id = 53, PlayerId = 8, AttributeType = "Stamina", Value = 90 },
                new PlayerAttribute { Id = 54, PlayerId = 8, AttributeType = "Mental", Value = 91 },
                new PlayerAttribute { Id = 55, PlayerId = 8, AttributeType = "Volley", Value = 85 },
                new PlayerAttribute { Id = 56, PlayerId = 8, AttributeType = "Return", Value = 88 },

// Maria Sakkari (GRC)
new PlayerAttribute { Id = 57, PlayerId = 9, AttributeType = "Backhand", Value = 86 },
new PlayerAttribute { Id = 58, PlayerId = 9, AttributeType = "Forehand", Value = 91 },
new PlayerAttribute { Id = 59, PlayerId = 9, AttributeType = "Speed", Value = 92 },
new PlayerAttribute { Id = 60, PlayerId = 9, AttributeType = "Stamina", Value = 89 },
new PlayerAttribute { Id = 61, PlayerId = 9, AttributeType = "Mental", Value = 90 },
new PlayerAttribute { Id = 62, PlayerId = 9, AttributeType = "Volley", Value = 86 },
new PlayerAttribute { Id = 63, PlayerId = 9, AttributeType = "Return", Value = 88 },

// Barbora Krejcikova (CZE)
new PlayerAttribute { Id = 64, PlayerId = 10, AttributeType = "Backhand", Value = 90 },
new PlayerAttribute { Id = 65, PlayerId = 10, AttributeType = "Forehand", Value = 89 },
new PlayerAttribute { Id = 66, PlayerId = 10, AttributeType = "Speed", Value = 87 },
new PlayerAttribute { Id = 67, PlayerId = 10, AttributeType = "Stamina", Value = 91 },
new PlayerAttribute { Id = 68, PlayerId = 10, AttributeType = "Mental", Value = 92 },
new PlayerAttribute { Id = 69, PlayerId = 10, AttributeType = "Volley", Value = 84 },
new PlayerAttribute { Id = 70, PlayerId = 10, AttributeType = "Return", Value = 86 },

// Beatriz Haddad Maia (BRA)
new PlayerAttribute { Id = 71, PlayerId = 11, AttributeType = "Backhand", Value = 88 },
new PlayerAttribute { Id = 72, PlayerId = 11, AttributeType = "Forehand", Value = 92 },
new PlayerAttribute { Id = 73, PlayerId = 11, AttributeType = "Speed", Value = 85 },
new PlayerAttribute { Id = 74, PlayerId = 11, AttributeType = "Stamina", Value = 91 },
new PlayerAttribute { Id = 75, PlayerId = 11, AttributeType = "Mental", Value = 89 },
new PlayerAttribute { Id = 76, PlayerId = 11, AttributeType = "Volley", Value = 82 },
new PlayerAttribute { Id = 77, PlayerId = 11, AttributeType = "Return", Value = 85 },

// Madison Keys (USA)
new PlayerAttribute { Id = 78, PlayerId = 12, AttributeType = "Backhand", Value = 87 },
new PlayerAttribute { Id = 79, PlayerId = 12, AttributeType = "Forehand", Value = 94 },
new PlayerAttribute { Id = 80, PlayerId = 12, AttributeType = "Speed", Value = 90 },
new PlayerAttribute { Id = 81, PlayerId = 12, AttributeType = "Stamina", Value = 88 },
new PlayerAttribute { Id = 82, PlayerId = 12, AttributeType = "Mental", Value = 91 },
new PlayerAttribute { Id = 83, PlayerId = 12, AttributeType = "Volley", Value = 89 },
new PlayerAttribute { Id = 84, PlayerId = 12, AttributeType = "Return", Value = 88 },

// Jelena Ostapenko (LVA)
new PlayerAttribute { Id = 85, PlayerId = 13, AttributeType = "Backhand", Value = 86 },
new PlayerAttribute { Id = 86, PlayerId = 13, AttributeType = "Forehand", Value = 91 },
new PlayerAttribute { Id = 87, PlayerId = 13, AttributeType = "Speed", Value = 87 },
new PlayerAttribute { Id = 88, PlayerId = 13, AttributeType = "Stamina", Value = 88 },
new PlayerAttribute { Id = 89, PlayerId = 13, AttributeType = "Mental", Value = 90 },
new PlayerAttribute { Id = 90, PlayerId = 13, AttributeType = "Volley", Value = 83 },
new PlayerAttribute { Id = 91, PlayerId = 13, AttributeType = "Return", Value = 85 },

// Petra Kvitova (CZE)
new PlayerAttribute { Id = 92, PlayerId = 14, AttributeType = "Backhand", Value = 92 },
new PlayerAttribute { Id = 93, PlayerId = 14, AttributeType = "Forehand", Value = 89 },
new PlayerAttribute { Id = 94, PlayerId = 14, AttributeType = "Speed", Value = 84 },
new PlayerAttribute { Id = 95, PlayerId = 14, AttributeType = "Stamina", Value = 88 },
new PlayerAttribute { Id = 96, PlayerId = 14, AttributeType = "Mental", Value = 91 },
new PlayerAttribute { Id = 97, PlayerId = 14, AttributeType = "Volley", Value = 85 },
new PlayerAttribute { Id = 98, PlayerId = 14, AttributeType = "Return", Value = 84 },

// Qinwen Zheng (CHN)
new PlayerAttribute { Id = 99, PlayerId = 15, AttributeType = "Backhand", Value = 87 },
new PlayerAttribute { Id = 100, PlayerId = 15, AttributeType = "Forehand", Value = 91 },
new PlayerAttribute { Id = 101, PlayerId = 15, AttributeType = "Speed", Value = 90 },
new PlayerAttribute { Id = 102, PlayerId = 15, AttributeType = "Stamina", Value = 87 },
new PlayerAttribute { Id = 103, PlayerId = 15, AttributeType = "Mental", Value = 89 },
new PlayerAttribute { Id = 104, PlayerId = 15, AttributeType = "Volley", Value = 82 },
new PlayerAttribute { Id = 105, PlayerId = 15, AttributeType = "Return", Value = 84 },

// Liudmila Samsonova (RUS)
new PlayerAttribute { Id = 106, PlayerId = 16, AttributeType = "Backhand", Value = 88 },
new PlayerAttribute { Id = 107, PlayerId = 16, AttributeType = "Forehand", Value = 90 },
new PlayerAttribute { Id = 108, PlayerId = 16, AttributeType = "Speed", Value = 91 },
new PlayerAttribute { Id = 109, PlayerId = 16, AttributeType = "Stamina", Value = 85 },
new PlayerAttribute { Id = 110, PlayerId = 16, AttributeType = "Mental", Value = 90 },
new PlayerAttribute { Id = 111, PlayerId = 16, AttributeType = "Volley", Value = 83 },
new PlayerAttribute { Id = 112, PlayerId = 16, AttributeType = "Return", Value = 86 },

// Belinda Bencic (CHE)
new PlayerAttribute { Id = 113, PlayerId = 17, AttributeType = "Backhand", Value = 88 },
new PlayerAttribute { Id = 114, PlayerId = 17, AttributeType = "Forehand", Value = 91 },
new PlayerAttribute { Id = 115, PlayerId = 17, AttributeType = "Speed", Value = 89 },
new PlayerAttribute { Id = 116, PlayerId = 17, AttributeType = "Stamina", Value = 88 },
new PlayerAttribute { Id = 117, PlayerId = 17, AttributeType = "Mental", Value = 89 },
new PlayerAttribute { Id = 118, PlayerId = 17, AttributeType = "Volley", Value = 85 },
new PlayerAttribute { Id = 119, PlayerId = 17, AttributeType = "Return", Value = 86 },

// Daria Kasatkina (RUS)
new PlayerAttribute { Id = 120, PlayerId = 18, AttributeType = "Backhand", Value = 90 },
new PlayerAttribute { Id = 121, PlayerId = 18, AttributeType = "Forehand", Value = 88 },
new PlayerAttribute { Id = 122, PlayerId = 18, AttributeType = "Speed", Value = 85 },
new PlayerAttribute { Id = 123, PlayerId = 18, AttributeType = "Stamina", Value = 89 },
new PlayerAttribute { Id = 124, PlayerId = 18, AttributeType = "Mental", Value = 91 },
new PlayerAttribute { Id = 125, PlayerId = 18, AttributeType = "Volley", Value = 82 },
new PlayerAttribute { Id = 126, PlayerId = 18, AttributeType = "Return", Value = 85 },

// Veronika Kudermetova (RUS)
new PlayerAttribute { Id = 127, PlayerId = 19, AttributeType = "Backhand", Value = 87 },
new PlayerAttribute { Id = 128, PlayerId = 19, AttributeType = "Forehand", Value = 90 },
new PlayerAttribute { Id = 129, PlayerId = 19, AttributeType = "Speed", Value = 88 },
new PlayerAttribute { Id = 130, PlayerId = 19, AttributeType = "Stamina", Value = 85 },
new PlayerAttribute { Id = 131, PlayerId = 19, AttributeType = "Mental", Value = 89 },
new PlayerAttribute { Id = 132, PlayerId = 19, AttributeType = "Volley", Value = 83 },
new PlayerAttribute { Id = 133, PlayerId = 19, AttributeType = "Return", Value = 86 },

// Caroline Garcia (FRA)
new PlayerAttribute { Id = 134, PlayerId = 20, AttributeType = "Backhand", Value = 88 },
new PlayerAttribute { Id = 135, PlayerId = 20, AttributeType = "Forehand", Value = 91 },
new PlayerAttribute { Id = 136, PlayerId = 20, AttributeType = "Speed", Value = 87 },
new PlayerAttribute { Id = 137, PlayerId = 20, AttributeType = "Stamina", Value = 85 },
new PlayerAttribute { Id = 138, PlayerId = 20, AttributeType = "Mental", Value = 90 },
new PlayerAttribute { Id = 139, PlayerId = 20, AttributeType = "Volley", Value = 82 },
new PlayerAttribute { Id = 140, PlayerId = 20, AttributeType = "Return", Value = 84 },

// Ekaterina Alexandrova (RUS)
new PlayerAttribute { Id = 141, PlayerId = 21, AttributeType = "Backhand", Value = 87 },
new PlayerAttribute { Id = 142, PlayerId = 21, AttributeType = "Forehand", Value = 88 },
new PlayerAttribute { Id = 143, PlayerId = 21, AttributeType = "Speed", Value = 85 },
new PlayerAttribute { Id = 144, PlayerId = 21, AttributeType = "Stamina", Value = 86 },
new PlayerAttribute { Id = 145, PlayerId = 21, AttributeType = "Mental", Value = 89 },
new PlayerAttribute { Id = 146, PlayerId = 21, AttributeType = "Volley", Value = 81 },
new PlayerAttribute { Id = 147, PlayerId = 21, AttributeType = "Return", Value = 83 },

// Victoria Azarenka (BLR)
new PlayerAttribute { Id = 148, PlayerId = 22, AttributeType = "Backhand", Value = 91 },
new PlayerAttribute { Id = 149, PlayerId = 22, AttributeType = "Forehand", Value = 89 },
new PlayerAttribute { Id = 150, PlayerId = 22, AttributeType = "Speed", Value = 85 },
new PlayerAttribute { Id = 151, PlayerId = 22, AttributeType = "Stamina", Value = 83 },
new PlayerAttribute { Id = 152, PlayerId = 22, AttributeType = "Mental", Value = 91 },
new PlayerAttribute { Id = 153, PlayerId = 22, AttributeType = "Volley", Value = 84 },
new PlayerAttribute { Id = 154, PlayerId = 22, AttributeType = "Return", Value = 87 },

// Donna Vekic (HRV)
new PlayerAttribute { Id = 155, PlayerId = 23, AttributeType = "Backhand", Value = 86 },
new PlayerAttribute { Id = 156, PlayerId = 23, AttributeType = "Forehand", Value = 90 },
new PlayerAttribute { Id = 157, PlayerId = 23, AttributeType = "Speed", Value = 88 },
new PlayerAttribute { Id = 158, PlayerId = 23, AttributeType = "Stamina", Value = 85 },
new PlayerAttribute { Id = 159, PlayerId = 23, AttributeType = "Mental", Value = 86 },
new PlayerAttribute { Id = 160, PlayerId = 23, AttributeType = "Volley", Value = 82 },
new PlayerAttribute { Id = 161, PlayerId = 23, AttributeType = "Return", Value = 84 },

// Magda Linette (POL)
new PlayerAttribute { Id = 162, PlayerId = 24, AttributeType = "Backhand", Value = 83 },
new PlayerAttribute { Id = 163, PlayerId = 24, AttributeType = "Forehand", Value = 86 },
new PlayerAttribute { Id = 164, PlayerId = 24, AttributeType = "Speed", Value = 84 },
new PlayerAttribute { Id = 165, PlayerId = 24, AttributeType = "Stamina", Value = 89 },
new PlayerAttribute { Id = 166, PlayerId = 24, AttributeType = "Mental", Value = 88 },
new PlayerAttribute { Id = 167, PlayerId = 24, AttributeType = "Volley", Value = 80 },
new PlayerAttribute { Id = 168, PlayerId = 24, AttributeType = "Return", Value = 82 },

// Elina Svitolina (UKR)
new PlayerAttribute { Id = 169, PlayerId = 25, AttributeType = "Backhand", Value = 88 },
new PlayerAttribute { Id = 170, PlayerId = 25, AttributeType = "Forehand", Value = 90 },
new PlayerAttribute { Id = 171, PlayerId = 25, AttributeType = "Speed", Value = 86 },
new PlayerAttribute { Id = 172, PlayerId = 25, AttributeType = "Stamina", Value = 87 },
new PlayerAttribute { Id = 173, PlayerId = 25, AttributeType = "Mental", Value = 90 },
new PlayerAttribute { Id = 174, PlayerId = 25, AttributeType = "Volley", Value = 82 },
new PlayerAttribute { Id = 175, PlayerId = 25, AttributeType = "Return", Value = 83 },

// Sorana Cirstea (ROU)
new PlayerAttribute { Id = 176, PlayerId = 26, AttributeType = "Backhand", Value = 85 },
new PlayerAttribute { Id = 177, PlayerId = 26, AttributeType = "Forehand", Value = 87 },
new PlayerAttribute { Id = 178, PlayerId = 26, AttributeType = "Speed", Value = 84 },
new PlayerAttribute { Id = 179, PlayerId = 26, AttributeType = "Stamina", Value = 86 },
new PlayerAttribute { Id = 180, PlayerId = 26, AttributeType = "Mental", Value = 89 },
new PlayerAttribute { Id = 181, PlayerId = 26, AttributeType = "Volley", Value = 81 },
new PlayerAttribute { Id = 182, PlayerId = 26, AttributeType = "Return", Value = 82 },

// Anastasia Potapova (RUS)
new PlayerAttribute { Id = 183, PlayerId = 27, AttributeType = "Backhand", Value = 84 },
new PlayerAttribute { Id = 184, PlayerId = 27, AttributeType = "Forehand", Value = 89 },
new PlayerAttribute { Id = 185, PlayerId = 27, AttributeType = "Speed", Value = 91 },
new PlayerAttribute { Id = 186, PlayerId = 27, AttributeType = "Stamina", Value = 85 },
new PlayerAttribute { Id = 187, PlayerId = 27, AttributeType = "Mental", Value = 87 },
new PlayerAttribute { Id = 188, PlayerId = 27, AttributeType = "Volley", Value = 82 },
new PlayerAttribute { Id = 189, PlayerId = 27, AttributeType = "Return", Value = 84 },

// Anhelina Kalinina (UKR)
new PlayerAttribute { Id = 190, PlayerId = 28, AttributeType = "Backhand", Value = 86 },
new PlayerAttribute { Id = 191, PlayerId = 28, AttributeType = "Forehand", Value = 89 },
new PlayerAttribute { Id = 192, PlayerId = 28, AttributeType = "Speed", Value = 87 },
new PlayerAttribute { Id = 193, PlayerId = 28, AttributeType = "Stamina", Value = 88 },
new PlayerAttribute { Id = 194, PlayerId = 28, AttributeType = "Mental", Value = 86 },
new PlayerAttribute { Id = 195, PlayerId = 28, AttributeType = "Volley", Value = 83 },
new PlayerAttribute { Id = 196, PlayerId = 28, AttributeType = "Return", Value = 85 },

// Elise Mertens (BEL)
new PlayerAttribute { Id = 197, PlayerId = 29, AttributeType = "Backhand", Value = 86 },
new PlayerAttribute { Id = 198, PlayerId = 29, AttributeType = "Forehand", Value = 87 },
new PlayerAttribute { Id = 199, PlayerId = 29, AttributeType = "Speed", Value = 89 },
new PlayerAttribute { Id = 200, PlayerId = 29, AttributeType = "Stamina", Value = 86 },
new PlayerAttribute { Id = 201, PlayerId = 29, AttributeType = "Mental", Value = 87 },
new PlayerAttribute { Id = 202, PlayerId = 29, AttributeType = "Volley", Value = 84 },
new PlayerAttribute { Id = 203, PlayerId = 29, AttributeType = "Return", Value = 83 },

// Jasmine Paolini (ITA)
new PlayerAttribute { Id = 204, PlayerId = 30, AttributeType = "Backhand", Value = 85 },
new PlayerAttribute { Id = 205, PlayerId = 30, AttributeType = "Forehand", Value = 87 },
new PlayerAttribute { Id = 206, PlayerId = 30, AttributeType = "Speed", Value = 85 },
new PlayerAttribute { Id = 207, PlayerId = 30, AttributeType = "Stamina", Value = 88 },
new PlayerAttribute { Id = 208, PlayerId = 30, AttributeType = "Mental", Value = 86 },
new PlayerAttribute { Id = 209, PlayerId = 30, AttributeType = "Volley", Value = 80 },
new PlayerAttribute { Id = 210, PlayerId = 30, AttributeType = "Return", Value = 82 },

// Lesya Tsurenko (UKR)
new PlayerAttribute { Id = 211, PlayerId = 31, AttributeType = "Backhand", Value = 80 },
new PlayerAttribute { Id = 212, PlayerId = 31, AttributeType = "Forehand", Value = 83 },
new PlayerAttribute { Id = 213, PlayerId = 31, AttributeType = "Speed", Value = 78 },
new PlayerAttribute { Id = 214, PlayerId = 31, AttributeType = "Stamina", Value = 82 },
new PlayerAttribute { Id = 215, PlayerId = 31, AttributeType = "Mental", Value = 84 },
new PlayerAttribute { Id = 216, PlayerId = 31, AttributeType = "Volley", Value = 76 },
new PlayerAttribute { Id = 217, PlayerId = 31, AttributeType = "Return", Value = 80 },

// Emma Navarro (USA)
new PlayerAttribute { Id = 218, PlayerId = 32, AttributeType = "Backhand", Value = 83 },
new PlayerAttribute { Id = 219, PlayerId = 32, AttributeType = "Forehand", Value = 86 },
new PlayerAttribute { Id = 220, PlayerId = 32, AttributeType = "Speed", Value = 88 },
new PlayerAttribute { Id = 221, PlayerId = 32, AttributeType = "Stamina", Value = 85 },
new PlayerAttribute { Id = 222, PlayerId = 32, AttributeType = "Mental", Value = 87 },
new PlayerAttribute { Id = 223, PlayerId = 32, AttributeType = "Volley", Value = 80 },
new PlayerAttribute { Id = 224, PlayerId = 32, AttributeType = "Return", Value = 81 },

// Sofia Kenin (USA)
new PlayerAttribute { Id = 225, PlayerId = 33, AttributeType = "Backhand", Value = 84 },
new PlayerAttribute { Id = 226, PlayerId = 33, AttributeType = "Forehand", Value = 87 },
new PlayerAttribute { Id = 227, PlayerId = 33, AttributeType = "Speed", Value = 82 },
new PlayerAttribute { Id = 228, PlayerId = 33, AttributeType = "Stamina", Value = 85 },
new PlayerAttribute { Id = 229, PlayerId = 33, AttributeType = "Mental", Value = 88 },
new PlayerAttribute { Id = 230, PlayerId = 33, AttributeType = "Volley", Value = 79 },
new PlayerAttribute { Id = 231, PlayerId = 33, AttributeType = "Return", Value = 81 },

// Marie Bouzkova (CZE)
new PlayerAttribute { Id = 232, PlayerId = 34, AttributeType = "Backhand", Value = 84 },
new PlayerAttribute { Id = 233, PlayerId = 34, AttributeType = "Forehand", Value = 86 },
new PlayerAttribute { Id = 234, PlayerId = 34, AttributeType = "Speed", Value = 85 },
new PlayerAttribute { Id = 235, PlayerId = 34, AttributeType = "Stamina", Value = 84 },
new PlayerAttribute { Id = 236, PlayerId = 34, AttributeType = "Mental", Value = 86 },
new PlayerAttribute { Id = 237, PlayerId = 34, AttributeType = "Volley", Value = 78 },
new PlayerAttribute { Id = 238, PlayerId = 34, AttributeType = "Return", Value = 80 },

// Leylah Annie Fernandez (CAN)
new PlayerAttribute { Id = 239, PlayerId = 35, AttributeType = "Backhand", Value = 85 },
new PlayerAttribute { Id = 240, PlayerId = 35, AttributeType = "Forehand", Value = 88 },
new PlayerAttribute { Id = 241, PlayerId = 35, AttributeType = "Speed", Value = 87 },
new PlayerAttribute { Id = 242, PlayerId = 35, AttributeType = "Stamina", Value = 86 },
new PlayerAttribute { Id = 243, PlayerId = 35, AttributeType = "Mental", Value = 88 },
new PlayerAttribute { Id = 244, PlayerId = 35, AttributeType = "Volley", Value = 80 },
new PlayerAttribute { Id = 245, PlayerId = 35, AttributeType = "Return", Value = 82 },

// Xinyu Wang (CHN)
new PlayerAttribute { Id = 246, PlayerId = 36, AttributeType = "Backhand", Value = 81 },
new PlayerAttribute { Id = 247, PlayerId = 36, AttributeType = "Forehand", Value = 84 },
new PlayerAttribute { Id = 248, PlayerId = 36, AttributeType = "Speed", Value = 89 },
new PlayerAttribute { Id = 249, PlayerId = 36, AttributeType = "Stamina", Value = 84 },
new PlayerAttribute { Id = 250, PlayerId = 36, AttributeType = "Mental", Value = 87 },
new PlayerAttribute { Id = 251, PlayerId = 36, AttributeType = "Volley", Value = 78 },
new PlayerAttribute { Id = 252, PlayerId = 36, AttributeType = "Return", Value = 80 },

// Lin Zhu (CHN)
new PlayerAttribute { Id = 253, PlayerId = 37, AttributeType = "Backhand", Value = 83 },
new PlayerAttribute { Id = 254, PlayerId = 37, AttributeType = "Forehand", Value = 86 },
new PlayerAttribute { Id = 255, PlayerId = 37, AttributeType = "Speed", Value = 82 },
new PlayerAttribute { Id = 256, PlayerId = 37, AttributeType = "Stamina", Value = 83 },
new PlayerAttribute { Id = 257, PlayerId = 37, AttributeType = "Mental", Value = 85 },
new PlayerAttribute { Id = 258, PlayerId = 37, AttributeType = "Volley", Value = 77 },
new PlayerAttribute { Id = 259, PlayerId = 37, AttributeType = "Return", Value = 79 },

// Karolina Pliskova (CZE)
new PlayerAttribute { Id = 260, PlayerId = 38, AttributeType = "Backhand", Value = 87 },
new PlayerAttribute { Id = 261, PlayerId = 38, AttributeType = "Forehand", Value = 90 },
new PlayerAttribute { Id = 262, PlayerId = 38, AttributeType = "Speed", Value = 80 },
new PlayerAttribute { Id = 263, PlayerId = 38, AttributeType = "Stamina", Value = 81 },
new PlayerAttribute { Id = 264, PlayerId = 38, AttributeType = "Mental", Value = 86 },
new PlayerAttribute { Id = 265, PlayerId = 38, AttributeType = "Volley", Value = 75 },
new PlayerAttribute { Id = 266, PlayerId = 38, AttributeType = "Return", Value = 78 },

// Marta Kostyuk (UKR)
new PlayerAttribute { Id = 267, PlayerId = 39, AttributeType = "Backhand", Value = 85 },
new PlayerAttribute { Id = 268, PlayerId = 39, AttributeType = "Forehand", Value = 87 },
new PlayerAttribute { Id = 269, PlayerId = 39, AttributeType = "Speed", Value = 90 },
new PlayerAttribute { Id = 270, PlayerId = 39, AttributeType = "Stamina", Value = 82 },
new PlayerAttribute { Id = 271, PlayerId = 39, AttributeType = "Mental", Value = 85 },
new PlayerAttribute { Id = 272, PlayerId = 39, AttributeType = "Volley", Value = 78 },
new PlayerAttribute { Id = 273, PlayerId = 39, AttributeType = "Return", Value = 80 },

// Petra Martic (HRV)
new PlayerAttribute { Id = 274, PlayerId = 40, AttributeType = "Backhand", Value = 84 },
new PlayerAttribute { Id = 275, PlayerId = 40, AttributeType = "Forehand", Value = 85 },
new PlayerAttribute { Id = 276, PlayerId = 40, AttributeType = "Speed", Value = 81 },
new PlayerAttribute { Id = 277, PlayerId = 40, AttributeType = "Stamina", Value = 84 },
new PlayerAttribute { Id = 278, PlayerId = 40, AttributeType = "Mental", Value = 86 },
new PlayerAttribute { Id = 279, PlayerId = 40, AttributeType = "Volley", Value = 76 },
new PlayerAttribute { Id = 280, PlayerId = 40, AttributeType = "Return", Value = 78 },

// Linda Noskova (CZE)
new PlayerAttribute { Id = 281, PlayerId = 41, AttributeType = "Backhand", Value = 81 },
new PlayerAttribute { Id = 282, PlayerId = 41, AttributeType = "Forehand", Value = 83 },
new PlayerAttribute { Id = 283, PlayerId = 41, AttributeType = "Speed", Value = 86 },
new PlayerAttribute { Id = 284, PlayerId = 41, AttributeType = "Stamina", Value = 82 },
new PlayerAttribute { Id = 285, PlayerId = 41, AttributeType = "Mental", Value = 85 },
new PlayerAttribute { Id = 286, PlayerId = 41, AttributeType = "Volley", Value = 74 },
new PlayerAttribute { Id = 287, PlayerId = 41, AttributeType = "Return", Value = 79 },

// Martina Trevisan (ITA)
new PlayerAttribute { Id = 288, PlayerId = 42, AttributeType = "Backhand", Value = 84 },
new PlayerAttribute { Id = 289, PlayerId = 42, AttributeType = "Forehand", Value = 86 },
new PlayerAttribute { Id = 290, PlayerId = 42, AttributeType = "Speed", Value = 82 },
new PlayerAttribute { Id = 291, PlayerId = 42, AttributeType = "Stamina", Value = 83 },
new PlayerAttribute { Id = 292, PlayerId = 42, AttributeType = "Mental", Value = 84 },
new PlayerAttribute { Id = 293, PlayerId = 42, AttributeType = "Volley", Value = 76 },
new PlayerAttribute { Id = 294, PlayerId = 42, AttributeType = "Return", Value = 78 },

// Varvara Gracheva (FRA)
new PlayerAttribute { Id = 295, PlayerId = 43, AttributeType = "Backhand", Value = 81 },
new PlayerAttribute { Id = 296, PlayerId = 43, AttributeType = "Forehand", Value = 83 },
new PlayerAttribute { Id = 297, PlayerId = 43, AttributeType = "Speed", Value = 85 },
new PlayerAttribute { Id = 298, PlayerId = 43, AttributeType = "Stamina", Value = 80 },
new PlayerAttribute { Id = 299, PlayerId = 43, AttributeType = "Mental", Value = 82 },
new PlayerAttribute { Id = 300, PlayerId = 43, AttributeType = "Volley", Value = 74 },
new PlayerAttribute { Id = 301, PlayerId = 43, AttributeType = "Return", Value = 77 },

// Caroline Dolehide (USA)
new PlayerAttribute { Id = 302, PlayerId = 44, AttributeType = "Backhand", Value = 80 },
new PlayerAttribute { Id = 303, PlayerId = 44, AttributeType = "Forehand", Value = 82 },
new PlayerAttribute { Id = 304, PlayerId = 44, AttributeType = "Speed", Value = 83 },
new PlayerAttribute { Id = 305, PlayerId = 44, AttributeType = "Stamina", Value = 81 },
new PlayerAttribute { Id = 306, PlayerId = 44, AttributeType = "Mental", Value = 85 },
new PlayerAttribute { Id = 307, PlayerId = 44, AttributeType = "Volley", Value = 75 },
new PlayerAttribute { Id = 308, PlayerId = 44, AttributeType = "Return", Value = 78 },

// Katerina Siniakova (CZE)
new PlayerAttribute { Id = 309, PlayerId = 45, AttributeType = "Backhand", Value = 84 },
new PlayerAttribute { Id = 310, PlayerId = 45, AttributeType = "Forehand", Value = 86 },
new PlayerAttribute { Id = 311, PlayerId = 45, AttributeType = "Speed", Value = 83 },
new PlayerAttribute { Id = 312, PlayerId = 45, AttributeType = "Stamina", Value = 80 },
new PlayerAttribute { Id = 313, PlayerId = 45, AttributeType = "Mental", Value = 84 },
new PlayerAttribute { Id = 314, PlayerId = 45, AttributeType = "Volley", Value = 76 },
new PlayerAttribute { Id = 315, PlayerId = 45, AttributeType = "Return", Value = 78 },

// Elisabetta Cocciaretto (ITA)
new PlayerAttribute { Id = 316, PlayerId = 46, AttributeType = "Backhand", Value = 81 },
new PlayerAttribute { Id = 317, PlayerId = 46, AttributeType = "Forehand", Value = 83 },
new PlayerAttribute { Id = 318, PlayerId = 46, AttributeType = "Speed", Value = 85 },
new PlayerAttribute { Id = 319, PlayerId = 46, AttributeType = "Stamina", Value = 79 },
new PlayerAttribute { Id = 320, PlayerId = 46, AttributeType = "Mental", Value = 82 },
new PlayerAttribute { Id = 321, PlayerId = 46, AttributeType = "Volley", Value = 73 },
new PlayerAttribute { Id = 322, PlayerId = 46, AttributeType = "Return", Value = 75 },

// Sloane Stephens (USA)
new PlayerAttribute { Id = 323, PlayerId = 47, AttributeType = "Backhand", Value = 82 },
new PlayerAttribute { Id = 324, PlayerId = 47, AttributeType = "Forehand", Value = 85 },
new PlayerAttribute { Id = 325, PlayerId = 47, AttributeType = "Speed", Value = 84 },
new PlayerAttribute { Id = 326, PlayerId = 47, AttributeType = "Stamina", Value = 83 },
new PlayerAttribute { Id = 327, PlayerId = 47, AttributeType = "Mental", Value = 85 },
new PlayerAttribute { Id = 328, PlayerId = 47, AttributeType = "Volley", Value = 77 },
new PlayerAttribute { Id = 329, PlayerId = 47, AttributeType = "Return", Value = 79 },

// Sara Sorribes Tormo (ESP)
new PlayerAttribute { Id = 330, PlayerId = 48, AttributeType = "Backhand", Value = 80 },
new PlayerAttribute { Id = 331, PlayerId = 48, AttributeType = "Forehand", Value = 82 },
new PlayerAttribute { Id = 332, PlayerId = 48, AttributeType = "Speed", Value = 83 },
new PlayerAttribute { Id = 333, PlayerId = 48, AttributeType = "Stamina", Value = 80 },
new PlayerAttribute { Id = 334, PlayerId = 48, AttributeType = "Mental", Value = 83 },
new PlayerAttribute { Id = 335, PlayerId = 48, AttributeType = "Volley", Value = 74 },
new PlayerAttribute { Id = 336, PlayerId = 48, AttributeType = "Return", Value = 77 },

// Peyton Stearns (USA)
new PlayerAttribute { Id = 337, PlayerId = 49, AttributeType = "Backhand", Value = 79 },
new PlayerAttribute { Id = 338, PlayerId = 49, AttributeType = "Forehand", Value = 81 },
new PlayerAttribute { Id = 339, PlayerId = 49, AttributeType = "Speed", Value = 84 },
new PlayerAttribute { Id = 340, PlayerId = 49, AttributeType = "Stamina", Value = 78 },
new PlayerAttribute { Id = 341, PlayerId = 49, AttributeType = "Mental", Value = 81 },
new PlayerAttribute { Id = 342, PlayerId = 49, AttributeType = "Volley", Value = 73 },
new PlayerAttribute { Id = 343, PlayerId = 49, AttributeType = "Return", Value = 75 },

// Anna Blinkova (RUS)
new PlayerAttribute { Id = 344, PlayerId = 50, AttributeType = "Backhand", Value = 78 },
new PlayerAttribute { Id = 345, PlayerId = 50, AttributeType = "Forehand", Value = 80 },
new PlayerAttribute { Id = 346, PlayerId = 50, AttributeType = "Speed", Value = 82 },
new PlayerAttribute { Id = 347, PlayerId = 50, AttributeType = "Stamina", Value = 77 },
new PlayerAttribute { Id = 348, PlayerId = 50, AttributeType = "Mental", Value = 79 },
new PlayerAttribute { Id = 349, PlayerId = 50, AttributeType = "Volley", Value = 72 },
new PlayerAttribute { Id = 350, PlayerId = 50, AttributeType = "Return", Value = 74 },

// Arantxa Rus (NLD)
new PlayerAttribute { Id = 351, PlayerId = 51, AttributeType = "Backhand", Value = 76 },
new PlayerAttribute { Id = 352, PlayerId = 51, AttributeType = "Forehand", Value = 78 },
new PlayerAttribute { Id = 353, PlayerId = 51, AttributeType = "Speed", Value = 79 },
new PlayerAttribute { Id = 354, PlayerId = 51, AttributeType = "Stamina", Value = 75 },
new PlayerAttribute { Id = 355, PlayerId = 51, AttributeType = "Mental", Value = 78 },
new PlayerAttribute { Id = 356, PlayerId = 51, AttributeType = "Volley", Value = 70 },
new PlayerAttribute { Id = 357, PlayerId = 51, AttributeType = "Return", Value = 72 },

// Danielle Rose Collins (USA)
new PlayerAttribute { Id = 358, PlayerId = 52, AttributeType = "Backhand", Value = 82 },
new PlayerAttribute { Id = 359, PlayerId = 52, AttributeType = "Forehand", Value = 84 },
new PlayerAttribute { Id = 360, PlayerId = 52, AttributeType = "Speed", Value = 80 },
new PlayerAttribute { Id = 361, PlayerId = 52, AttributeType = "Stamina", Value = 78 },
new PlayerAttribute { Id = 362, PlayerId = 52, AttributeType = "Mental", Value = 81 },
new PlayerAttribute { Id = 363, PlayerId = 52, AttributeType = "Volley", Value = 72 },
new PlayerAttribute { Id = 364, PlayerId = 52, AttributeType = "Return", Value = 74 },

// Camila Giorgi (ITA)
new PlayerAttribute { Id = 365, PlayerId = 53, AttributeType = "Backhand", Value = 85 },
new PlayerAttribute { Id = 366, PlayerId = 53, AttributeType = "Forehand", Value = 88 },
new PlayerAttribute { Id = 367, PlayerId = 53, AttributeType = "Speed", Value = 82 },
new PlayerAttribute { Id = 368, PlayerId = 53, AttributeType = "Stamina", Value = 76 },
new PlayerAttribute { Id = 369, PlayerId = 53, AttributeType = "Mental", Value = 78 },
new PlayerAttribute { Id = 370, PlayerId = 53, AttributeType = "Volley", Value = 74 },
new PlayerAttribute { Id = 371, PlayerId = 53, AttributeType = "Return", Value = 75 },

// Tatjana Maria (DEU)
new PlayerAttribute { Id = 372, PlayerId = 54, AttributeType = "Backhand", Value = 80 },
new PlayerAttribute { Id = 373, PlayerId = 54, AttributeType = "Forehand", Value = 81 },
new PlayerAttribute { Id = 374, PlayerId = 54, AttributeType = "Speed", Value = 77 },
new PlayerAttribute { Id = 375, PlayerId = 54, AttributeType = "Stamina", Value = 79 },
new PlayerAttribute { Id = 376, PlayerId = 54, AttributeType = "Mental", Value = 75 },
new PlayerAttribute { Id = 377, PlayerId = 54, AttributeType = "Volley", Value = 72 },
new PlayerAttribute { Id = 378, PlayerId = 54, AttributeType = "Return", Value = 73 },

// Clara Burel (FRA)
new PlayerAttribute { Id = 379, PlayerId = 55, AttributeType = "Backhand", Value = 78 },
new PlayerAttribute { Id = 380, PlayerId = 55, AttributeType = "Forehand", Value = 80 },
new PlayerAttribute { Id = 381, PlayerId = 55, AttributeType = "Speed", Value = 81 },
new PlayerAttribute { Id = 382, PlayerId = 55, AttributeType = "Stamina", Value = 76 },
new PlayerAttribute { Id = 383, PlayerId = 55, AttributeType = "Mental", Value = 78 },
new PlayerAttribute { Id = 384, PlayerId = 55, AttributeType = "Volley", Value = 71 },
new PlayerAttribute { Id = 385, PlayerId = 55, AttributeType = "Return", Value = 73 },

// Katie Boulter (GBR)
new PlayerAttribute { Id = 386, PlayerId = 56, AttributeType = "Backhand", Value = 77 },
new PlayerAttribute { Id = 387, PlayerId = 56, AttributeType = "Forehand", Value = 79 },
new PlayerAttribute { Id = 388, PlayerId = 56, AttributeType = "Speed", Value = 80 },
new PlayerAttribute { Id = 389, PlayerId = 56, AttributeType = "Stamina", Value = 75 },
new PlayerAttribute { Id = 390, PlayerId = 56, AttributeType = "Mental", Value = 77 },
new PlayerAttribute { Id = 391, PlayerId = 56, AttributeType = "Volley", Value = 70 },
new PlayerAttribute { Id = 392, PlayerId = 56, AttributeType = "Return", Value = 71 },

// Mirra Andreeva (RUS)
new PlayerAttribute { Id = 393, PlayerId = 57, AttributeType = "Backhand", Value = 74 },
new PlayerAttribute { Id = 394, PlayerId = 57, AttributeType = "Forehand", Value = 76 },
new PlayerAttribute { Id = 395, PlayerId = 57, AttributeType = "Speed", Value = 79 },
new PlayerAttribute { Id = 396, PlayerId = 57, AttributeType = "Stamina", Value = 73 },
new PlayerAttribute { Id = 397, PlayerId = 57, AttributeType = "Mental", Value = 75 },
new PlayerAttribute { Id = 398, PlayerId = 57, AttributeType = "Volley", Value = 68 },
new PlayerAttribute { Id = 399, PlayerId = 57, AttributeType = "Return", Value = 70 },

// Anastasia Pavlyuchenkova (RUS)
new PlayerAttribute { Id = 400, PlayerId = 58, AttributeType = "Backhand", Value = 83 },
new PlayerAttribute { Id = 401, PlayerId = 58, AttributeType = "Forehand", Value = 85 },
new PlayerAttribute { Id = 402, PlayerId = 58, AttributeType = "Speed", Value = 78 },
new PlayerAttribute { Id = 403, PlayerId = 58, AttributeType = "Stamina", Value = 80 },
new PlayerAttribute { Id = 404, PlayerId = 58, AttributeType = "Mental", Value = 81 },
new PlayerAttribute { Id = 405, PlayerId = 58, AttributeType = "Volley", Value = 75 },
new PlayerAttribute { Id = 406, PlayerId = 58, AttributeType = "Return", Value = 77 },

// Mayar Sherif (EGY)
new PlayerAttribute { Id = 407, PlayerId = 59, AttributeType = "Backhand", Value = 79 },
new PlayerAttribute { Id = 408, PlayerId = 59, AttributeType = "Forehand", Value = 81 },
new PlayerAttribute { Id = 409, PlayerId = 59, AttributeType = "Speed", Value = 76 },
new PlayerAttribute { Id = 410, PlayerId = 59, AttributeType = "Stamina", Value = 79 },
new PlayerAttribute { Id = 411, PlayerId = 59, AttributeType = "Mental", Value = 78 },
new PlayerAttribute { Id = 412, PlayerId = 59, AttributeType = "Volley", Value = 71 },
new PlayerAttribute { Id = 413, PlayerId = 59, AttributeType = "Return", Value = 73 },

// Greetje Minnen (BEL)
new PlayerAttribute { Id = 414, PlayerId = 60, AttributeType = "Backhand", Value = 75 },
new PlayerAttribute { Id = 415, PlayerId = 60, AttributeType = "Forehand", Value = 77 },
new PlayerAttribute { Id = 416, PlayerId = 60, AttributeType = "Speed", Value = 78 },
new PlayerAttribute { Id = 417, PlayerId = 60, AttributeType = "Stamina", Value = 74 },
new PlayerAttribute { Id = 418, PlayerId = 60, AttributeType = "Mental", Value = 76 },
new PlayerAttribute { Id = 419, PlayerId = 60, AttributeType = "Volley", Value = 69 },
new PlayerAttribute { Id = 420, PlayerId = 60, AttributeType = "Return", Value = 70 },

// Cristina Bucsa (ESP)
new PlayerAttribute { Id = 421, PlayerId = 61, AttributeType = "Backhand", Value = 72 },
new PlayerAttribute { Id = 422, PlayerId = 61, AttributeType = "Forehand", Value = 74 },
new PlayerAttribute { Id = 423, PlayerId = 61, AttributeType = "Speed", Value = 77 },
new PlayerAttribute { Id = 424, PlayerId = 61, AttributeType = "Stamina", Value = 72 },
new PlayerAttribute { Id = 425, PlayerId = 61, AttributeType = "Mental", Value = 74 },
new PlayerAttribute { Id = 426, PlayerId = 61, AttributeType = "Volley", Value = 68 },
new PlayerAttribute { Id = 427, PlayerId = 61, AttributeType = "Return", Value = 70 },

// Lucia Bronzetti (ITA)
new PlayerAttribute { Id = 428, PlayerId = 62, AttributeType = "Backhand", Value = 71 },
new PlayerAttribute { Id = 429, PlayerId = 62, AttributeType = "Forehand", Value = 73 },
new PlayerAttribute { Id = 430, PlayerId = 62, AttributeType = "Speed", Value = 75 },
new PlayerAttribute { Id = 431, PlayerId = 62, AttributeType = "Stamina", Value = 71 },
new PlayerAttribute { Id = 432, PlayerId = 62, AttributeType = "Mental", Value = 72 },
new PlayerAttribute { Id = 433, PlayerId = 62, AttributeType = "Volley", Value = 66 },
new PlayerAttribute { Id = 434, PlayerId = 62, AttributeType = "Return", Value = 68 },

// Rebeka Masarova (CHE)
new PlayerAttribute { Id = 435, PlayerId = 63, AttributeType = "Backhand", Value = 74 },
new PlayerAttribute { Id = 436, PlayerId = 63, AttributeType = "Forehand", Value = 76 },
new PlayerAttribute { Id = 437, PlayerId = 63, AttributeType = "Speed", Value = 78 },
new PlayerAttribute { Id = 438, PlayerId = 63, AttributeType = "Stamina", Value = 72 },
new PlayerAttribute { Id = 439, PlayerId = 63, AttributeType = "Mental", Value = 74 },
new PlayerAttribute { Id = 440, PlayerId = 63, AttributeType = "Volley", Value = 67 },
new PlayerAttribute { Id = 441, PlayerId = 63, AttributeType = "Return", Value = 69 },

// Paula Badosa Gibert (ESP)
new PlayerAttribute { Id = 442, PlayerId = 64, AttributeType = "Backhand", Value = 83 },
new PlayerAttribute { Id = 443, PlayerId = 64, AttributeType = "Forehand", Value = 85 },
new PlayerAttribute { Id = 444, PlayerId = 64, AttributeType = "Speed", Value = 80 },
new PlayerAttribute { Id = 445, PlayerId = 64, AttributeType = "Stamina", Value = 79 },
new PlayerAttribute { Id = 446, PlayerId = 64, AttributeType = "Mental", Value = 81 },
new PlayerAttribute { Id = 447, PlayerId = 64, AttributeType = "Volley", Value = 74 },
new PlayerAttribute { Id = 448, PlayerId = 64, AttributeType = "Return", Value = 75 },

// Bernarda Pera (USA)
new PlayerAttribute { Id = 449, PlayerId = 65, AttributeType = "Backhand", Value = 78 },
new PlayerAttribute { Id = 450, PlayerId = 65, AttributeType = "Forehand", Value = 80 },
new PlayerAttribute { Id = 451, PlayerId = 65, AttributeType = "Speed", Value = 74 },
new PlayerAttribute { Id = 452, PlayerId = 65, AttributeType = "Stamina", Value = 75 },
new PlayerAttribute { Id = 453, PlayerId = 65, AttributeType = "Mental", Value = 77 },
new PlayerAttribute { Id = 454, PlayerId = 65, AttributeType = "Volley", Value = 68 },
new PlayerAttribute { Id = 455, PlayerId = 65, AttributeType = "Return", Value = 70 },

// Yulia Putintseva (KAZ)
new PlayerAttribute { Id = 456, PlayerId = 66, AttributeType = "Backhand", Value = 82 },
new PlayerAttribute { Id = 457, PlayerId = 66, AttributeType = "Forehand", Value = 80 },
new PlayerAttribute { Id = 458, PlayerId = 66, AttributeType = "Speed", Value = 76 },
new PlayerAttribute { Id = 459, PlayerId = 66, AttributeType = "Stamina", Value = 78 },
new PlayerAttribute { Id = 460, PlayerId = 66, AttributeType = "Mental", Value = 79 },
new PlayerAttribute { Id = 461, PlayerId = 66, AttributeType = "Volley", Value = 70 },
new PlayerAttribute { Id = 462, PlayerId = 66, AttributeType = "Return", Value = 72 },

// Nadia Podoroska (ARG)
new PlayerAttribute { Id = 463, PlayerId = 67, AttributeType = "Backhand", Value = 76 },
new PlayerAttribute { Id = 464, PlayerId = 67, AttributeType = "Forehand", Value = 78 },
new PlayerAttribute { Id = 465, PlayerId = 67, AttributeType = "Speed", Value = 74 },
new PlayerAttribute { Id = 466, PlayerId = 67, AttributeType = "Stamina", Value = 75 },
new PlayerAttribute { Id = 467, PlayerId = 67, AttributeType = "Mental", Value = 77 },
new PlayerAttribute { Id = 468, PlayerId = 67, AttributeType = "Volley", Value = 67 },
new PlayerAttribute { Id = 469, PlayerId = 67, AttributeType = "Return", Value = 69 },

// Lauren Davis (USA)
new PlayerAttribute { Id = 470, PlayerId = 68, AttributeType = "Backhand", Value = 77 },
new PlayerAttribute { Id = 471, PlayerId = 68, AttributeType = "Forehand", Value = 79 },
new PlayerAttribute { Id = 472, PlayerId = 68, AttributeType = "Speed", Value = 80 },
new PlayerAttribute { Id = 473, PlayerId = 68, AttributeType = "Stamina", Value = 74 },
new PlayerAttribute { Id = 474, PlayerId = 68, AttributeType = "Mental", Value = 76 },
new PlayerAttribute { Id = 475, PlayerId = 68, AttributeType = "Volley", Value = 69 },
new PlayerAttribute { Id = 476, PlayerId = 68, AttributeType = "Return", Value = 71 },

// Ana Bogdan (ROU)
new PlayerAttribute { Id = 477, PlayerId = 69, AttributeType = "Backhand", Value = 75 },
new PlayerAttribute { Id = 478, PlayerId = 69, AttributeType = "Forehand", Value = 77 },
new PlayerAttribute { Id = 479, PlayerId = 69, AttributeType = "Speed", Value = 72 },
new PlayerAttribute { Id = 480, PlayerId = 69, AttributeType = "Stamina", Value = 73 },
new PlayerAttribute { Id = 481, PlayerId = 69, AttributeType = "Mental", Value = 74 },
new PlayerAttribute { Id = 482, PlayerId = 69, AttributeType = "Volley", Value = 67 },
new PlayerAttribute { Id = 483, PlayerId = 69, AttributeType = "Return", Value = 69 },

// Xiyu Wang (CHN)
new PlayerAttribute { Id = 484, PlayerId = 70, AttributeType = "Backhand", Value = 76 },
new PlayerAttribute { Id = 485, PlayerId = 70, AttributeType = "Forehand", Value = 78 },
new PlayerAttribute { Id = 486, PlayerId = 70, AttributeType = "Speed", Value = 75 },
new PlayerAttribute { Id = 487, PlayerId = 70, AttributeType = "Stamina", Value = 73 },
new PlayerAttribute { Id = 488, PlayerId = 70, AttributeType = "Mental", Value = 75 },
new PlayerAttribute { Id = 489, PlayerId = 70, AttributeType = "Volley", Value = 68 },
new PlayerAttribute { Id = 490, PlayerId = 70, AttributeType = "Return", Value = 70 },

// Yanina Wickmayer (BEL)
new PlayerAttribute { Id = 491, PlayerId = 71, AttributeType = "Backhand", Value = 78 },
new PlayerAttribute { Id = 492, PlayerId = 71, AttributeType = "Forehand", Value = 80 },
new PlayerAttribute { Id = 493, PlayerId = 71, AttributeType = "Speed", Value = 74 },
new PlayerAttribute { Id = 494, PlayerId = 71, AttributeType = "Stamina", Value = 72 },
new PlayerAttribute { Id = 495, PlayerId = 71, AttributeType = "Mental", Value = 75 },
new PlayerAttribute { Id = 496, PlayerId = 71, AttributeType = "Volley", Value = 68 },
new PlayerAttribute { Id = 497, PlayerId = 71, AttributeType = "Return", Value = 70 },

// Anna Schmiedlova (SVK)
new PlayerAttribute { Id = 498, PlayerId = 72, AttributeType = "Backhand", Value = 77 },
new PlayerAttribute { Id = 499, PlayerId = 72, AttributeType = "Forehand", Value = 79 },
new PlayerAttribute { Id = 500, PlayerId = 72, AttributeType = "Speed", Value = 74 },
new PlayerAttribute { Id = 501, PlayerId = 72, AttributeType = "Stamina", Value = 73 },
new PlayerAttribute { Id = 502, PlayerId = 72, AttributeType = "Mental", Value = 75 },
new PlayerAttribute { Id = 503, PlayerId = 72, AttributeType = "Volley", Value = 69 },
new PlayerAttribute { Id = 504, PlayerId = 72, AttributeType = "Return", Value = 71 },

// Elina Avanesyan (ARM)
new PlayerAttribute { Id = 505, PlayerId = 73, AttributeType = "Backhand", Value = 75 },
new PlayerAttribute { Id = 506, PlayerId = 73, AttributeType = "Forehand", Value = 77 },
new PlayerAttribute { Id = 507, PlayerId = 73, AttributeType = "Speed", Value = 79 },
new PlayerAttribute { Id = 508, PlayerId = 73, AttributeType = "Stamina", Value = 71 },
new PlayerAttribute { Id = 509, PlayerId = 73, AttributeType = "Mental", Value = 73 },
new PlayerAttribute { Id = 510, PlayerId = 73, AttributeType = "Volley", Value = 65 },
new PlayerAttribute { Id = 511, PlayerId = 73, AttributeType = "Return", Value = 67 },

// Magdalena Frech (POL)
new PlayerAttribute { Id = 512, PlayerId = 74, AttributeType = "Backhand", Value = 74 },
new PlayerAttribute { Id = 513, PlayerId = 74, AttributeType = "Forehand", Value = 76 },
new PlayerAttribute { Id = 514, PlayerId = 74, AttributeType = "Speed", Value = 70 },
new PlayerAttribute { Id = 515, PlayerId = 74, AttributeType = "Stamina", Value = 71 },
new PlayerAttribute { Id = 516, PlayerId = 74, AttributeType = "Mental", Value = 72 },
new PlayerAttribute { Id = 517, PlayerId = 74, AttributeType = "Volley", Value = 66 },
new PlayerAttribute { Id = 518, PlayerId = 74, AttributeType = "Return", Value = 68 },

// Irina-Camelia Begu (ROU)
new PlayerAttribute { Id = 519, PlayerId = 75, AttributeType = "Backhand", Value = 76 },
new PlayerAttribute { Id = 520, PlayerId = 75, AttributeType = "Forehand", Value = 78 },
new PlayerAttribute { Id = 521, PlayerId = 75, AttributeType = "Speed", Value = 72 },
new PlayerAttribute { Id = 522, PlayerId = 75, AttributeType = "Stamina", Value = 74 },
new PlayerAttribute { Id = 523, PlayerId = 75, AttributeType = "Mental", Value = 75 },
new PlayerAttribute { Id = 524, PlayerId = 75, AttributeType = "Volley", Value = 69 },
new PlayerAttribute { Id = 525, PlayerId = 75, AttributeType = "Return", Value = 71 },

// Anna Kalinskaya (RUS)
new PlayerAttribute { Id = 526, PlayerId = 76, AttributeType = "Backhand", Value = 75 },
new PlayerAttribute { Id = 527, PlayerId = 76, AttributeType = "Forehand", Value = 77 },
new PlayerAttribute { Id = 528, PlayerId = 76, AttributeType = "Speed", Value = 73 },
new PlayerAttribute { Id = 529, PlayerId = 76, AttributeType = "Stamina", Value = 72 },
new PlayerAttribute { Id = 530, PlayerId = 76, AttributeType = "Mental", Value = 74 },
new PlayerAttribute { Id = 531, PlayerId = 76, AttributeType = "Volley", Value = 68 },
new PlayerAttribute { Id = 532, PlayerId = 76, AttributeType = "Return", Value = 70 },

// Yue Yuan (CHN)
new PlayerAttribute { Id = 533, PlayerId = 77, AttributeType = "Backhand", Value = 74 },
new PlayerAttribute { Id = 534, PlayerId = 77, AttributeType = "Forehand", Value = 76 },
new PlayerAttribute { Id = 535, PlayerId = 77, AttributeType = "Speed", Value = 72 },
new PlayerAttribute { Id = 536, PlayerId = 77, AttributeType = "Stamina", Value = 71 },
new PlayerAttribute { Id = 537, PlayerId = 77, AttributeType = "Mental", Value = 72 },
new PlayerAttribute { Id = 538, PlayerId = 77, AttributeType = "Volley", Value = 67 },
new PlayerAttribute { Id = 539, PlayerId = 77, AttributeType = "Return", Value = 69 },

// Maria Camila Osorio Serrano (COL)
new PlayerAttribute { Id = 540, PlayerId = 78, AttributeType = "Backhand", Value = 75 },
new PlayerAttribute { Id = 541, PlayerId = 78, AttributeType = "Forehand", Value = 77 },
new PlayerAttribute { Id = 542, PlayerId = 78, AttributeType = "Speed", Value = 74 },
new PlayerAttribute { Id = 543, PlayerId = 78, AttributeType = "Stamina", Value = 73 },
new PlayerAttribute { Id = 544, PlayerId = 78, AttributeType = "Mental", Value = 74 },
new PlayerAttribute { Id = 545, PlayerId = 78, AttributeType = "Volley", Value = 66 },
new PlayerAttribute { Id = 546, PlayerId = 78, AttributeType = "Return", Value = 68 },

// Diane Parry (FRA)
new PlayerAttribute { Id = 547, PlayerId = 79, AttributeType = "Backhand", Value = 73 },
new PlayerAttribute { Id = 548, PlayerId = 79, AttributeType = "Forehand", Value = 75 },
new PlayerAttribute { Id = 549, PlayerId = 79, AttributeType = "Speed", Value = 70 },
new PlayerAttribute { Id = 550, PlayerId = 79, AttributeType = "Stamina", Value = 71 },
new PlayerAttribute { Id = 551, PlayerId = 79, AttributeType = "Mental", Value = 72 },
new PlayerAttribute { Id = 552, PlayerId = 79, AttributeType = "Volley", Value = 64 },
new PlayerAttribute { Id = 553, PlayerId = 79, AttributeType = "Return", Value = 66 },

// Viktoriya Tomova (BGR)
new PlayerAttribute { Id = 554, PlayerId = 80, AttributeType = "Backhand", Value = 74 },
new PlayerAttribute { Id = 555, PlayerId = 80, AttributeType = "Forehand", Value = 76 },
new PlayerAttribute { Id = 556, PlayerId = 80, AttributeType = "Speed", Value = 71 },
new PlayerAttribute { Id = 557, PlayerId = 80, AttributeType = "Stamina", Value = 70 },
new PlayerAttribute { Id = 558, PlayerId = 80, AttributeType = "Mental", Value = 72 },
new PlayerAttribute { Id = 559, PlayerId = 80, AttributeType = "Volley", Value = 65 },
new PlayerAttribute { Id = 560, PlayerId = 80, AttributeType = "Return", Value = 67 },

// Taylor Townsend (USA)
new PlayerAttribute { Id = 561, PlayerId = 81, AttributeType = "Backhand", Value = 76 },
new PlayerAttribute { Id = 562, PlayerId = 81, AttributeType = "Forehand", Value = 78 },
new PlayerAttribute { Id = 563, PlayerId = 81, AttributeType = "Speed", Value = 75 },
new PlayerAttribute { Id = 564, PlayerId = 81, AttributeType = "Stamina", Value = 72 },
new PlayerAttribute { Id = 565, PlayerId = 81, AttributeType = "Mental", Value = 74 },
new PlayerAttribute { Id = 566, PlayerId = 81, AttributeType = "Volley", Value = 80 },
new PlayerAttribute { Id = 567, PlayerId = 81, AttributeType = "Return", Value = 70 },

// Ashlyn Krueger (USA)
new PlayerAttribute { Id = 568, PlayerId = 82, AttributeType = "Backhand", Value = 74 },
new PlayerAttribute { Id = 569, PlayerId = 82, AttributeType = "Forehand", Value = 76 },
new PlayerAttribute { Id = 570, PlayerId = 82, AttributeType = "Speed", Value = 77 },
new PlayerAttribute { Id = 571, PlayerId = 82, AttributeType = "Stamina", Value = 70 },
new PlayerAttribute { Id = 572, PlayerId = 82, AttributeType = "Mental", Value = 72 },
new PlayerAttribute { Id = 573, PlayerId = 82, AttributeType = "Volley", Value = 65 },
new PlayerAttribute { Id = 574, PlayerId = 82, AttributeType = "Return", Value = 68 },

// Viktorija Golubic (CHE)
new PlayerAttribute { Id = 575, PlayerId = 83, AttributeType = "Backhand", Value = 77 },
new PlayerAttribute { Id = 576, PlayerId = 83, AttributeType = "Forehand", Value = 79 },
new PlayerAttribute { Id = 577, PlayerId = 83, AttributeType = "Speed", Value = 70 },
new PlayerAttribute { Id = 578, PlayerId = 83, AttributeType = "Stamina", Value = 72 },
new PlayerAttribute { Id = 579, PlayerId = 83, AttributeType = "Mental", Value = 74 },
new PlayerAttribute { Id = 580, PlayerId = 83, AttributeType = "Volley", Value = 68 },
new PlayerAttribute { Id = 581, PlayerId = 83, AttributeType = "Return", Value = 69 },

// Tamara Korpatsch (DEU)
new PlayerAttribute { Id = 582, PlayerId = 84, AttributeType = "Backhand", Value = 75 },
new PlayerAttribute { Id = 583, PlayerId = 84, AttributeType = "Forehand", Value = 77 },
new PlayerAttribute { Id = 584, PlayerId = 84, AttributeType = "Speed", Value = 71 },
new PlayerAttribute { Id = 585, PlayerId = 84, AttributeType = "Stamina", Value = 69 },
new PlayerAttribute { Id = 586, PlayerId = 84, AttributeType = "Mental", Value = 73 },
new PlayerAttribute { Id = 587, PlayerId = 84, AttributeType = "Volley", Value = 64 },
new PlayerAttribute { Id = 588, PlayerId = 84, AttributeType = "Return", Value = 67 },

// Alycia Parks (USA)
new PlayerAttribute { Id = 589, PlayerId = 85, AttributeType = "Backhand", Value = 78 },
new PlayerAttribute { Id = 590, PlayerId = 85, AttributeType = "Forehand", Value = 80 },
new PlayerAttribute { Id = 591, PlayerId = 85, AttributeType = "Speed", Value = 74 },
new PlayerAttribute { Id = 592, PlayerId = 85, AttributeType = "Stamina", Value = 71 },
new PlayerAttribute { Id = 593, PlayerId = 85, AttributeType = "Mental", Value = 73 },
new PlayerAttribute { Id = 594, PlayerId = 85, AttributeType = "Volley", Value = 69 },
new PlayerAttribute { Id = 595, PlayerId = 85, AttributeType = "Return", Value = 71 },

// Laura Siegemund (DEU)
new PlayerAttribute { Id = 596, PlayerId = 86, AttributeType = "Backhand", Value = 76 },
new PlayerAttribute { Id = 597, PlayerId = 86, AttributeType = "Forehand", Value = 78 },
new PlayerAttribute { Id = 598, PlayerId = 86, AttributeType = "Speed", Value = 68 },
new PlayerAttribute { Id = 599, PlayerId = 86, AttributeType = "Stamina", Value = 70 },
new PlayerAttribute { Id = 600, PlayerId = 86, AttributeType = "Mental", Value = 74 },
new PlayerAttribute { Id = 601, PlayerId = 86, AttributeType = "Volley", Value = 67 },
new PlayerAttribute { Id = 602, PlayerId = 86, AttributeType = "Return", Value = 69 },

// Kayla Day (USA)
new PlayerAttribute { Id = 603, PlayerId = 87, AttributeType = "Backhand", Value = 75 },
new PlayerAttribute { Id = 604, PlayerId = 87, AttributeType = "Forehand", Value = 77 },
new PlayerAttribute { Id = 605, PlayerId = 87, AttributeType = "Speed", Value = 72 },
new PlayerAttribute { Id = 606, PlayerId = 87, AttributeType = "Stamina", Value = 70 },
new PlayerAttribute { Id = 607, PlayerId = 87, AttributeType = "Mental", Value = 73 },
new PlayerAttribute { Id = 608, PlayerId = 87, AttributeType = "Volley", Value = 66 },
new PlayerAttribute { Id = 609, PlayerId = 87, AttributeType = "Return", Value = 68 },

// Zhuoxuan Bai (CHN)
new PlayerAttribute { Id = 610, PlayerId = 88, AttributeType = "Backhand", Value = 74 },
new PlayerAttribute { Id = 611, PlayerId = 88, AttributeType = "Forehand", Value = 76 },
new PlayerAttribute { Id = 612, PlayerId = 88, AttributeType = "Speed", Value = 73 },
new PlayerAttribute { Id = 613, PlayerId = 88, AttributeType = "Stamina", Value = 69 },
new PlayerAttribute { Id = 614, PlayerId = 88, AttributeType = "Mental", Value = 72 },
new PlayerAttribute { Id = 615, PlayerId = 88, AttributeType = "Volley", Value = 65 },
new PlayerAttribute { Id = 616, PlayerId = 88, AttributeType = "Return", Value = 67 },

// Jaqueline Cristian (ROU)
new PlayerAttribute { Id = 617, PlayerId = 89, AttributeType = "Backhand", Value = 75 },
new PlayerAttribute { Id = 618, PlayerId = 89, AttributeType = "Forehand", Value = 77 },
new PlayerAttribute { Id = 619, PlayerId = 89, AttributeType = "Speed", Value = 71 },
new PlayerAttribute { Id = 620, PlayerId = 89, AttributeType = "Stamina", Value = 70 },
new PlayerAttribute { Id = 621, PlayerId = 89, AttributeType = "Mental", Value = 73 },
new PlayerAttribute { Id = 622, PlayerId = 89, AttributeType = "Volley", Value = 66 },
new PlayerAttribute { Id = 623, PlayerId = 89, AttributeType = "Return", Value = 68 },

// Aliaksandra Sasnovich (BLR)
new PlayerAttribute { Id = 624, PlayerId = 90, AttributeType = "Backhand", Value = 77 },
new PlayerAttribute { Id = 625, PlayerId = 90, AttributeType = "Forehand", Value = 79 },
new PlayerAttribute { Id = 626, PlayerId = 90, AttributeType = "Speed", Value = 72 },
new PlayerAttribute { Id = 627, PlayerId = 90, AttributeType = "Stamina", Value = 69 },
new PlayerAttribute { Id = 628, PlayerId = 90, AttributeType = "Mental", Value = 74 },
new PlayerAttribute { Id = 629, PlayerId = 90, AttributeType = "Volley", Value = 68 },
new PlayerAttribute { Id = 630, PlayerId = 90, AttributeType = "Return", Value = 70 },

// Emina Bektas (USA)
new PlayerAttribute { Id = 631, PlayerId = 91, AttributeType = "Backhand", Value = 75 },
new PlayerAttribute { Id = 632, PlayerId = 91, AttributeType = "Forehand", Value = 77 },
new PlayerAttribute { Id = 633, PlayerId = 91, AttributeType = "Speed", Value = 71 },
new PlayerAttribute { Id = 634, PlayerId = 91, AttributeType = "Stamina", Value = 69 },
new PlayerAttribute { Id = 635, PlayerId = 91, AttributeType = "Mental", Value = 72 },
new PlayerAttribute { Id = 636, PlayerId = 91, AttributeType = "Volley", Value = 66 },
new PlayerAttribute { Id = 637, PlayerId = 91, AttributeType = "Return", Value = 68 },

// Linda Fruhvirtova (CZE)
new PlayerAttribute { Id = 638, PlayerId = 92, AttributeType = "Backhand", Value = 78 },
new PlayerAttribute { Id = 639, PlayerId = 92, AttributeType = "Forehand", Value = 80 },
new PlayerAttribute { Id = 640, PlayerId = 92, AttributeType = "Speed", Value = 74 },
new PlayerAttribute { Id = 641, PlayerId = 92, AttributeType = "Stamina", Value = 72 },
new PlayerAttribute { Id = 642, PlayerId = 92, AttributeType = "Mental", Value = 75 },
new PlayerAttribute { Id = 643, PlayerId = 92, AttributeType = "Volley", Value = 69 },
new PlayerAttribute { Id = 644, PlayerId = 92, AttributeType = "Return", Value = 72 },

// Diana Shnaider (RUS)
new PlayerAttribute { Id = 645, PlayerId = 93, AttributeType = "Backhand", Value = 76 },
new PlayerAttribute { Id = 646, PlayerId = 93, AttributeType = "Forehand", Value = 78 },
new PlayerAttribute { Id = 647, PlayerId = 93, AttributeType = "Speed", Value = 74 },
new PlayerAttribute { Id = 648, PlayerId = 93, AttributeType = "Stamina", Value = 71 },
new PlayerAttribute { Id = 649, PlayerId = 93, AttributeType = "Mental", Value = 72 },
new PlayerAttribute { Id = 650, PlayerId = 93, AttributeType = "Volley", Value = 67 },
new PlayerAttribute { Id = 651, PlayerId = 93, AttributeType = "Return", Value = 69 },

// Nao Hibino (JPN)
new PlayerAttribute { Id = 652, PlayerId = 94, AttributeType = "Backhand", Value = 75 },
new PlayerAttribute { Id = 653, PlayerId = 94, AttributeType = "Forehand", Value = 77 },
new PlayerAttribute { Id = 654, PlayerId = 94, AttributeType = "Speed", Value = 71 },
new PlayerAttribute { Id = 655, PlayerId = 94, AttributeType = "Stamina", Value = 69 },
new PlayerAttribute { Id = 656, PlayerId = 94, AttributeType = "Mental", Value = 72 },
new PlayerAttribute { Id = 657, PlayerId = 94, AttributeType = "Volley", Value = 66 },
new PlayerAttribute { Id = 658, PlayerId = 94, AttributeType = "Return", Value = 68 },

// Bianca Vanessa Andreescu (CAN)
new PlayerAttribute { Id = 659, PlayerId = 95, AttributeType = "Backhand", Value = 79 },
new PlayerAttribute { Id = 660, PlayerId = 95, AttributeType = "Forehand", Value = 81 },
new PlayerAttribute { Id = 661, PlayerId = 95, AttributeType = "Speed", Value = 74 },
new PlayerAttribute { Id = 662, PlayerId = 95, AttributeType = "Stamina", Value = 72 },
new PlayerAttribute { Id = 663, PlayerId = 95, AttributeType = "Mental", Value = 76 },
new PlayerAttribute { Id = 664, PlayerId = 95, AttributeType = "Volley", Value = 70 },
new PlayerAttribute { Id = 665, PlayerId = 95, AttributeType = "Return", Value = 73 },

// Oceane Dodin (FRA)
new PlayerAttribute { Id = 666, PlayerId = 96, AttributeType = "Backhand", Value = 77 },
new PlayerAttribute { Id = 667, PlayerId = 96, AttributeType = "Forehand", Value = 79 },
new PlayerAttribute { Id = 668, PlayerId = 96, AttributeType = "Speed", Value = 72 },
new PlayerAttribute { Id = 669, PlayerId = 96, AttributeType = "Stamina", Value = 70 },
new PlayerAttribute { Id = 670, PlayerId = 96, AttributeType = "Mental", Value = 73 },
new PlayerAttribute { Id = 671, PlayerId = 96, AttributeType = "Volley", Value = 67 },
new PlayerAttribute { Id = 672, PlayerId = 96, AttributeType = "Return", Value = 69 },

// Jodie Anna Burrage (GBR)
new PlayerAttribute { Id = 673, PlayerId = 97, AttributeType = "Backhand", Value = 76 },
new PlayerAttribute { Id = 674, PlayerId = 97, AttributeType = "Forehand", Value = 78 },
new PlayerAttribute { Id = 675, PlayerId = 97, AttributeType = "Speed", Value = 73 },
new PlayerAttribute { Id = 676, PlayerId = 97, AttributeType = "Stamina", Value = 71 },
new PlayerAttribute { Id = 677, PlayerId = 97, AttributeType = "Mental", Value = 72 },
new PlayerAttribute { Id = 678, PlayerId = 97, AttributeType = "Volley", Value = 66 },
new PlayerAttribute { Id = 679, PlayerId = 97, AttributeType = "Return", Value = 69 },

// Claire Liu (USA)
new PlayerAttribute { Id = 680, PlayerId = 98, AttributeType = "Backhand", Value = 75 },
new PlayerAttribute { Id = 681, PlayerId = 98, AttributeType = "Forehand", Value = 77 },
new PlayerAttribute { Id = 682, PlayerId = 98, AttributeType = "Speed", Value = 70 },
new PlayerAttribute { Id = 683, PlayerId = 98, AttributeType = "Stamina", Value = 68 },
new PlayerAttribute { Id = 684, PlayerId = 98, AttributeType = "Mental", Value = 71 },
new PlayerAttribute { Id = 685, PlayerId = 98, AttributeType = "Volley", Value = 64 },
new PlayerAttribute { Id = 686, PlayerId = 98, AttributeType = "Return", Value = 67 },

// Kamilla Rakhimova (RUS)
new PlayerAttribute { Id = 687, PlayerId = 99, AttributeType = "Backhand", Value = 78 },
new PlayerAttribute { Id = 688, PlayerId = 99, AttributeType = "Forehand", Value = 80 },
new PlayerAttribute { Id = 689, PlayerId = 99, AttributeType = "Speed", Value = 74 },
new PlayerAttribute { Id = 690, PlayerId = 99, AttributeType = "Stamina", Value = 72 },
new PlayerAttribute { Id = 691, PlayerId = 99, AttributeType = "Mental", Value = 75 },
new PlayerAttribute { Id = 692, PlayerId = 99, AttributeType = "Volley", Value = 69 },
new PlayerAttribute { Id = 693, PlayerId = 99, AttributeType = "Return", Value = 71 },

// Yafan Wang (CHN)
new PlayerAttribute { Id = 694, PlayerId = 100, AttributeType = "Backhand", Value = 74 },
new PlayerAttribute { Id = 695, PlayerId = 100, AttributeType = "Forehand", Value = 76 },
new PlayerAttribute { Id = 696, PlayerId = 100, AttributeType = "Speed", Value = 70 },
new PlayerAttribute { Id = 697, PlayerId = 100, AttributeType = "Stamina", Value = 68 },
new PlayerAttribute { Id = 698, PlayerId = 100, AttributeType = "Mental", Value = 71 },
new PlayerAttribute { Id = 699, PlayerId = 100, AttributeType = "Volley", Value = 65 },
new PlayerAttribute { Id = 700, PlayerId = 100, AttributeType = "Return", Value = 68 },

// Julia Grabher (AUT)
new PlayerAttribute { Id = 701, PlayerId = 101, AttributeType = "Backhand", Value = 75 },
new PlayerAttribute { Id = 702, PlayerId = 101, AttributeType = "Forehand", Value = 77 },
new PlayerAttribute { Id = 703, PlayerId = 101, AttributeType = "Speed", Value = 71 },
new PlayerAttribute { Id = 704, PlayerId = 101, AttributeType = "Stamina", Value = 69 },
new PlayerAttribute { Id = 705, PlayerId = 101, AttributeType = "Mental", Value = 72 },
new PlayerAttribute { Id = 706, PlayerId = 101, AttributeType = "Volley", Value = 66 },
new PlayerAttribute { Id = 707, PlayerId = 101, AttributeType = "Return", Value = 68 },

// Dayana Yastremska (UKR)
new PlayerAttribute { Id = 708, PlayerId = 102, AttributeType = "Backhand", Value = 79 },
new PlayerAttribute { Id = 709, PlayerId = 102, AttributeType = "Forehand", Value = 81 },
new PlayerAttribute { Id = 710, PlayerId = 102, AttributeType = "Speed", Value = 75 },
new PlayerAttribute { Id = 711, PlayerId = 102, AttributeType = "Stamina", Value = 73 },
new PlayerAttribute { Id = 712, PlayerId = 102, AttributeType = "Mental", Value = 76 },
new PlayerAttribute { Id = 713, PlayerId = 102, AttributeType = "Volley", Value = 70 },
new PlayerAttribute { Id = 714, PlayerId = 102, AttributeType = "Return", Value = 72 },

// Tamara Zidansek (SVN)
new PlayerAttribute { Id = 715, PlayerId = 103, AttributeType = "Backhand", Value = 77 },
new PlayerAttribute { Id = 716, PlayerId = 103, AttributeType = "Forehand", Value = 79 },
new PlayerAttribute { Id = 717, PlayerId = 103, AttributeType = "Speed", Value = 73 },
new PlayerAttribute { Id = 718, PlayerId = 103, AttributeType = "Stamina", Value = 71 },
new PlayerAttribute { Id = 719, PlayerId = 103, AttributeType = "Mental", Value = 74 },
new PlayerAttribute { Id = 720, PlayerId = 103, AttributeType = "Volley", Value = 68 },
new PlayerAttribute { Id = 721, PlayerId = 103, AttributeType = "Return", Value = 70 },

// Renata Zarazua (MEX)
new PlayerAttribute { Id = 722, PlayerId = 104, AttributeType = "Backhand", Value = 75 },
new PlayerAttribute { Id = 723, PlayerId = 104, AttributeType = "Forehand", Value = 77 },
new PlayerAttribute { Id = 724, PlayerId = 104, AttributeType = "Speed", Value = 71 },
new PlayerAttribute { Id = 725, PlayerId = 104, AttributeType = "Stamina", Value = 69 },
new PlayerAttribute { Id = 726, PlayerId = 104, AttributeType = "Mental", Value = 72 },
new PlayerAttribute { Id = 727, PlayerId = 104, AttributeType = "Volley", Value = 66 },
new PlayerAttribute { Id = 728, PlayerId = 104, AttributeType = "Return", Value = 68 },

// Sara Errani (ITA)
new PlayerAttribute { Id = 729, PlayerId = 105, AttributeType = "Backhand", Value = 72 },
new PlayerAttribute { Id = 730, PlayerId = 105, AttributeType = "Forehand", Value = 74 },
new PlayerAttribute { Id = 731, PlayerId = 105, AttributeType = "Speed", Value = 68 },
new PlayerAttribute { Id = 732, PlayerId = 105, AttributeType = "Stamina", Value = 66 },
new PlayerAttribute { Id = 733, PlayerId = 105, AttributeType = "Mental", Value = 69 },
new PlayerAttribute { Id = 734, PlayerId = 105, AttributeType = "Volley", Value = 64 },
new PlayerAttribute { Id = 735, PlayerId = 105, AttributeType = "Return", Value = 67 },

// Kaja Juvan (SVN)
new PlayerAttribute { Id = 736, PlayerId = 106, AttributeType = "Backhand", Value = 77 },
new PlayerAttribute { Id = 737, PlayerId = 106, AttributeType = "Forehand", Value = 79 },
new PlayerAttribute { Id = 738, PlayerId = 106, AttributeType = "Speed", Value = 72 },
new PlayerAttribute { Id = 739, PlayerId = 106, AttributeType = "Stamina", Value = 70 },
new PlayerAttribute { Id = 740, PlayerId = 106, AttributeType = "Mental", Value = 73 },
new PlayerAttribute { Id = 741, PlayerId = 106, AttributeType = "Volley", Value = 67 },
new PlayerAttribute { Id = 742, PlayerId = 106, AttributeType = "Return", Value = 69 },

// Clara Tauson (DEN)
new PlayerAttribute { Id = 743, PlayerId = 107, AttributeType = "Backhand", Value = 78 },
new PlayerAttribute { Id = 744, PlayerId = 107, AttributeType = "Forehand", Value = 80 },
new PlayerAttribute { Id = 745, PlayerId = 107, AttributeType = "Speed", Value = 74 },
new PlayerAttribute { Id = 746, PlayerId = 107, AttributeType = "Stamina", Value = 72 },
new PlayerAttribute { Id = 747, PlayerId = 107, AttributeType = "Mental", Value = 75 },
new PlayerAttribute { Id = 748, PlayerId = 107, AttributeType = "Volley", Value = 69 },
new PlayerAttribute { Id = 749, PlayerId = 107, AttributeType = "Return", Value = 71 },

// Katie Volynets (USA)
new PlayerAttribute { Id = 750, PlayerId = 108, AttributeType = "Backhand", Value = 75 },
new PlayerAttribute { Id = 751, PlayerId = 108, AttributeType = "Forehand", Value = 77 },
new PlayerAttribute { Id = 752, PlayerId = 108, AttributeType = "Speed", Value = 70 },
new PlayerAttribute { Id = 753, PlayerId = 108, AttributeType = "Stamina", Value = 68 },
new PlayerAttribute { Id = 754, PlayerId = 108, AttributeType = "Mental", Value = 71 },
new PlayerAttribute { Id = 755, PlayerId = 108, AttributeType = "Volley", Value = 64 },
new PlayerAttribute { Id = 756, PlayerId = 108, AttributeType = "Return", Value = 67 },

// Marina Bassols Ribera (ESP)
new PlayerAttribute { Id = 757, PlayerId = 109, AttributeType = "Backhand", Value = 74 },
new PlayerAttribute { Id = 758, PlayerId = 109, AttributeType = "Forehand", Value = 76 },
new PlayerAttribute { Id = 759, PlayerId = 109, AttributeType = "Speed", Value = 69 },
new PlayerAttribute { Id = 760, PlayerId = 109, AttributeType = "Stamina", Value = 67 },
new PlayerAttribute { Id = 761, PlayerId = 109, AttributeType = "Mental", Value = 70 },
new PlayerAttribute { Id = 762, PlayerId = 109, AttributeType = "Volley", Value = 63 },
new PlayerAttribute { Id = 763, PlayerId = 109, AttributeType = "Return", Value = 65 },

// Laura Pigossi (BRA)
new PlayerAttribute { Id = 764, PlayerId = 110, AttributeType = "Backhand", Value = 76 },
new PlayerAttribute { Id = 765, PlayerId = 110, AttributeType = "Forehand", Value = 78 },
new PlayerAttribute { Id = 766, PlayerId = 110, AttributeType = "Speed", Value = 72 },
new PlayerAttribute { Id = 767, PlayerId = 110, AttributeType = "Stamina", Value = 70 },
new PlayerAttribute { Id = 768, PlayerId = 110, AttributeType = "Mental", Value = 73 },
new PlayerAttribute { Id = 769, PlayerId = 110, AttributeType = "Volley", Value = 68 },
new PlayerAttribute { Id = 770, PlayerId = 110, AttributeType = "Return", Value = 70 },

// Brenda Fruhvirtova (CZE)
new PlayerAttribute { Id = 771, PlayerId = 111, AttributeType = "Backhand", Value = 80 },
new PlayerAttribute { Id = 772, PlayerId = 111, AttributeType = "Forehand", Value = 82 },
new PlayerAttribute { Id = 773, PlayerId = 111, AttributeType = "Speed", Value = 76 },
new PlayerAttribute { Id = 774, PlayerId = 111, AttributeType = "Stamina", Value = 74 },
new PlayerAttribute { Id = 775, PlayerId = 111, AttributeType = "Mental", Value = 77 },
new PlayerAttribute { Id = 776, PlayerId = 111, AttributeType = "Volley", Value = 71 },
new PlayerAttribute { Id = 777, PlayerId = 111, AttributeType = "Return", Value = 73 },

// Erika Andreeva (RUS)
new PlayerAttribute { Id = 778, PlayerId = 112, AttributeType = "Backhand", Value = 78 },
new PlayerAttribute { Id = 779, PlayerId = 112, AttributeType = "Forehand", Value = 80 },
new PlayerAttribute { Id = 780, PlayerId = 112, AttributeType = "Speed", Value = 74 },
new PlayerAttribute { Id = 781, PlayerId = 112, AttributeType = "Stamina", Value = 72 },
new PlayerAttribute { Id = 782, PlayerId = 112, AttributeType = "Mental", Value = 75 },
new PlayerAttribute { Id = 783, PlayerId = 112, AttributeType = "Volley", Value = 69 },
new PlayerAttribute { Id = 784, PlayerId = 112, AttributeType = "Return", Value = 71 },

// Elizabeth Mandlik (USA)
new PlayerAttribute { Id = 785, PlayerId = 113, AttributeType = "Backhand", Value = 74 },
new PlayerAttribute { Id = 786, PlayerId = 113, AttributeType = "Forehand", Value = 76 },
new PlayerAttribute { Id = 787, PlayerId = 113, AttributeType = "Speed", Value = 70 },
new PlayerAttribute { Id = 788, PlayerId = 113, AttributeType = "Stamina", Value = 68 },
new PlayerAttribute { Id = 789, PlayerId = 113, AttributeType = "Mental", Value = 71 },
new PlayerAttribute { Id = 790, PlayerId = 113, AttributeType = "Volley", Value = 65 },
new PlayerAttribute { Id = 791, PlayerId = 113, AttributeType = "Return", Value = 67 },

// Arina Rodionova (AUS)
new PlayerAttribute { Id = 792, PlayerId = 114, AttributeType = "Backhand", Value = 75 },
new PlayerAttribute { Id = 793, PlayerId = 114, AttributeType = "Forehand", Value = 77 },
new PlayerAttribute { Id = 794, PlayerId = 114, AttributeType = "Speed", Value = 71 },
new PlayerAttribute { Id = 795, PlayerId = 114, AttributeType = "Stamina", Value = 69 },
new PlayerAttribute { Id = 796, PlayerId = 114, AttributeType = "Mental", Value = 72 },
new PlayerAttribute { Id = 797, PlayerId = 114, AttributeType = "Volley", Value = 66 },
new PlayerAttribute { Id = 798, PlayerId = 114, AttributeType = "Return", Value = 68 },

// Kimberly Birrell (AUS)
new PlayerAttribute { Id = 799, PlayerId = 115, AttributeType = "Backhand", Value = 74 },
new PlayerAttribute { Id = 800, PlayerId = 115, AttributeType = "Forehand", Value = 76 },
new PlayerAttribute { Id = 801, PlayerId = 115, AttributeType = "Speed", Value = 71 },
new PlayerAttribute { Id = 802, PlayerId = 115, AttributeType = "Stamina", Value = 69 },
new PlayerAttribute { Id = 803, PlayerId = 115, AttributeType = "Mental", Value = 72 },
new PlayerAttribute { Id = 804, PlayerId = 115, AttributeType = "Volley", Value = 65 },
new PlayerAttribute { Id = 805, PlayerId = 115, AttributeType = "Return", Value = 67 },

// Emiliana Arango (COL)
new PlayerAttribute { Id = 806, PlayerId = 116, AttributeType = "Backhand", Value = 76 },
new PlayerAttribute { Id = 807, PlayerId = 116, AttributeType = "Forehand", Value = 78 },
new PlayerAttribute { Id = 808, PlayerId = 116, AttributeType = "Speed", Value = 73 },
new PlayerAttribute { Id = 809, PlayerId = 116, AttributeType = "Stamina", Value = 71 },
new PlayerAttribute { Id = 810, PlayerId = 116, AttributeType = "Mental", Value = 74 },
new PlayerAttribute { Id = 811, PlayerId = 116, AttributeType = "Volley", Value = 68 },
new PlayerAttribute { Id = 812, PlayerId = 116, AttributeType = "Return", Value = 70 },

// Alize Cornet (FRA)
new PlayerAttribute { Id = 813, PlayerId = 117, AttributeType = "Backhand", Value = 74 },
new PlayerAttribute { Id = 814, PlayerId = 117, AttributeType = "Forehand", Value = 76 },
new PlayerAttribute { Id = 815, PlayerId = 117, AttributeType = "Speed", Value = 70 },
new PlayerAttribute { Id = 816, PlayerId = 117, AttributeType = "Stamina", Value = 72 },
new PlayerAttribute { Id = 817, PlayerId = 117, AttributeType = "Mental", Value = 74 },
new PlayerAttribute { Id = 818, PlayerId = 117, AttributeType = "Volley", Value = 66 },
new PlayerAttribute { Id = 819, PlayerId = 117, AttributeType = "Return", Value = 68 },

// Anna Bondar (HUN)
new PlayerAttribute { Id = 820, PlayerId = 118, AttributeType = "Backhand", Value = 75 },
new PlayerAttribute { Id = 821, PlayerId = 118, AttributeType = "Forehand", Value = 77 },
new PlayerAttribute { Id = 822, PlayerId = 118, AttributeType = "Speed", Value = 71 },
new PlayerAttribute { Id = 823, PlayerId = 118, AttributeType = "Stamina", Value = 69 },
new PlayerAttribute { Id = 824, PlayerId = 118, AttributeType = "Mental", Value = 72 },
new PlayerAttribute { Id = 825, PlayerId = 118, AttributeType = "Volley", Value = 65 },
new PlayerAttribute { Id = 826, PlayerId = 118, AttributeType = "Return", Value = 67 },

// Olga Danilovic (SRB)
new PlayerAttribute { Id = 827, PlayerId = 119, AttributeType = "Backhand", Value = 77 },
new PlayerAttribute { Id = 828, PlayerId = 119, AttributeType = "Forehand", Value = 79 },
new PlayerAttribute { Id = 829, PlayerId = 119, AttributeType = "Speed", Value = 73 },
new PlayerAttribute { Id = 830, PlayerId = 119, AttributeType = "Stamina", Value = 71 },
new PlayerAttribute { Id = 831, PlayerId = 119, AttributeType = "Mental", Value = 74 },
new PlayerAttribute { Id = 832, PlayerId = 119, AttributeType = "Volley", Value = 68 },
new PlayerAttribute { Id = 833, PlayerId = 119, AttributeType = "Return", Value = 70 },

// Mai Hontama (JPN)
new PlayerAttribute { Id = 834, PlayerId = 120, AttributeType = "Backhand", Value = 73 },
new PlayerAttribute { Id = 835, PlayerId = 120, AttributeType = "Forehand", Value = 75 },
new PlayerAttribute { Id = 836, PlayerId = 120, AttributeType = "Speed", Value = 69 },
new PlayerAttribute { Id = 837, PlayerId = 120, AttributeType = "Stamina", Value = 67 },
new PlayerAttribute { Id = 838, PlayerId = 120, AttributeType = "Mental", Value = 70 },
new PlayerAttribute { Id = 839, PlayerId = 120, AttributeType = "Volley", Value = 63 },
new PlayerAttribute { Id = 840, PlayerId = 120, AttributeType = "Return", Value = 65 },

// Harriet Dart (GBR)
new PlayerAttribute { Id = 841, PlayerId = 121, AttributeType = "Backhand", Value = 74 },
new PlayerAttribute { Id = 842, PlayerId = 121, AttributeType = "Forehand", Value = 76 },
new PlayerAttribute { Id = 843, PlayerId = 121, AttributeType = "Speed", Value = 71 },
new PlayerAttribute { Id = 844, PlayerId = 121, AttributeType = "Stamina", Value = 69 },
new PlayerAttribute { Id = 845, PlayerId = 121, AttributeType = "Mental", Value = 72 },
new PlayerAttribute { Id = 846, PlayerId = 121, AttributeType = "Volley", Value = 65 },
new PlayerAttribute { Id = 847, PlayerId = 121, AttributeType = "Return", Value = 67 },

// Maria Lourdes Carle (ARG)
new PlayerAttribute { Id = 848, PlayerId = 122, AttributeType = "Backhand", Value = 72 },
new PlayerAttribute { Id = 849, PlayerId = 122, AttributeType = "Forehand", Value = 74 },
new PlayerAttribute { Id = 850, PlayerId = 122, AttributeType = "Speed", Value = 68 },
new PlayerAttribute { Id = 851, PlayerId = 122, AttributeType = "Stamina", Value = 66 },
new PlayerAttribute { Id = 852, PlayerId = 122, AttributeType = "Mental", Value = 69 },
new PlayerAttribute { Id = 853, PlayerId = 122, AttributeType = "Volley", Value = 62 },
new PlayerAttribute { Id = 854, PlayerId = 122, AttributeType = "Return", Value = 64 },

// Lucrezia Stefanini (ITA)
new PlayerAttribute { Id = 855, PlayerId = 123, AttributeType = "Backhand", Value = 73 },
new PlayerAttribute { Id = 856, PlayerId = 123, AttributeType = "Forehand", Value = 75 },
new PlayerAttribute { Id = 857, PlayerId = 123, AttributeType = "Speed", Value = 69 },
new PlayerAttribute { Id = 858, PlayerId = 123, AttributeType = "Stamina", Value = 67 },
new PlayerAttribute { Id = 859, PlayerId = 123, AttributeType = "Mental", Value = 70 },
new PlayerAttribute { Id = 860, PlayerId = 123, AttributeType = "Volley", Value = 64 },
new PlayerAttribute { Id = 861, PlayerId = 123, AttributeType = "Return", Value = 66 },

// Astra Sharma (AUS)
new PlayerAttribute { Id = 862, PlayerId = 124, AttributeType = "Backhand", Value = 75 },
new PlayerAttribute { Id = 863, PlayerId = 124, AttributeType = "Forehand", Value = 77 },
new PlayerAttribute { Id = 864, PlayerId = 124, AttributeType = "Speed", Value = 71 },
new PlayerAttribute { Id = 865, PlayerId = 124, AttributeType = "Stamina", Value = 69 },
new PlayerAttribute { Id = 866, PlayerId = 124, AttributeType = "Mental", Value = 72 },
new PlayerAttribute { Id = 867, PlayerId = 124, AttributeType = "Volley", Value = 65 },
new PlayerAttribute { Id = 868, PlayerId = 124, AttributeType = "Return", Value = 67 },

// Nuria Parrizas-Diaz (ESP)
new PlayerAttribute { Id = 869, PlayerId = 125, AttributeType = "Backhand", Value = 73 },
new PlayerAttribute { Id = 870, PlayerId = 125, AttributeType = "Forehand", Value = 75 },
new PlayerAttribute { Id = 871, PlayerId = 125, AttributeType = "Speed", Value = 69 },
new PlayerAttribute { Id = 872, PlayerId = 125, AttributeType = "Stamina", Value = 67 },
new PlayerAttribute { Id = 873, PlayerId = 125, AttributeType = "Mental", Value = 70 },
new PlayerAttribute { Id = 874, PlayerId = 125, AttributeType = "Volley", Value = 64 },
new PlayerAttribute { Id = 875, PlayerId = 125, AttributeType = "Return", Value = 66 },

// Olivia Gadecki (AUS)
new PlayerAttribute { Id = 876, PlayerId = 126, AttributeType = "Backhand", Value = 72 },
new PlayerAttribute { Id = 877, PlayerId = 126, AttributeType = "Forehand", Value = 74 },
new PlayerAttribute { Id = 878, PlayerId = 126, AttributeType = "Speed", Value = 68 },
new PlayerAttribute { Id = 879, PlayerId = 126, AttributeType = "Stamina", Value = 66 },
new PlayerAttribute { Id = 880, PlayerId = 126, AttributeType = "Mental", Value = 69 },
new PlayerAttribute { Id = 881, PlayerId = 126, AttributeType = "Volley", Value = 62 },
new PlayerAttribute { Id = 882, PlayerId = 126, AttributeType = "Return", Value = 64 },

// Rebecca Peterson (SWE)
new PlayerAttribute { Id = 883, PlayerId = 127, AttributeType = "Backhand", Value = 74 },
new PlayerAttribute { Id = 884, PlayerId = 127, AttributeType = "Forehand", Value = 76 },
new PlayerAttribute { Id = 885, PlayerId = 127, AttributeType = "Speed", Value = 70 },
new PlayerAttribute { Id = 886, PlayerId = 127, AttributeType = "Stamina", Value = 68 },
new PlayerAttribute { Id = 887, PlayerId = 127, AttributeType = "Mental", Value = 71 },
new PlayerAttribute { Id = 888, PlayerId = 127, AttributeType = "Volley", Value = 63 },
new PlayerAttribute { Id = 889, PlayerId = 127, AttributeType = "Return", Value = 65 },

// Elena Gabriela Ruse (ROU)
new PlayerAttribute { Id = 890, PlayerId = 128, AttributeType = "Backhand", Value = 75 },
new PlayerAttribute { Id = 891, PlayerId = 128, AttributeType = "Forehand", Value = 77 },
new PlayerAttribute { Id = 892, PlayerId = 128, AttributeType = "Speed", Value = 71 },
new PlayerAttribute { Id = 893, PlayerId = 128, AttributeType = "Stamina", Value = 69 },
new PlayerAttribute { Id = 894, PlayerId = 128, AttributeType = "Mental", Value = 72 },
new PlayerAttribute { Id = 895, PlayerId = 128, AttributeType = "Volley", Value = 64 },
new PlayerAttribute { Id = 896, PlayerId = 128, AttributeType = "Return", Value = 66 },

// Sara Bejlek (CZE)
new PlayerAttribute { Id = 897, PlayerId = 129, AttributeType = "Backhand", Value = 72 },
new PlayerAttribute { Id = 898, PlayerId = 129, AttributeType = "Forehand", Value = 74 },
new PlayerAttribute { Id = 899, PlayerId = 129, AttributeType = "Speed", Value = 68 },
new PlayerAttribute { Id = 900, PlayerId = 129, AttributeType = "Stamina", Value = 66 },
new PlayerAttribute { Id = 901, PlayerId = 129, AttributeType = "Mental", Value = 69 },
new PlayerAttribute { Id = 902, PlayerId = 129, AttributeType = "Volley", Value = 62 },
new PlayerAttribute { Id = 903, PlayerId = 129, AttributeType = "Return", Value = 64 },

// Rebecca Sramkova (SVK)
new PlayerAttribute { Id = 904, PlayerId = 130, AttributeType = "Backhand", Value = 74 },
new PlayerAttribute { Id = 905, PlayerId = 130, AttributeType = "Forehand", Value = 76 },
new PlayerAttribute { Id = 906, PlayerId = 130, AttributeType = "Speed", Value = 70 },
new PlayerAttribute { Id = 907, PlayerId = 130, AttributeType = "Stamina", Value = 68 },
new PlayerAttribute { Id = 908, PlayerId = 130, AttributeType = "Mental", Value = 71 },
new PlayerAttribute { Id = 909, PlayerId = 130, AttributeType = "Volley", Value = 63 },
new PlayerAttribute { Id = 910, PlayerId = 130, AttributeType = "Return", Value = 65 },

// Hailey Baptiste (USA)
new PlayerAttribute { Id = 911, PlayerId = 131, AttributeType = "Backhand", Value = 75 },
new PlayerAttribute { Id = 912, PlayerId = 131, AttributeType = "Forehand", Value = 77 },
new PlayerAttribute { Id = 913, PlayerId = 131, AttributeType = "Speed", Value = 71 },
new PlayerAttribute { Id = 914, PlayerId = 131, AttributeType = "Stamina", Value = 69 },
new PlayerAttribute { Id = 915, PlayerId = 131, AttributeType = "Mental", Value = 72 },
new PlayerAttribute { Id = 916, PlayerId = 131, AttributeType = "Volley", Value = 64 },
new PlayerAttribute { Id = 917, PlayerId = 131, AttributeType = "Return", Value = 66 },

// Kateryna Baindl (UKR)
new PlayerAttribute { Id = 918, PlayerId = 132, AttributeType = "Backhand", Value = 74 },
new PlayerAttribute { Id = 919, PlayerId = 132, AttributeType = "Forehand", Value = 76 },
new PlayerAttribute { Id = 920, PlayerId = 132, AttributeType = "Speed", Value = 70 },
new PlayerAttribute { Id = 921, PlayerId = 132, AttributeType = "Stamina", Value = 68 },
new PlayerAttribute { Id = 922, PlayerId = 132, AttributeType = "Mental", Value = 71 },
new PlayerAttribute { Id = 923, PlayerId = 132, AttributeType = "Volley", Value = 63 },
new PlayerAttribute { Id = 924, PlayerId = 132, AttributeType = "Return", Value = 65 },

// Jessika Ponchet (FRA)
new PlayerAttribute { Id = 925, PlayerId = 133, AttributeType = "Backhand", Value = 72 },
new PlayerAttribute { Id = 926, PlayerId = 133, AttributeType = "Forehand", Value = 74 },
new PlayerAttribute { Id = 927, PlayerId = 133, AttributeType = "Speed", Value = 68 },
new PlayerAttribute { Id = 928, PlayerId = 133, AttributeType = "Stamina", Value = 66 },
new PlayerAttribute { Id = 929, PlayerId = 133, AttributeType = "Mental", Value = 69 },
new PlayerAttribute { Id = 930, PlayerId = 133, AttributeType = "Volley", Value = 62 },
new PlayerAttribute { Id = 931, PlayerId = 133, AttributeType = "Return", Value = 64 },

// Daria Snigur (UKR)
new PlayerAttribute { Id = 932, PlayerId = 134, AttributeType = "Backhand", Value = 75 },
new PlayerAttribute { Id = 933, PlayerId = 134, AttributeType = "Forehand", Value = 77 },
new PlayerAttribute { Id = 934, PlayerId = 134, AttributeType = "Speed", Value = 71 },
new PlayerAttribute { Id = 935, PlayerId = 134, AttributeType = "Stamina", Value = 69 },
new PlayerAttribute { Id = 936, PlayerId = 134, AttributeType = "Mental", Value = 72 },
new PlayerAttribute { Id = 937, PlayerId = 134, AttributeType = "Volley", Value = 64 },
new PlayerAttribute { Id = 938, PlayerId = 134, AttributeType = "Return", Value = 66 },

// Anna-Lena Friedsam (DEU)
new PlayerAttribute { Id = 939, PlayerId = 135, AttributeType = "Backhand", Value = 74 },
new PlayerAttribute { Id = 940, PlayerId = 135, AttributeType = "Forehand", Value = 76 },
new PlayerAttribute { Id = 941, PlayerId = 135, AttributeType = "Speed", Value = 70 },
new PlayerAttribute { Id = 942, PlayerId = 135, AttributeType = "Stamina", Value = 68 },
new PlayerAttribute { Id = 943, PlayerId = 135, AttributeType = "Mental", Value = 71 },
new PlayerAttribute { Id = 944, PlayerId = 135, AttributeType = "Volley", Value = 63 },
new PlayerAttribute { Id = 945, PlayerId = 135, AttributeType = "Return", Value = 65 },

// Eva Lys (DEU)
new PlayerAttribute { Id = 946, PlayerId = 136, AttributeType = "Backhand", Value = 73 },
new PlayerAttribute { Id = 947, PlayerId = 136, AttributeType = "Forehand", Value = 75 },
new PlayerAttribute { Id = 948, PlayerId = 136, AttributeType = "Speed", Value = 69 },
new PlayerAttribute { Id = 949, PlayerId = 136, AttributeType = "Stamina", Value = 67 },
new PlayerAttribute { Id = 950, PlayerId = 136, AttributeType = "Mental", Value = 70 },
new PlayerAttribute { Id = 951, PlayerId = 136, AttributeType = "Volley", Value = 62 },
new PlayerAttribute { Id = 952, PlayerId = 136, AttributeType = "Return", Value = 64 },

// Heather Watson (GBR)
new PlayerAttribute { Id = 953, PlayerId = 137, AttributeType = "Backhand", Value = 76 },
new PlayerAttribute { Id = 954, PlayerId = 137, AttributeType = "Forehand", Value = 78 },
new PlayerAttribute { Id = 955, PlayerId = 137, AttributeType = "Speed", Value = 72 },
new PlayerAttribute { Id = 956, PlayerId = 137, AttributeType = "Stamina", Value = 70 },
new PlayerAttribute { Id = 957, PlayerId = 137, AttributeType = "Mental", Value = 73 },
new PlayerAttribute { Id = 958, PlayerId = 137, AttributeType = "Volley", Value = 65 },
new PlayerAttribute { Id = 959, PlayerId = 137, AttributeType = "Return", Value = 67 },

// Viktoria Hruncakova (SVK)
new PlayerAttribute { Id = 960, PlayerId = 138, AttributeType = "Backhand", Value = 74 },
new PlayerAttribute { Id = 961, PlayerId = 138, AttributeType = "Forehand", Value = 76 },
new PlayerAttribute { Id = 962, PlayerId = 138, AttributeType = "Speed", Value = 70 },
new PlayerAttribute { Id = 963, PlayerId = 138, AttributeType = "Stamina", Value = 68 },
new PlayerAttribute { Id = 964, PlayerId = 138, AttributeType = "Mental", Value = 71 },
new PlayerAttribute { Id = 965, PlayerId = 138, AttributeType = "Volley", Value = 63 },
new PlayerAttribute { Id = 966, PlayerId = 138, AttributeType = "Return", Value = 65 },

// Julia Riera (ARG)
new PlayerAttribute { Id = 967, PlayerId = 139, AttributeType = "Backhand", Value = 72 },
new PlayerAttribute { Id = 968, PlayerId = 139, AttributeType = "Forehand", Value = 74 },
new PlayerAttribute { Id = 969, PlayerId = 139, AttributeType = "Speed", Value = 68 },
new PlayerAttribute { Id = 970, PlayerId = 139, AttributeType = "Stamina", Value = 66 },
new PlayerAttribute { Id = 971, PlayerId = 139, AttributeType = "Mental", Value = 69 },
new PlayerAttribute { Id = 972, PlayerId = 139, AttributeType = "Volley", Value = 62 },
new PlayerAttribute { Id = 973, PlayerId = 139, AttributeType = "Return", Value = 64 },

// Darja Semenistaja (LVA)
new PlayerAttribute { Id = 974, PlayerId = 140, AttributeType = "Backhand", Value = 73 },
new PlayerAttribute { Id = 975, PlayerId = 140, AttributeType = "Forehand", Value = 75 },
new PlayerAttribute { Id = 976, PlayerId = 140, AttributeType = "Speed", Value = 69 },
new PlayerAttribute { Id = 977, PlayerId = 140, AttributeType = "Stamina", Value = 67 },
new PlayerAttribute { Id = 978, PlayerId = 140, AttributeType = "Mental", Value = 70 },
new PlayerAttribute { Id = 979, PlayerId = 140, AttributeType = "Volley", Value = 62 },
new PlayerAttribute { Id = 980, PlayerId = 140, AttributeType = "Return", Value = 64 },

// Celine Naef (CHE)
new PlayerAttribute { Id = 981, PlayerId = 141, AttributeType = "Backhand", Value = 71 },
new PlayerAttribute { Id = 982, PlayerId = 141, AttributeType = "Forehand", Value = 73 },
new PlayerAttribute { Id = 983, PlayerId = 141, AttributeType = "Speed", Value = 67 },
new PlayerAttribute { Id = 984, PlayerId = 141, AttributeType = "Stamina", Value = 65 },
new PlayerAttribute { Id = 985, PlayerId = 141, AttributeType = "Mental", Value = 68 },
new PlayerAttribute { Id = 986, PlayerId = 141, AttributeType = "Volley", Value = 61 },
new PlayerAttribute { Id = 987, PlayerId = 141, AttributeType = "Return", Value = 63 },

// Dalma Galfi (HUN)
new PlayerAttribute { Id = 988, PlayerId = 142, AttributeType = "Backhand", Value = 70 },
new PlayerAttribute { Id = 989, PlayerId = 142, AttributeType = "Forehand", Value = 72 },
new PlayerAttribute { Id = 990, PlayerId = 142, AttributeType = "Speed", Value = 66 },
new PlayerAttribute { Id = 991, PlayerId = 142, AttributeType = "Stamina", Value = 64 },
new PlayerAttribute { Id = 992, PlayerId = 142, AttributeType = "Mental", Value = 67 },
new PlayerAttribute { Id = 993, PlayerId = 142, AttributeType = "Volley", Value = 60 },
new PlayerAttribute { Id = 994, PlayerId = 142, AttributeType = "Return", Value = 62 },

// Maria Timofeeva (RUS)
new PlayerAttribute { Id = 995, PlayerId = 143, AttributeType = "Backhand", Value = 69 },
new PlayerAttribute { Id = 996, PlayerId = 143, AttributeType = "Forehand", Value = 71 },
new PlayerAttribute { Id = 997, PlayerId = 143, AttributeType = "Speed", Value = 65 },
new PlayerAttribute { Id = 998, PlayerId = 143, AttributeType = "Stamina", Value = 63 },
new PlayerAttribute { Id = 999, PlayerId = 143, AttributeType = "Mental", Value = 66 },
new PlayerAttribute { Id = 1000, PlayerId = 143, AttributeType = "Volley", Value = 59 },
new PlayerAttribute { Id = 1001, PlayerId = 143, AttributeType = "Return", Value = 61 },

// Valeria Savinykh (RUS)
new PlayerAttribute { Id = 1002, PlayerId = 144, AttributeType = "Backhand", Value = 68 },
new PlayerAttribute { Id = 1003, PlayerId = 144, AttributeType = "Forehand", Value = 70 },
new PlayerAttribute { Id = 1004, PlayerId = 144, AttributeType = "Speed", Value = 64 },
new PlayerAttribute { Id = 1005, PlayerId = 144, AttributeType = "Stamina", Value = 62 },
new PlayerAttribute { Id = 1006, PlayerId = 144, AttributeType = "Mental", Value = 65 },
new PlayerAttribute { Id = 1007, PlayerId = 144, AttributeType = "Volley", Value = 58 },
new PlayerAttribute { Id = 1008, PlayerId = 144, AttributeType = "Return", Value = 63 },

// Katherine Sebov (CAN)
new PlayerAttribute { Id = 1009, PlayerId = 145, AttributeType = "Backhand", Value = 69 },
new PlayerAttribute { Id = 1010, PlayerId = 145, AttributeType = "Forehand", Value = 69 },
new PlayerAttribute { Id = 1011, PlayerId = 145, AttributeType = "Speed", Value = 63 },
new PlayerAttribute { Id = 1012, PlayerId = 145, AttributeType = "Stamina", Value = 61 },
new PlayerAttribute { Id = 1013, PlayerId = 145, AttributeType = "Mental", Value = 64 },
new PlayerAttribute { Id = 1014, PlayerId = 145, AttributeType = "Volley", Value = 62 },
new PlayerAttribute { Id = 1015, PlayerId = 145, AttributeType = "Return", Value = 59 },

// Sachia Vickery (USA)
new PlayerAttribute { Id = 1016, PlayerId = 146, AttributeType = "Backhand", Value = 66 },
new PlayerAttribute { Id = 1017, PlayerId = 146, AttributeType = "Forehand", Value = 68 },
new PlayerAttribute { Id = 1018, PlayerId = 146, AttributeType = "Speed", Value = 62 },
new PlayerAttribute { Id = 1019, PlayerId = 146, AttributeType = "Stamina", Value = 60 },
new PlayerAttribute { Id = 1020, PlayerId = 146, AttributeType = "Mental", Value = 63 },
new PlayerAttribute { Id = 1021, PlayerId = 146, AttributeType = "Volley", Value = 63 },
new PlayerAttribute { Id = 1022, PlayerId = 146, AttributeType = "Return", Value = 58 },

// Jil Teichmann (CHE)
new PlayerAttribute { Id = 1023, PlayerId = 147, AttributeType = "Backhand", Value = 65 },
new PlayerAttribute { Id = 1024, PlayerId = 147, AttributeType = "Forehand", Value = 67 },
new PlayerAttribute { Id = 1025, PlayerId = 147, AttributeType = "Speed", Value = 61 },
new PlayerAttribute { Id = 1026, PlayerId = 147, AttributeType = "Stamina", Value = 59 },
new PlayerAttribute { Id = 1027, PlayerId = 147, AttributeType = "Mental", Value = 62 },
new PlayerAttribute { Id = 1028, PlayerId = 147, AttributeType = "Volley", Value = 74 },
new PlayerAttribute { Id = 1029, PlayerId = 147, AttributeType = "Return", Value = 61 },

// Caty McNally (USA)
new PlayerAttribute { Id = 1030, PlayerId = 148, AttributeType = "Backhand", Value = 64 },
new PlayerAttribute { Id = 1031, PlayerId = 148, AttributeType = "Forehand", Value = 66 },
new PlayerAttribute { Id = 1032, PlayerId = 148, AttributeType = "Speed", Value = 60 },
new PlayerAttribute { Id = 1033, PlayerId = 148, AttributeType = "Stamina", Value = 58 },
new PlayerAttribute { Id = 1034, PlayerId = 148, AttributeType = "Mental", Value = 61 },
new PlayerAttribute { Id = 1035, PlayerId = 148, AttributeType = "Volley", Value = 80 },
new PlayerAttribute { Id = 1036, PlayerId = 148, AttributeType = "Return", Value = 63 },

// Shelby Rogers (USA)
new PlayerAttribute { Id = 1037, PlayerId = 149, AttributeType = "Backhand", Value = 66 },
new PlayerAttribute { Id = 1038, PlayerId = 149, AttributeType = "Forehand", Value = 65 },
new PlayerAttribute { Id = 1039, PlayerId = 149, AttributeType = "Speed", Value = 59 },
new PlayerAttribute { Id = 1040, PlayerId = 149, AttributeType = "Stamina", Value = 57 },
new PlayerAttribute { Id = 1041, PlayerId = 149, AttributeType = "Mental", Value = 60 },
new PlayerAttribute { Id = 1042, PlayerId = 149, AttributeType = "Volley", Value = 60 },
new PlayerAttribute { Id = 1043, PlayerId = 149, AttributeType = "Return", Value = 58 },

// Danka Kovinic (MNE)
new PlayerAttribute { Id = 1044, PlayerId = 150, AttributeType = "Backhand", Value = 62 },
new PlayerAttribute { Id = 1045, PlayerId = 150, AttributeType = "Forehand", Value = 64 },
new PlayerAttribute { Id = 1046, PlayerId = 150, AttributeType = "Speed", Value = 58 },
new PlayerAttribute { Id = 1047, PlayerId = 150, AttributeType = "Stamina", Value = 56 },
new PlayerAttribute { Id = 1048, PlayerId = 150, AttributeType = "Mental", Value = 59 },
new PlayerAttribute { Id = 1049, PlayerId = 150, AttributeType = "Volley", Value = 55 },
new PlayerAttribute { Id = 1050, PlayerId = 150, AttributeType = "Return", Value = 54 },

// Madison Brengle (USA)
new PlayerAttribute { Id = 1051, PlayerId = 151, AttributeType = "Backhand", Value = 56 },
new PlayerAttribute { Id = 1052, PlayerId = 151, AttributeType = "Forehand", Value = 65 },
new PlayerAttribute { Id = 1053, PlayerId = 151, AttributeType = "Speed", Value = 68 },
new PlayerAttribute { Id = 1054, PlayerId = 151, AttributeType = "Stamina", Value = 55 },
new PlayerAttribute { Id = 1055, PlayerId = 151, AttributeType = "Mental", Value = 58 },
new PlayerAttribute { Id = 1056, PlayerId = 151, AttributeType = "Volley", Value = 55 },
new PlayerAttribute { Id = 1057, PlayerId = 151, AttributeType = "Return", Value = 53 },

// Arianne Hartono (NLD)
new PlayerAttribute { Id = 1058, PlayerId = 152, AttributeType = "Backhand", Value = 60 },
new PlayerAttribute { Id = 1059, PlayerId = 152, AttributeType = "Forehand", Value = 62 },
new PlayerAttribute { Id = 1060, PlayerId = 152, AttributeType = "Speed", Value = 64 },
new PlayerAttribute { Id = 1061, PlayerId = 152, AttributeType = "Stamina", Value = 54 },
new PlayerAttribute { Id = 1062, PlayerId = 152, AttributeType = "Mental", Value = 57 },
new PlayerAttribute { Id = 1063, PlayerId = 152, AttributeType = "Volley", Value = 53 },
new PlayerAttribute { Id = 1064, PlayerId = 152, AttributeType = "Return", Value = 54 },

// Martina Capurro Taborda (ARG)
new PlayerAttribute { Id = 1065, PlayerId = 153, AttributeType = "Backhand", Value = 60 },
new PlayerAttribute { Id = 1066, PlayerId = 153, AttributeType = "Forehand", Value = 61 },
new PlayerAttribute { Id = 1067, PlayerId = 153, AttributeType = "Speed", Value = 55 },
new PlayerAttribute { Id = 1068, PlayerId = 153, AttributeType = "Stamina", Value = 53 },
new PlayerAttribute { Id = 1069, PlayerId = 153, AttributeType = "Mental", Value = 60 },
new PlayerAttribute { Id = 1070, PlayerId = 153, AttributeType = "Volley", Value = 63 },
new PlayerAttribute { Id = 1071, PlayerId = 153, AttributeType = "Return", Value = 51 },

// Leolia Jeanjean (FRA)
new PlayerAttribute { Id = 1072, PlayerId = 154, AttributeType = "Backhand", Value = 62 },
new PlayerAttribute { Id = 1073, PlayerId = 154, AttributeType = "Forehand", Value = 60 },
new PlayerAttribute { Id = 1074, PlayerId = 154, AttributeType = "Speed", Value = 54 },
new PlayerAttribute { Id = 1075, PlayerId = 154, AttributeType = "Stamina", Value = 52 },
new PlayerAttribute { Id = 1076, PlayerId = 154, AttributeType = "Mental", Value = 60 },
new PlayerAttribute { Id = 1077, PlayerId = 154, AttributeType = "Volley", Value = 54 },
new PlayerAttribute { Id = 1078, PlayerId = 154, AttributeType = "Return", Value = 65 },

// Tereza Martincova (CZE)
new PlayerAttribute { Id = 1079, PlayerId = 155, AttributeType = "Backhand", Value = 62 },
new PlayerAttribute { Id = 1080, PlayerId = 155, AttributeType = "Forehand", Value = 59 },
new PlayerAttribute { Id = 1081, PlayerId = 155, AttributeType = "Speed", Value = 53 },
new PlayerAttribute { Id = 1082, PlayerId = 155, AttributeType = "Stamina", Value = 51 },
new PlayerAttribute { Id = 1083, PlayerId = 155, AttributeType = "Mental", Value = 54 },
new PlayerAttribute { Id = 1084, PlayerId = 155, AttributeType = "Volley", Value = 65 },
new PlayerAttribute { Id = 1085, PlayerId = 155, AttributeType = "Return", Value = 65 },

// Yuliia Starodubtseva (UKR)
new PlayerAttribute { Id = 1086, PlayerId = 156, AttributeType = "Backhand", Value = 69 },
new PlayerAttribute { Id = 1087, PlayerId = 156, AttributeType = "Forehand", Value = 85 },
new PlayerAttribute { Id = 1088, PlayerId = 156, AttributeType = "Speed", Value = 52 },
new PlayerAttribute { Id = 1089, PlayerId = 156, AttributeType = "Stamina", Value = 56 },
new PlayerAttribute { Id = 1090, PlayerId = 156, AttributeType = "Mental", Value = 58 },
new PlayerAttribute { Id = 1091, PlayerId = 156, AttributeType = "Volley", Value = 64 },
new PlayerAttribute { Id = 1092, PlayerId = 156, AttributeType = "Return", Value = 48 },

// Chloe Paquet (FRA)
new PlayerAttribute { Id = 1093, PlayerId = 157, AttributeType = "Backhand", Value = 59 },
new PlayerAttribute { Id = 1094, PlayerId = 157, AttributeType = "Forehand", Value = 57 },
new PlayerAttribute { Id = 1095, PlayerId = 157, AttributeType = "Speed", Value = 58 },
new PlayerAttribute { Id = 1096, PlayerId = 157, AttributeType = "Stamina", Value = 49 },
new PlayerAttribute { Id = 1097, PlayerId = 157, AttributeType = "Mental", Value = 59 },
new PlayerAttribute { Id = 1098, PlayerId = 157, AttributeType = "Volley", Value = 59 },
new PlayerAttribute { Id = 1099, PlayerId = 157, AttributeType = "Return", Value = 52 },

// Anastasia Tikhonova (RUS)
new PlayerAttribute { Id = 1100, PlayerId = 158, AttributeType = "Backhand", Value = 59 },
new PlayerAttribute { Id = 1101, PlayerId = 158, AttributeType = "Forehand", Value = 56 },
new PlayerAttribute { Id = 1102, PlayerId = 158, AttributeType = "Speed", Value = 50 },
new PlayerAttribute { Id = 1103, PlayerId = 158, AttributeType = "Stamina", Value = 48 },
new PlayerAttribute { Id = 1104, PlayerId = 158, AttributeType = "Mental", Value = 51 },
new PlayerAttribute { Id = 1105, PlayerId = 158, AttributeType = "Volley", Value = 50 },
new PlayerAttribute { Id = 1106, PlayerId = 158, AttributeType = "Return", Value = 46 },

// Jessica Bouzas Maneiro (ESP)
new PlayerAttribute { Id = 1107, PlayerId = 159, AttributeType = "Backhand", Value = 73 },
new PlayerAttribute { Id = 1108, PlayerId = 159, AttributeType = "Forehand", Value = 75 },
new PlayerAttribute { Id = 1109, PlayerId = 159, AttributeType = "Speed", Value = 53 },
new PlayerAttribute { Id = 1110, PlayerId = 159, AttributeType = "Stamina", Value = 55 },
new PlayerAttribute { Id = 1111, PlayerId = 159, AttributeType = "Mental", Value = 55 },
new PlayerAttribute { Id = 1112, PlayerId = 159, AttributeType = "Volley", Value = 43 },
new PlayerAttribute { Id = 1113, PlayerId = 159, AttributeType = "Return", Value = 52 },

// Panna Udvardy (HUN)
new PlayerAttribute { Id = 1114, PlayerId = 160, AttributeType = "Backhand", Value = 62 },
new PlayerAttribute { Id = 1115, PlayerId = 160, AttributeType = "Forehand", Value = 54 },
new PlayerAttribute { Id = 1116, PlayerId = 160, AttributeType = "Speed", Value = 48 },
new PlayerAttribute { Id = 1117, PlayerId = 160, AttributeType = "Stamina", Value = 46 },
new PlayerAttribute { Id = 1118, PlayerId = 160, AttributeType = "Mental", Value = 49 },
new PlayerAttribute { Id = 1119, PlayerId = 160, AttributeType = "Volley", Value = 64 },
new PlayerAttribute { Id = 1120, PlayerId = 160, AttributeType = "Return", Value = 48 },

// Fiona Ferro (FRA)
new PlayerAttribute { Id = 1160, PlayerId = 161, AttributeType = "Backhand", Value = 48 },
new PlayerAttribute { Id = 1161, PlayerId = 161, AttributeType = "Forehand", Value = 68 },
new PlayerAttribute { Id = 1162, PlayerId = 161, AttributeType = "Speed", Value = 53 },
new PlayerAttribute { Id = 1163, PlayerId = 161, AttributeType = "Stamina", Value = 56 },
new PlayerAttribute { Id = 1164, PlayerId = 161, AttributeType = "Mental", Value = 45 },
new PlayerAttribute { Id = 1165, PlayerId = 161, AttributeType = "Volley", Value = 45 },
new PlayerAttribute { Id = 1166, PlayerId = 161, AttributeType = "Return", Value = 49 },

// Su Jeong Jang (KOR)
new PlayerAttribute { Id = 1167, PlayerId = 162, AttributeType = "Backhand", Value = 49 },
new PlayerAttribute { Id = 1168, PlayerId = 162, AttributeType = "Forehand", Value = 53 },
new PlayerAttribute { Id = 1169, PlayerId = 162, AttributeType = "Speed", Value = 49 },
new PlayerAttribute { Id = 1170, PlayerId = 162, AttributeType = "Stamina", Value = 58 },
new PlayerAttribute { Id = 1171, PlayerId = 162, AttributeType = "Mental", Value = 74 },
new PlayerAttribute { Id = 1172, PlayerId = 162, AttributeType = "Volley", Value = 35 },
new PlayerAttribute { Id = 1173, PlayerId = 162, AttributeType = "Return", Value = 54 },

// Gabriela Andrea Knutson (CZE)
new PlayerAttribute { Id = 1174, PlayerId = 163, AttributeType = "Backhand", Value = 56 },
new PlayerAttribute { Id = 1175, PlayerId = 163, AttributeType = "Forehand", Value = 56 },
new PlayerAttribute { Id = 1176, PlayerId = 163, AttributeType = "Speed", Value = 54 },
new PlayerAttribute { Id = 1177, PlayerId = 163, AttributeType = "Stamina", Value = 46 },
new PlayerAttribute { Id = 1178, PlayerId = 163, AttributeType = "Mental", Value = 43 },
new PlayerAttribute { Id = 1179, PlayerId = 163, AttributeType = "Volley", Value = 45 },
new PlayerAttribute { Id = 1180, PlayerId = 163, AttributeType = "Return", Value = 41 },

// Zeynep Sonmez (TUR)
new PlayerAttribute { Id = 1181, PlayerId = 164, AttributeType = "Backhand", Value = 63 },
new PlayerAttribute { Id = 1182, PlayerId = 164, AttributeType = "Forehand", Value = 67 },
new PlayerAttribute { Id = 1183, PlayerId = 164, AttributeType = "Speed", Value = 49 },
new PlayerAttribute { Id = 1184, PlayerId = 164, AttributeType = "Stamina", Value = 47 },
new PlayerAttribute { Id = 1185, PlayerId = 164, AttributeType = "Mental", Value = 42 },
new PlayerAttribute { Id = 1186, PlayerId = 164, AttributeType = "Volley", Value = 33 },
new PlayerAttribute { Id = 1187, PlayerId = 164, AttributeType = "Return", Value = 64 },

// Jule Niemeier (DEU)
new PlayerAttribute { Id = 1188, PlayerId = 165, AttributeType = "Backhand", Value = 80 },
new PlayerAttribute { Id = 1189, PlayerId = 165, AttributeType = "Forehand", Value = 52 },
new PlayerAttribute { Id = 1190, PlayerId = 165, AttributeType = "Speed", Value = 49 },
new PlayerAttribute { Id = 1191, PlayerId = 165, AttributeType = "Stamina", Value = 50 },
new PlayerAttribute { Id = 1192, PlayerId = 165, AttributeType = "Mental", Value = 56 },
new PlayerAttribute { Id = 1193, PlayerId = 165, AttributeType = "Volley", Value = 76 },
new PlayerAttribute { Id = 1194, PlayerId = 165, AttributeType = "Return", Value = 56 },

// Mirjam Bjorklund (SWE)
new PlayerAttribute { Id = 1195, PlayerId = 166, AttributeType = "Backhand", Value = 61 },
new PlayerAttribute { Id = 1196, PlayerId = 166, AttributeType = "Forehand", Value = 53 },
new PlayerAttribute { Id = 1197, PlayerId = 166, AttributeType = "Speed", Value = 50 },
new PlayerAttribute { Id = 1198, PlayerId = 166, AttributeType = "Stamina", Value = 53 },
new PlayerAttribute { Id = 1199, PlayerId = 166, AttributeType = "Mental", Value = 40 },
new PlayerAttribute { Id = 1200, PlayerId = 166, AttributeType = "Volley", Value = 49 },
new PlayerAttribute { Id = 1201, PlayerId = 166, AttributeType = "Return", Value = 49 },

// Simona Waltert (CHE)
new PlayerAttribute { Id = 1202, PlayerId = 167, AttributeType = "Backhand", Value = 60 },
new PlayerAttribute { Id = 1203, PlayerId = 167, AttributeType = "Forehand", Value = 64 },
new PlayerAttribute { Id = 1204, PlayerId = 167, AttributeType = "Speed", Value = 50 },
new PlayerAttribute { Id = 1205, PlayerId = 167, AttributeType = "Stamina", Value = 49 },
new PlayerAttribute { Id = 1206, PlayerId = 167, AttributeType = "Mental", Value = 49 },
new PlayerAttribute { Id = 1207, PlayerId = 167, AttributeType = "Volley", Value = 43 },
new PlayerAttribute { Id = 1208, PlayerId = 167, AttributeType = "Return", Value = 45 },

// Ann Li (USA)
new PlayerAttribute { Id = 1216, PlayerId = 169, AttributeType = "Backhand", Value = 80 },
new PlayerAttribute { Id = 1217, PlayerId = 169, AttributeType = "Forehand", Value = 70 },
new PlayerAttribute { Id = 1218, PlayerId = 169, AttributeType = "Speed", Value = 59 },
new PlayerAttribute { Id = 1219, PlayerId = 169, AttributeType = "Stamina", Value = 49 },
new PlayerAttribute { Id = 1220, PlayerId = 169, AttributeType = "Mental", Value = 44 },
new PlayerAttribute { Id = 1221, PlayerId = 169, AttributeType = "Volley", Value = 49 },
new PlayerAttribute { Id = 1222, PlayerId = 169, AttributeType = "Return", Value = 49 },

// Aliona Bolsova (ESP)
new PlayerAttribute { Id = 1223, PlayerId = 170, AttributeType = "Backhand", Value = 57 },
new PlayerAttribute { Id = 1224, PlayerId = 170, AttributeType = "Forehand", Value = 53 },
new PlayerAttribute { Id = 1225, PlayerId = 170, AttributeType = "Speed", Value = 60 },
new PlayerAttribute { Id = 1226, PlayerId = 170, AttributeType = "Stamina", Value = 42 },
new PlayerAttribute { Id = 1227, PlayerId = 170, AttributeType = "Mental", Value = 52 },
new PlayerAttribute { Id = 1228, PlayerId = 170, AttributeType = "Volley", Value = 62 },
new PlayerAttribute { Id = 1229, PlayerId = 170, AttributeType = "Return", Value = 53 },

// Storm Hunter (AUS)
new PlayerAttribute { Id = 1230, PlayerId = 171, AttributeType = "Backhand", Value = 64 },
new PlayerAttribute { Id = 1231, PlayerId = 171, AttributeType = "Forehand", Value = 55 },
new PlayerAttribute { Id = 1232, PlayerId = 171, AttributeType = "Speed", Value = 50 },
new PlayerAttribute { Id = 1233, PlayerId = 171, AttributeType = "Stamina", Value = 41 },
new PlayerAttribute { Id = 1234, PlayerId = 171, AttributeType = "Mental", Value = 49 },
new PlayerAttribute { Id = 1235, PlayerId = 171, AttributeType = "Volley", Value = 90 },
new PlayerAttribute { Id = 1236, PlayerId = 171, AttributeType = "Return", Value = 77 },

// Katarina Zavatska (UKR)
new PlayerAttribute { Id = 1237, PlayerId = 172, AttributeType = "Backhand", Value = 59 },
new PlayerAttribute { Id = 1238, PlayerId = 172, AttributeType = "Forehand", Value = 55 },
new PlayerAttribute { Id = 1239, PlayerId = 172, AttributeType = "Speed", Value = 53 },
new PlayerAttribute { Id = 1240, PlayerId = 172, AttributeType = "Stamina", Value = 54 },
new PlayerAttribute { Id = 1241, PlayerId = 172, AttributeType = "Mental", Value = 41 },
new PlayerAttribute { Id = 1242, PlayerId = 172, AttributeType = "Volley", Value = 52 },
new PlayerAttribute { Id = 1243, PlayerId = 172, AttributeType = "Return", Value = 54 },

// Petra Marcinko (HRV)
new PlayerAttribute { Id = 1244, PlayerId = 173, AttributeType = "Backhand", Value = 74 },
new PlayerAttribute { Id = 1245, PlayerId = 173, AttributeType = "Forehand", Value = 63 },
new PlayerAttribute { Id = 1246, PlayerId = 173, AttributeType = "Speed", Value = 54 },
new PlayerAttribute { Id = 1247, PlayerId = 173, AttributeType = "Stamina", Value = 49 },
new PlayerAttribute { Id = 1248, PlayerId = 173, AttributeType = "Mental", Value = 48 },
new PlayerAttribute { Id = 1249, PlayerId = 173, AttributeType = "Volley", Value = 50 },
new PlayerAttribute { Id = 1250, PlayerId = 173, AttributeType = "Return", Value = 38 },

// Alina Korneeva (RUS)
new PlayerAttribute { Id = 1251, PlayerId = 174, AttributeType = "Backhand", Value = 88 },
new PlayerAttribute { Id = 1252, PlayerId = 174, AttributeType = "Forehand", Value = 67 },
new PlayerAttribute { Id = 1253, PlayerId = 174, AttributeType = "Speed", Value = 44 },
new PlayerAttribute { Id = 1254, PlayerId = 174, AttributeType = "Stamina", Value = 38 },
new PlayerAttribute { Id = 1255, PlayerId = 174, AttributeType = "Mental", Value = 45 },
new PlayerAttribute { Id = 1256, PlayerId = 174, AttributeType = "Volley", Value = 36 },
new PlayerAttribute { Id = 1257, PlayerId = 174, AttributeType = "Return", Value = 49 },

// Solana Sierra (ARG)
new PlayerAttribute { Id = 1258, PlayerId = 175, AttributeType = "Backhand", Value = 60 },
new PlayerAttribute { Id = 1259, PlayerId = 175, AttributeType = "Forehand", Value = 60 },
new PlayerAttribute { Id = 1260, PlayerId = 175, AttributeType = "Speed", Value = 59 },
new PlayerAttribute { Id = 1261, PlayerId = 175, AttributeType = "Stamina", Value = 49 },
new PlayerAttribute { Id = 1262, PlayerId = 175, AttributeType = "Mental", Value = 49 },
new PlayerAttribute { Id = 1263, PlayerId = 175, AttributeType = "Volley", Value = 47 },
new PlayerAttribute { Id = 1264, PlayerId = 175, AttributeType = "Return", Value = 46 },

// Rebecca Marino (CAN)
new PlayerAttribute { Id = 1265, PlayerId = 176, AttributeType = "Backhand", Value = 69 },
new PlayerAttribute { Id = 1266, PlayerId = 176, AttributeType = "Forehand", Value = 49 },
new PlayerAttribute { Id = 1267, PlayerId = 176, AttributeType = "Speed", Value = 38 },
new PlayerAttribute { Id = 1268, PlayerId = 176, AttributeType = "Stamina", Value = 46 },
new PlayerAttribute { Id = 1269, PlayerId = 176, AttributeType = "Mental", Value = 43 },
new PlayerAttribute { Id = 1270, PlayerId = 176, AttributeType = "Volley", Value = 44 },
new PlayerAttribute { Id = 1271, PlayerId = 176, AttributeType = "Return", Value = 45 },

// Noma Akugue Noha (DEU)
new PlayerAttribute { Id = 1272, PlayerId = 177, AttributeType = "Backhand", Value = 63 },
new PlayerAttribute { Id = 1273, PlayerId = 177, AttributeType = "Forehand", Value = 62 },
new PlayerAttribute { Id = 1274, PlayerId = 177, AttributeType = "Speed", Value = 42 },
new PlayerAttribute { Id = 1275, PlayerId = 177, AttributeType = "Stamina", Value = 45 },
new PlayerAttribute { Id = 1276, PlayerId = 177, AttributeType = "Mental", Value = 47 },
new PlayerAttribute { Id = 1277, PlayerId = 177, AttributeType = "Volley", Value = 33 },
new PlayerAttribute { Id = 1278, PlayerId = 177, AttributeType = "Return", Value = 44 },

// Raluca Georgiana Serban (CYP)
new PlayerAttribute { Id = 1279, PlayerId = 178, AttributeType = "Backhand", Value = 42 },
new PlayerAttribute { Id = 1280, PlayerId = 178, AttributeType = "Forehand", Value = 49 },
new PlayerAttribute { Id = 1281, PlayerId = 178, AttributeType = "Speed", Value = 44 },
new PlayerAttribute { Id = 1282, PlayerId = 178, AttributeType = "Stamina", Value = 34 },
new PlayerAttribute { Id = 1283, PlayerId = 178, AttributeType = "Mental", Value = 44 },
new PlayerAttribute { Id = 1284, PlayerId = 178, AttributeType = "Volley", Value = 52 },
new PlayerAttribute { Id = 1285, PlayerId = 178, AttributeType = "Return", Value = 43 },

// Ella Seidel (DEU)
new PlayerAttribute { Id = 1286, PlayerId = 179, AttributeType = "Backhand", Value = 49 },
new PlayerAttribute { Id = 1287, PlayerId = 179, AttributeType = "Forehand", Value = 69 },
new PlayerAttribute { Id = 1288, PlayerId = 179, AttributeType = "Speed", Value = 46 },
new PlayerAttribute { Id = 1289, PlayerId = 179, AttributeType = "Stamina", Value = 49 },
new PlayerAttribute { Id = 1290, PlayerId = 179, AttributeType = "Mental", Value = 42 },
new PlayerAttribute { Id = 1291, PlayerId = 179, AttributeType = "Volley", Value = 43 },
new PlayerAttribute { Id = 1292, PlayerId = 179, AttributeType = "Return", Value = 43 },

// Natalija Stevanovic (SRB)
new PlayerAttribute { Id = 1293, PlayerId = 180, AttributeType = "Backhand", Value = 37 },
new PlayerAttribute { Id = 1294, PlayerId = 180, AttributeType = "Forehand", Value = 39 },
new PlayerAttribute { Id = 1295, PlayerId = 180, AttributeType = "Speed", Value = 67 },
new PlayerAttribute { Id = 1296, PlayerId = 180, AttributeType = "Stamina", Value = 69 },
new PlayerAttribute { Id = 1297, PlayerId = 180, AttributeType = "Mental", Value = 73 },
new PlayerAttribute { Id = 1298, PlayerId = 180, AttributeType = "Volley", Value = 50 },
new PlayerAttribute { Id = 1299, PlayerId = 180, AttributeType = "Return", Value = 31 },

// Himeno Sakatsume (JPN)
new PlayerAttribute { Id = 1300, PlayerId = 181, AttributeType = "Backhand", Value = 36 },
new PlayerAttribute { Id = 1301, PlayerId = 181, AttributeType = "Forehand", Value = 50 },
new PlayerAttribute { Id = 1302, PlayerId = 181, AttributeType = "Speed", Value = 65 },
new PlayerAttribute { Id = 1303, PlayerId = 181, AttributeType = "Stamina", Value = 54 },
new PlayerAttribute { Id = 1304, PlayerId = 181, AttributeType = "Mental", Value = 59 },
new PlayerAttribute { Id = 1305, PlayerId = 181, AttributeType = "Volley", Value = 60 },
new PlayerAttribute { Id = 1306, PlayerId = 181, AttributeType = "Return", Value = 40 },

// Polina Kudermetova (RUS)
new PlayerAttribute { Id = 1307, PlayerId = 182, AttributeType = "Backhand", Value = 77 },
new PlayerAttribute { Id = 1308, PlayerId = 182, AttributeType = "Forehand", Value = 77 },
new PlayerAttribute { Id = 1309, PlayerId = 182, AttributeType = "Speed", Value = 62 },
new PlayerAttribute { Id = 1310, PlayerId = 182, AttributeType = "Stamina", Value = 53 },
new PlayerAttribute { Id = 1311, PlayerId = 182, AttributeType = "Mental", Value = 54 },
new PlayerAttribute { Id = 1312, PlayerId = 182, AttributeType = "Volley", Value = 45 },
new PlayerAttribute { Id = 1313, PlayerId = 182, AttributeType = "Return", Value = 54 },

// Irina Maria Bara (ROU)
new PlayerAttribute { Id = 1314, PlayerId = 183, AttributeType = "Backhand", Value = 44 },
new PlayerAttribute { Id = 1315, PlayerId = 183, AttributeType = "Forehand", Value = 49 },
new PlayerAttribute { Id = 1316, PlayerId = 183, AttributeType = "Speed", Value = 60 },
new PlayerAttribute { Id = 1317, PlayerId = 183, AttributeType = "Stamina", Value = 65 },
new PlayerAttribute { Id = 1318, PlayerId = 183, AttributeType = "Mental", Value = 63 },
new PlayerAttribute { Id = 1319, PlayerId = 183, AttributeType = "Volley", Value = 70 },
new PlayerAttribute { Id = 1320, PlayerId = 183, AttributeType = "Return", Value = 28 },

// Jana Fett (HRV)
new PlayerAttribute { Id = 1321, PlayerId = 184, AttributeType = "Backhand", Value = 45 },
new PlayerAttribute { Id = 1322, PlayerId = 184, AttributeType = "Forehand", Value = 54 },
new PlayerAttribute { Id = 1323, PlayerId = 184, AttributeType = "Speed", Value = 45 },
new PlayerAttribute { Id = 1324, PlayerId = 184, AttributeType = "Stamina", Value = 28 },
new PlayerAttribute { Id = 1325, PlayerId = 184, AttributeType = "Mental", Value = 56 },
new PlayerAttribute { Id = 1326, PlayerId = 184, AttributeType = "Volley", Value = 26 },
new PlayerAttribute { Id = 1327, PlayerId = 184, AttributeType = "Return", Value = 53 },

// Ekaterina Makarova (RUS)
new PlayerAttribute { Id = 1328, PlayerId = 185, AttributeType = "Backhand", Value = 44 },
new PlayerAttribute { Id = 1329, PlayerId = 185, AttributeType = "Forehand", Value = 49 },
new PlayerAttribute { Id = 1330, PlayerId = 185, AttributeType = "Speed", Value = 52 },
new PlayerAttribute { Id = 1331, PlayerId = 185, AttributeType = "Stamina", Value = 43 },
new PlayerAttribute { Id = 1332, PlayerId = 185, AttributeType = "Mental", Value = 43 },
new PlayerAttribute { Id = 1333, PlayerId = 185, AttributeType = "Volley", Value = 46 },
new PlayerAttribute { Id = 1334, PlayerId = 185, AttributeType = "Return", Value = 49 },

// Yuriko Miyazaki (GBR)
new PlayerAttribute { Id = 1335, PlayerId = 186, AttributeType = "Backhand", Value = 41 },
new PlayerAttribute { Id = 1336, PlayerId = 186, AttributeType = "Forehand", Value = 53 },
new PlayerAttribute { Id = 1337, PlayerId = 186, AttributeType = "Speed", Value = 48 },
new PlayerAttribute { Id = 1338, PlayerId = 186, AttributeType = "Stamina", Value = 46 },
new PlayerAttribute { Id = 1339, PlayerId = 186, AttributeType = "Mental", Value = 47 },
new PlayerAttribute { Id = 1340, PlayerId = 186, AttributeType = "Volley", Value = 44 },
new PlayerAttribute { Id = 1341, PlayerId = 186, AttributeType = "Return", Value = 45 },

// Elsa Jacquemot (FRA)
new PlayerAttribute { Id = 1342, PlayerId = 187, AttributeType = "Backhand", Value = 50 },
new PlayerAttribute { Id = 1343, PlayerId = 187, AttributeType = "Forehand", Value = 43 },
new PlayerAttribute { Id = 1344, PlayerId = 187, AttributeType = "Speed", Value = 47 },
new PlayerAttribute { Id = 1345, PlayerId = 187, AttributeType = "Stamina", Value = 45 },
new PlayerAttribute { Id = 1346, PlayerId = 187, AttributeType = "Mental", Value = 56 },
new PlayerAttribute { Id = 1347, PlayerId = 187, AttributeType = "Volley", Value = 53 },
new PlayerAttribute { Id = 1348, PlayerId = 187, AttributeType = "Return", Value = 44 },

// Timea Babos (HUN)
new PlayerAttribute { Id = 1349, PlayerId = 188, AttributeType = "Backhand", Value = 48 },
new PlayerAttribute { Id = 1350, PlayerId = 188, AttributeType = "Forehand", Value = 53 },
new PlayerAttribute { Id = 1351, PlayerId = 188, AttributeType = "Speed", Value = 42 },
new PlayerAttribute { Id = 1352, PlayerId = 188, AttributeType = "Stamina", Value = 44 },
new PlayerAttribute { Id = 1353, PlayerId = 188, AttributeType = "Mental", Value = 25 },
new PlayerAttribute { Id = 1354, PlayerId = 188, AttributeType = "Volley", Value = 86 },
new PlayerAttribute { Id = 1355, PlayerId = 188, AttributeType = "Return", Value = 46 },

// Ysaline Bonaventure (BEL)
new PlayerAttribute { Id = 1356, PlayerId = 189, AttributeType = "Backhand", Value = 46 },
new PlayerAttribute { Id = 1357, PlayerId = 189, AttributeType = "Forehand", Value = 58 },
new PlayerAttribute { Id = 1358, PlayerId = 189, AttributeType = "Speed", Value = 33 },
new PlayerAttribute { Id = 1359, PlayerId = 189, AttributeType = "Stamina", Value = 33 },
new PlayerAttribute { Id = 1360, PlayerId = 189, AttributeType = "Mental", Value = 33 },
new PlayerAttribute { Id = 1361, PlayerId = 189, AttributeType = "Volley", Value = 49 },
new PlayerAttribute { Id = 1362, PlayerId = 189, AttributeType = "Return", Value = 47 },

// Alexandra Eala (PHL)
new PlayerAttribute { Id = 1363, PlayerId = 190, AttributeType = "Backhand", Value = 47 },
new PlayerAttribute { Id = 1364, PlayerId = 190, AttributeType = "Forehand", Value = 49 },
new PlayerAttribute { Id = 1365, PlayerId = 190, AttributeType = "Speed", Value = 55 },
new PlayerAttribute { Id = 1366, PlayerId = 190, AttributeType = "Stamina", Value = 56 },
new PlayerAttribute { Id = 1367, PlayerId = 190, AttributeType = "Mental", Value = 58 },
new PlayerAttribute { Id = 1368, PlayerId = 190, AttributeType = "Volley", Value = 45 },
new PlayerAttribute { Id = 1369, PlayerId = 190, AttributeType = "Return", Value = 43 },

// Robin Montgomery (USA)
new PlayerAttribute { Id = 1370, PlayerId = 191, AttributeType = "Backhand", Value = 56 },
new PlayerAttribute { Id = 1371, PlayerId = 191, AttributeType = "Forehand", Value = 58 },
new PlayerAttribute { Id = 1372, PlayerId = 191, AttributeType = "Speed", Value = 33 },
new PlayerAttribute { Id = 1373, PlayerId = 191, AttributeType = "Stamina", Value = 31 },
new PlayerAttribute { Id = 1374, PlayerId = 191, AttributeType = "Mental", Value = 35 },
new PlayerAttribute { Id = 1375, PlayerId = 191, AttributeType = "Volley", Value = 34 },
new PlayerAttribute { Id = 1376, PlayerId = 191, AttributeType = "Return", Value = 45 },

// Anastasia Zakharova (RUS)
new PlayerAttribute { Id = 1377, PlayerId = 192, AttributeType = "Backhand", Value = 45 },
new PlayerAttribute { Id = 1378, PlayerId = 192, AttributeType = "Forehand", Value = 45 },
new PlayerAttribute { Id = 1379, PlayerId = 192, AttributeType = "Speed", Value = 43 },
new PlayerAttribute { Id = 1380, PlayerId = 192, AttributeType = "Stamina", Value = 43 },
new PlayerAttribute { Id = 1381, PlayerId = 192, AttributeType = "Mental", Value = 42 },
new PlayerAttribute { Id = 1382, PlayerId = 192, AttributeType = "Volley", Value = 44 },
new PlayerAttribute { Id = 1383, PlayerId = 192, AttributeType = "Return", Value = 46 },

// Veronika Erjavec (SVN)
new PlayerAttribute { Id = 1384, PlayerId = 193, AttributeType = "Backhand", Value = 47 },
new PlayerAttribute { Id = 1385, PlayerId = 193, AttributeType = "Forehand", Value = 47 },
new PlayerAttribute { Id = 1386, PlayerId = 193, AttributeType = "Speed", Value = 43 },
new PlayerAttribute { Id = 1387, PlayerId = 193, AttributeType = "Stamina", Value = 39 },
new PlayerAttribute { Id = 1388, PlayerId = 193, AttributeType = "Mental", Value = 36 },
new PlayerAttribute { Id = 1389, PlayerId = 193, AttributeType = "Volley", Value = 45 },
new PlayerAttribute { Id = 1390, PlayerId = 193, AttributeType = "Return", Value = 44 },

// Miriam Bianca Bulgaru (ROU)
new PlayerAttribute { Id = 1391, PlayerId = 194, AttributeType = "Backhand", Value = 43 },
new PlayerAttribute { Id = 1392, PlayerId = 194, AttributeType = "Forehand", Value = 49 },
new PlayerAttribute { Id = 1393, PlayerId = 194, AttributeType = "Speed", Value = 54 },
new PlayerAttribute { Id = 1394, PlayerId = 194, AttributeType = "Stamina", Value = 39 },
new PlayerAttribute { Id = 1395, PlayerId = 194, AttributeType = "Mental", Value = 42 },
new PlayerAttribute { Id = 1396, PlayerId = 194, AttributeType = "Volley", Value = 32 },
new PlayerAttribute { Id = 1397, PlayerId = 194, AttributeType = "Return", Value = 25 },

// Carole Monnet (FRA)
new PlayerAttribute { Id = 1398, PlayerId = 195, AttributeType = "Backhand", Value = 35 },
new PlayerAttribute { Id = 1399, PlayerId = 195, AttributeType = "Forehand", Value = 54 },
new PlayerAttribute { Id = 1400, PlayerId = 195, AttributeType = "Speed", Value = 23 },
new PlayerAttribute { Id = 1401, PlayerId = 195, AttributeType = "Stamina", Value = 44 },
new PlayerAttribute { Id = 1402, PlayerId = 195, AttributeType = "Mental", Value = 29 },
new PlayerAttribute { Id = 1403, PlayerId = 195, AttributeType = "Volley", Value = 28 },
new PlayerAttribute { Id = 1404, PlayerId = 195, AttributeType = "Return", Value = 48 },

// Sinja Kraus (AUT)
new PlayerAttribute { Id = 1405, PlayerId = 196, AttributeType = "Backhand", Value = 42 },
new PlayerAttribute { Id = 1406, PlayerId = 196, AttributeType = "Forehand", Value = 54 },
new PlayerAttribute { Id = 1407, PlayerId = 196, AttributeType = "Speed", Value = 51 },
new PlayerAttribute { Id = 1408, PlayerId = 196, AttributeType = "Stamina", Value = 53 },
new PlayerAttribute { Id = 1409, PlayerId = 196, AttributeType = "Mental", Value = 52 },
new PlayerAttribute { Id = 1410, PlayerId = 196, AttributeType = "Volley", Value = 43 },
new PlayerAttribute { Id = 1411, PlayerId = 196, AttributeType = "Return", Value = 45 },

// Katarzyna Kawa (POL)
new PlayerAttribute { Id = 1412, PlayerId = 197, AttributeType = "Backhand", Value = 42 },
new PlayerAttribute { Id = 1413, PlayerId = 197, AttributeType = "Forehand", Value = 42 },
new PlayerAttribute { Id = 1414, PlayerId = 197, AttributeType = "Speed", Value = 37 },
new PlayerAttribute { Id = 1415, PlayerId = 197, AttributeType = "Stamina", Value = 45 },
new PlayerAttribute { Id = 1416, PlayerId = 197, AttributeType = "Mental", Value = 46 },
new PlayerAttribute { Id = 1417, PlayerId = 197, AttributeType = "Volley", Value = 33 },
new PlayerAttribute { Id = 1418, PlayerId = 197, AttributeType = "Return", Value = 34 },

// Elvina Kalieva (USA)
new PlayerAttribute { Id = 1419, PlayerId = 198, AttributeType = "Backhand", Value = 49 },
new PlayerAttribute { Id = 1420, PlayerId = 198, AttributeType = "Forehand", Value = 43 },
new PlayerAttribute { Id = 1421, PlayerId = 198, AttributeType = "Speed", Value = 36 },
new PlayerAttribute { Id = 1422, PlayerId = 198, AttributeType = "Stamina", Value = 44 },
new PlayerAttribute { Id = 1423, PlayerId = 198, AttributeType = "Mental", Value = 43 },
new PlayerAttribute { Id = 1424, PlayerId = 198, AttributeType = "Volley", Value = 39 },
new PlayerAttribute { Id = 1425, PlayerId = 198, AttributeType = "Return", Value = 44 },

// Moyuka Uchijima (JPN)
new PlayerAttribute { Id = 1426, PlayerId = 199, AttributeType = "Backhand", Value = 58 },
new PlayerAttribute { Id = 1427, PlayerId = 199, AttributeType = "Forehand", Value = 50 },
new PlayerAttribute { Id = 1428, PlayerId = 199, AttributeType = "Speed", Value = 63 },
new PlayerAttribute { Id = 1429, PlayerId = 199, AttributeType = "Stamina", Value = 45 },
new PlayerAttribute { Id = 1430, PlayerId = 199, AttributeType = "Mental", Value = 54 },
new PlayerAttribute { Id = 1431, PlayerId = 199, AttributeType = "Volley", Value = 37 },
new PlayerAttribute { Id = 1432, PlayerId = 199, AttributeType = "Return", Value = 43 },

// Iryna Shymanovich (BLR)
new PlayerAttribute { Id = 1433, PlayerId = 200, AttributeType = "Backhand", Value = 43 },
new PlayerAttribute { Id = 1434, PlayerId = 200, AttributeType = "Forehand", Value = 46 },
new PlayerAttribute { Id = 1435, PlayerId = 200, AttributeType = "Speed", Value = 45 },
new PlayerAttribute { Id = 1436, PlayerId = 200, AttributeType = "Stamina", Value = 39 },
new PlayerAttribute { Id = 1437, PlayerId = 200, AttributeType = "Mental", Value = 35 },
new PlayerAttribute { Id = 1438, PlayerId = 200, AttributeType = "Volley", Value = 36 },
new PlayerAttribute { Id = 1439, PlayerId = 200, AttributeType = "Return", Value = 31 },

// Sofya Lansere (RUS)
new PlayerAttribute { Id = 1440, PlayerId = 201, AttributeType = "Backhand", Value = 35 },
new PlayerAttribute { Id = 1441, PlayerId = 201, AttributeType = "Forehand", Value = 54 },
new PlayerAttribute { Id = 1442, PlayerId = 201, AttributeType = "Speed", Value = 45 },
new PlayerAttribute { Id = 1443, PlayerId = 201, AttributeType = "Stamina", Value = 44 },
new PlayerAttribute { Id = 1444, PlayerId = 201, AttributeType = "Mental", Value = 44 },
new PlayerAttribute { Id = 1445, PlayerId = 201, AttributeType = "Volley", Value = 42 },
new PlayerAttribute { Id = 1446, PlayerId = 201, AttributeType = "Return", Value = 39 },

// Darya Astakhova (RUS)
new PlayerAttribute { Id = 1447, PlayerId = 202, AttributeType = "Backhand", Value = 35 },
new PlayerAttribute { Id = 1448, PlayerId = 202, AttributeType = "Forehand", Value = 37 },
new PlayerAttribute { Id = 1449, PlayerId = 202, AttributeType = "Speed", Value = 32 },
new PlayerAttribute { Id = 1450, PlayerId = 202, AttributeType = "Stamina", Value = 40 },
new PlayerAttribute { Id = 1451, PlayerId = 202, AttributeType = "Mental", Value = 41 },
new PlayerAttribute { Id = 1452, PlayerId = 202, AttributeType = "Volley", Value = 38 },
new PlayerAttribute { Id = 1453, PlayerId = 202, AttributeType = "Return", Value = 39 },

// Taylah Preston (AUS)
new PlayerAttribute { Id = 1454, PlayerId = 203, AttributeType = "Backhand", Value = 44 },
new PlayerAttribute { Id = 1455, PlayerId = 203, AttributeType = "Forehand", Value = 46 },
new PlayerAttribute { Id = 1456, PlayerId = 203, AttributeType = "Speed", Value = 41 },
new PlayerAttribute { Id = 1457, PlayerId = 203, AttributeType = "Stamina", Value = 49 },
new PlayerAttribute { Id = 1458, PlayerId = 203, AttributeType = "Mental", Value = 30 },
new PlayerAttribute { Id = 1459, PlayerId = 203, AttributeType = "Volley", Value = 27 },
new PlayerAttribute { Id = 1460, PlayerId = 203, AttributeType = "Return", Value = 28 },

// Daria Saville (AUS)
new PlayerAttribute { Id = 1461, PlayerId = 204, AttributeType = "Backhand", Value = 43 },
new PlayerAttribute { Id = 1462, PlayerId = 204, AttributeType = "Forehand", Value = 45 },
new PlayerAttribute { Id = 1463, PlayerId = 204, AttributeType = "Speed", Value = 30 },
new PlayerAttribute { Id = 1464, PlayerId = 204, AttributeType = "Stamina", Value = 38 },
new PlayerAttribute { Id = 1465, PlayerId = 204, AttributeType = "Mental", Value = 39 },
new PlayerAttribute { Id = 1466, PlayerId = 204, AttributeType = "Volley", Value = 36 },
new PlayerAttribute { Id = 1467, PlayerId = 204, AttributeType = "Return", Value = 27 },

// Priscilla Hon (AUS)
new PlayerAttribute { Id = 1468, PlayerId = 205, AttributeType = "Backhand", Value = 32 },
new PlayerAttribute { Id = 1469, PlayerId = 205, AttributeType = "Forehand", Value = 44 },
new PlayerAttribute { Id = 1470, PlayerId = 205, AttributeType = "Speed", Value = 39 },
new PlayerAttribute { Id = 1471, PlayerId = 205, AttributeType = "Stamina", Value = 47 },
new PlayerAttribute { Id = 1472, PlayerId = 205, AttributeType = "Mental", Value = 28 },
new PlayerAttribute { Id = 1473, PlayerId = 205, AttributeType = "Volley", Value = 25 },
new PlayerAttribute { Id = 1474, PlayerId = 205, AttributeType = "Return", Value = 26 },

// Nuria Brancaccio (ITA)
new PlayerAttribute { Id = 1475, PlayerId = 206, AttributeType = "Backhand", Value = 41 },
new PlayerAttribute { Id = 1476, PlayerId = 206, AttributeType = "Forehand", Value = 33 },
new PlayerAttribute { Id = 1477, PlayerId = 206, AttributeType = "Speed", Value = 48 },
new PlayerAttribute { Id = 1478, PlayerId = 206, AttributeType = "Stamina", Value = 46 },
new PlayerAttribute { Id = 1479, PlayerId = 206, AttributeType = "Mental", Value = 37 },
new PlayerAttribute { Id = 1480, PlayerId = 206, AttributeType = "Volley", Value = 34 },
new PlayerAttribute { Id = 1481, PlayerId = 206, AttributeType = "Return", Value = 45 },

// Yuliya Hatouka (BLR)
new PlayerAttribute { Id = 1482, PlayerId = 207, AttributeType = "Backhand", Value = 40 },
new PlayerAttribute { Id = 1483, PlayerId = 207, AttributeType = "Forehand", Value = 42 },
new PlayerAttribute { Id = 1484, PlayerId = 207, AttributeType = "Speed", Value = 37 },
new PlayerAttribute { Id = 1485, PlayerId = 207, AttributeType = "Stamina", Value = 35 },
new PlayerAttribute { Id = 1486, PlayerId = 207, AttributeType = "Mental", Value = 36 },
new PlayerAttribute { Id = 1487, PlayerId = 207, AttributeType = "Volley", Value = 33 },
new PlayerAttribute { Id = 1488, PlayerId = 207, AttributeType = "Return", Value = 34 },

// Francisca Jorge (PRT)
new PlayerAttribute { Id = 1489, PlayerId = 208, AttributeType = "Backhand", Value = 39 },
new PlayerAttribute { Id = 1490, PlayerId = 208, AttributeType = "Forehand", Value = 31 },
new PlayerAttribute { Id = 1491, PlayerId = 208, AttributeType = "Speed", Value = 36 },
new PlayerAttribute { Id = 1492, PlayerId = 208, AttributeType = "Stamina", Value = 34 },
new PlayerAttribute { Id = 1493, PlayerId = 208, AttributeType = "Mental", Value = 35 },
new PlayerAttribute { Id = 1494, PlayerId = 208, AttributeType = "Volley", Value = 42 },
new PlayerAttribute { Id = 1495, PlayerId = 208, AttributeType = "Return", Value = 43 },

// Destanee Aiava (AUS)
new PlayerAttribute { Id = 1496, PlayerId = 209, AttributeType = "Backhand", Value = 38 },
new PlayerAttribute { Id = 1497, PlayerId = 209, AttributeType = "Forehand", Value = 40 },
new PlayerAttribute { Id = 1498, PlayerId = 209, AttributeType = "Speed", Value = 35 },
new PlayerAttribute { Id = 1499, PlayerId = 209, AttributeType = "Stamina", Value = 43 },
new PlayerAttribute { Id = 1500, PlayerId = 209, AttributeType = "Mental", Value = 44 },
new PlayerAttribute { Id = 1501, PlayerId = 209, AttributeType = "Volley", Value = 31 },
new PlayerAttribute { Id = 1502, PlayerId = 209, AttributeType = "Return", Value = 32 },

// Ya-Yi Yang (TAI)
new PlayerAttribute { Id = 1503, PlayerId = 210, AttributeType = "Backhand", Value = 37 },
new PlayerAttribute { Id = 1504, PlayerId = 210, AttributeType = "Forehand", Value = 39 },
new PlayerAttribute { Id = 1505, PlayerId = 210, AttributeType = "Speed", Value = 34 },
new PlayerAttribute { Id = 1506, PlayerId = 210, AttributeType = "Stamina", Value = 32 },
new PlayerAttribute { Id = 1507, PlayerId = 210, AttributeType = "Mental", Value = 33 },
new PlayerAttribute { Id = 1508, PlayerId = 210, AttributeType = "Volley", Value = 31 },
new PlayerAttribute { Id = 1509, PlayerId = 210, AttributeType = "Return", Value = 31 },

// Suzan Lamens (NLD)
new PlayerAttribute { Id = 1510, PlayerId = 211, AttributeType = "Backhand", Value = 66 },
new PlayerAttribute { Id = 1511, PlayerId = 211, AttributeType = "Forehand", Value = 38 },
new PlayerAttribute { Id = 1512, PlayerId = 211, AttributeType = "Speed", Value = 33 },
new PlayerAttribute { Id = 1513, PlayerId = 211, AttributeType = "Stamina", Value = 52 },
new PlayerAttribute { Id = 1514, PlayerId = 211, AttributeType = "Mental", Value = 35 },
new PlayerAttribute { Id = 1515, PlayerId = 211, AttributeType = "Volley", Value = 31 },
new PlayerAttribute { Id = 1516, PlayerId = 211, AttributeType = "Return", Value = 31 },

// Jaimee Fourlis (AUS)
new PlayerAttribute { Id = 1517, PlayerId = 212, AttributeType = "Backhand", Value = 35 },
new PlayerAttribute { Id = 1518, PlayerId = 212, AttributeType = "Forehand", Value = 37 },
new PlayerAttribute { Id = 1519, PlayerId = 212, AttributeType = "Speed", Value = 23 },
new PlayerAttribute { Id = 1520, PlayerId = 212, AttributeType = "Stamina", Value = 32 },
new PlayerAttribute { Id = 1521, PlayerId = 212, AttributeType = "Mental", Value = 32 },
new PlayerAttribute { Id = 1522, PlayerId = 212, AttributeType = "Volley", Value = 31 },
new PlayerAttribute { Id = 1523, PlayerId = 212, AttributeType = "Return", Value = 31 },

// Lina Gjorcheska (MKD)
new PlayerAttribute { Id = 1524, PlayerId = 213, AttributeType = "Backhand", Value = 45 },
new PlayerAttribute { Id = 1525, PlayerId = 213, AttributeType = "Forehand", Value = 27 },
new PlayerAttribute { Id = 1526, PlayerId = 213, AttributeType = "Speed", Value = 43 },
new PlayerAttribute { Id = 1527, PlayerId = 213, AttributeType = "Stamina", Value = 31 },
new PlayerAttribute { Id = 1528, PlayerId = 213, AttributeType = "Mental", Value = 32 },
new PlayerAttribute { Id = 1529, PlayerId = 213, AttributeType = "Volley", Value = 21 },
new PlayerAttribute { Id = 1530, PlayerId = 213, AttributeType = "Return", Value = 21 },

// Lulu Sun (NZL)
new PlayerAttribute { Id = 1531, PlayerId = 214, AttributeType = "Backhand", Value = 55 },
new PlayerAttribute { Id = 1532, PlayerId = 214, AttributeType = "Forehand", Value = 46 },
new PlayerAttribute { Id = 1533, PlayerId = 214, AttributeType = "Speed", Value = 43 },
new PlayerAttribute { Id = 1534, PlayerId = 214, AttributeType = "Stamina", Value = 41 },
new PlayerAttribute { Id = 1535, PlayerId = 214, AttributeType = "Mental", Value = 41 },
new PlayerAttribute { Id = 1536, PlayerId = 214, AttributeType = "Volley", Value = 31 },
new PlayerAttribute { Id = 1537, PlayerId = 214, AttributeType = "Return", Value = 31 },

// Ankita Raina (IND)
new PlayerAttribute { Id = 1538, PlayerId = 215, AttributeType = "Backhand", Value = 39 },
new PlayerAttribute { Id = 1539, PlayerId = 215, AttributeType = "Forehand", Value = 20 },
new PlayerAttribute { Id = 1540, PlayerId = 215, AttributeType = "Speed", Value = 35 },
new PlayerAttribute { Id = 1541, PlayerId = 215, AttributeType = "Stamina", Value = 43 },
new PlayerAttribute { Id = 1542, PlayerId = 215, AttributeType = "Mental", Value = 44 },
new PlayerAttribute { Id = 1543, PlayerId = 215, AttributeType = "Volley", Value = 42 },
new PlayerAttribute { Id = 1544, PlayerId = 215, AttributeType = "Return", Value = 32 },

// Andreea Mitu (ROU)
new PlayerAttribute { Id = 1545, PlayerId = 216, AttributeType = "Backhand", Value = 48 },
new PlayerAttribute { Id = 1546, PlayerId = 216, AttributeType = "Forehand", Value = 29 },
new PlayerAttribute { Id = 1547, PlayerId = 216, AttributeType = "Speed", Value = 14 },
new PlayerAttribute { Id = 1548, PlayerId = 216, AttributeType = "Stamina", Value = 33 },
new PlayerAttribute { Id = 1549, PlayerId = 216, AttributeType = "Mental", Value = 33 },
new PlayerAttribute { Id = 1550, PlayerId = 216, AttributeType = "Volley", Value = 31 },
new PlayerAttribute { Id = 1551, PlayerId = 216, AttributeType = "Return", Value = 32 },

// Nigina Abduraimova (UZB)
new PlayerAttribute { Id = 1552, PlayerId = 217, AttributeType = "Backhand", Value = 27 },
new PlayerAttribute { Id = 1553, PlayerId = 217, AttributeType = "Forehand", Value = 38 },
new PlayerAttribute { Id = 1554, PlayerId = 217, AttributeType = "Speed", Value = 24 },
new PlayerAttribute { Id = 1555, PlayerId = 217, AttributeType = "Stamina", Value = 42 },
new PlayerAttribute { Id = 1556, PlayerId = 217, AttributeType = "Mental", Value = 33 },
new PlayerAttribute { Id = 1557, PlayerId = 217, AttributeType = "Volley", Value = 21 },
new PlayerAttribute { Id = 1558, PlayerId = 217, AttributeType = "Return", Value = 31 },

// Yexin Ma (CHN)
new PlayerAttribute { Id = 1559, PlayerId = 218, AttributeType = "Backhand", Value = 26 },
new PlayerAttribute { Id = 1560, PlayerId = 218, AttributeType = "Forehand", Value = 28 },
new PlayerAttribute { Id = 1561, PlayerId = 218, AttributeType = "Speed", Value = 33 },
new PlayerAttribute { Id = 1562, PlayerId = 218, AttributeType = "Stamina", Value = 23 },
new PlayerAttribute { Id = 1563, PlayerId = 218, AttributeType = "Mental", Value = 33 },
new PlayerAttribute { Id = 1564, PlayerId = 218, AttributeType = "Volley", Value = 41 },
new PlayerAttribute { Id = 1565, PlayerId = 218, AttributeType = "Return", Value = 32 },

// Carol Zhao (CAN)
new PlayerAttribute { Id = 1566, PlayerId = 219, AttributeType = "Backhand", Value = 27 },
new PlayerAttribute { Id = 1567, PlayerId = 219, AttributeType = "Forehand", Value = 28 },
new PlayerAttribute { Id = 1568, PlayerId = 219, AttributeType = "Speed", Value = 24 },
new PlayerAttribute { Id = 1569, PlayerId = 219, AttributeType = "Stamina", Value = 23 },
new PlayerAttribute { Id = 1570, PlayerId = 219, AttributeType = "Mental", Value = 34 },
new PlayerAttribute { Id = 1571, PlayerId = 219, AttributeType = "Volley", Value = 32 },
new PlayerAttribute { Id = 1572, PlayerId = 219, AttributeType = "Return", Value = 32 },

// Valentini Grammatikopoulou (GRC)
new PlayerAttribute { Id = 1573, PlayerId = 220, AttributeType = "Backhand", Value = 36 },
new PlayerAttribute { Id = 1574, PlayerId = 220, AttributeType = "Forehand", Value = 37 },
new PlayerAttribute { Id = 1575, PlayerId = 220, AttributeType = "Speed", Value = 24 },
new PlayerAttribute { Id = 1576, PlayerId = 220, AttributeType = "Stamina", Value = 32 },
new PlayerAttribute { Id = 1577, PlayerId = 220, AttributeType = "Mental", Value = 23 },
new PlayerAttribute { Id = 1578, PlayerId = 220, AttributeType = "Volley", Value = 41 },
new PlayerAttribute { Id = 1579, PlayerId = 220, AttributeType = "Return", Value = 22 },

// Mccartney Kessler (USA)
new PlayerAttribute { Id = 1580, PlayerId = 221, AttributeType = "Backhand", Value = 45 },
new PlayerAttribute { Id = 1581, PlayerId = 221, AttributeType = "Forehand", Value = 47 },
new PlayerAttribute { Id = 1582, PlayerId = 221, AttributeType = "Speed", Value = 34 },
new PlayerAttribute { Id = 1583, PlayerId = 221, AttributeType = "Stamina", Value = 43 },
new PlayerAttribute { Id = 1584, PlayerId = 221, AttributeType = "Mental", Value = 33 },
new PlayerAttribute { Id = 1585, PlayerId = 221, AttributeType = "Volley", Value = 22 },
new PlayerAttribute { Id = 1586, PlayerId = 221, AttributeType = "Return", Value = 21 },

// Despina Papamichail (GRC)
new PlayerAttribute { Id = 1587, PlayerId = 222, AttributeType = "Backhand", Value = 36 },
new PlayerAttribute { Id = 1588, PlayerId = 222, AttributeType = "Forehand", Value = 37 },
new PlayerAttribute { Id = 1589, PlayerId = 222, AttributeType = "Speed", Value = 24 },
new PlayerAttribute { Id = 1590, PlayerId = 222, AttributeType = "Stamina", Value = 32 },
new PlayerAttribute { Id = 1591, PlayerId = 222, AttributeType = "Mental", Value = 33 },
new PlayerAttribute { Id = 1592, PlayerId = 222, AttributeType = "Volley", Value = 31 },
new PlayerAttribute { Id = 1593, PlayerId = 222, AttributeType = "Return", Value = 32 },

// Alice Robbe (FRA)
new PlayerAttribute { Id = 1594, PlayerId = 223, AttributeType = "Backhand", Value = 36 },
new PlayerAttribute { Id = 1595, PlayerId = 223, AttributeType = "Forehand", Value = 38 },
new PlayerAttribute { Id = 1596, PlayerId = 223, AttributeType = "Speed", Value = 34 },
new PlayerAttribute { Id = 1597, PlayerId = 223, AttributeType = "Stamina", Value = 22 },
new PlayerAttribute { Id = 1598, PlayerId = 223, AttributeType = "Mental", Value = 32 },
new PlayerAttribute { Id = 1599, PlayerId = 223, AttributeType = "Volley", Value = 22 },
new PlayerAttribute { Id = 1600, PlayerId = 223, AttributeType = "Return", Value = 15 },

// Dominika Salkova (CZE)
new PlayerAttribute { Id = 1601, PlayerId = 224, AttributeType = "Backhand", Value = 45 },
new PlayerAttribute { Id = 1602, PlayerId = 224, AttributeType = "Forehand", Value = 47 },
new PlayerAttribute { Id = 1603, PlayerId = 224, AttributeType = "Speed", Value = 44 },
new PlayerAttribute { Id = 1604, PlayerId = 224, AttributeType = "Stamina", Value = 43 },
new PlayerAttribute { Id = 1605, PlayerId = 224, AttributeType = "Mental", Value = 33 },
new PlayerAttribute { Id = 1606, PlayerId = 224, AttributeType = "Volley", Value = 32 },
new PlayerAttribute { Id = 1607, PlayerId = 224, AttributeType = "Return", Value = 31 },

// Jana Kolodynska (BLR)
new PlayerAttribute { Id = 1608, PlayerId = 225, AttributeType = "Backhand", Value = 35 },
new PlayerAttribute { Id = 1609, PlayerId = 225, AttributeType = "Forehand", Value = 36 },
new PlayerAttribute { Id = 1610, PlayerId = 225, AttributeType = "Speed", Value = 24 },
new PlayerAttribute { Id = 1611, PlayerId = 225, AttributeType = "Stamina", Value = 33 },
new PlayerAttribute { Id = 1612, PlayerId = 225, AttributeType = "Mental", Value = 32 },
new PlayerAttribute { Id = 1613, PlayerId = 225, AttributeType = "Volley", Value = 32 },
new PlayerAttribute { Id = 1614, PlayerId = 225, AttributeType = "Return", Value = 31 },

// Lea Boskovic (HRV)
new PlayerAttribute { Id = 1615, PlayerId = 226, AttributeType = "Backhand", Value = 36 },
new PlayerAttribute { Id = 1616, PlayerId = 226, AttributeType = "Forehand", Value = 37 },
new PlayerAttribute { Id = 1617, PlayerId = 226, AttributeType = "Speed", Value = 25 },
new PlayerAttribute { Id = 1618, PlayerId = 226, AttributeType = "Stamina", Value = 34 },
new PlayerAttribute { Id = 1619, PlayerId = 226, AttributeType = "Mental", Value = 34 },
new PlayerAttribute { Id = 1620, PlayerId = 226, AttributeType = "Volley", Value = 32 },
new PlayerAttribute { Id = 1621, PlayerId = 226, AttributeType = "Return", Value = 22 },

// Xiaodi You (CHN)
new PlayerAttribute { Id = 1622, PlayerId = 227, AttributeType = "Backhand", Value = 37 },
new PlayerAttribute { Id = 1623, PlayerId = 227, AttributeType = "Forehand", Value = 28 },
new PlayerAttribute { Id = 1624, PlayerId = 227, AttributeType = "Speed", Value = 25 },
new PlayerAttribute { Id = 1625, PlayerId = 227, AttributeType = "Stamina", Value = 33 },
new PlayerAttribute { Id = 1626, PlayerId = 227, AttributeType = "Mental", Value = 44 },
new PlayerAttribute { Id = 1627, PlayerId = 227, AttributeType = "Volley", Value = 23 },
new PlayerAttribute { Id = 1628, PlayerId = 227, AttributeType = "Return", Value = 23 },

// Tena Lukas (HRV)
new PlayerAttribute { Id = 1629, PlayerId = 228, AttributeType = "Backhand", Value = 36 },
new PlayerAttribute { Id = 1630, PlayerId = 228, AttributeType = "Forehand", Value = 37 },
new PlayerAttribute { Id = 1631, PlayerId = 228, AttributeType = "Speed", Value = 25 },
new PlayerAttribute { Id = 1632, PlayerId = 228, AttributeType = "Stamina", Value = 23 },
new PlayerAttribute { Id = 1633, PlayerId = 228, AttributeType = "Mental", Value = 24 },
new PlayerAttribute { Id = 1634, PlayerId = 228, AttributeType = "Volley", Value = 23 },
new PlayerAttribute { Id = 1635, PlayerId = 228, AttributeType = "Return", Value = 33 },

// Selena Janicijevic (FRA)
new PlayerAttribute { Id = 1636, PlayerId = 229, AttributeType = "Backhand", Value = 36 },
new PlayerAttribute { Id = 1637, PlayerId = 229, AttributeType = "Forehand", Value = 37 },
new PlayerAttribute { Id = 1638, PlayerId = 229, AttributeType = "Speed", Value = 35 },
new PlayerAttribute { Id = 1639, PlayerId = 229, AttributeType = "Stamina", Value = 34 },
new PlayerAttribute { Id = 1640, PlayerId = 229, AttributeType = "Mental", Value = 23 },
new PlayerAttribute { Id = 1641, PlayerId = 229, AttributeType = "Volley", Value = 23 },
new PlayerAttribute { Id = 1642, PlayerId = 229, AttributeType = "Return", Value = 12 },

// Harmony Tan (FRA)
new PlayerAttribute { Id = 1643, PlayerId = 230, AttributeType = "Backhand", Value = 26 },
new PlayerAttribute { Id = 1644, PlayerId = 230, AttributeType = "Forehand", Value = 27 },
new PlayerAttribute { Id = 1645, PlayerId = 230, AttributeType = "Speed", Value = 25 },
new PlayerAttribute { Id = 1646, PlayerId = 230, AttributeType = "Stamina", Value = 24 },
new PlayerAttribute { Id = 1647, PlayerId = 230, AttributeType = "Mental", Value = 23 },
new PlayerAttribute { Id = 1648, PlayerId = 230, AttributeType = "Volley", Value = 23 },
new PlayerAttribute { Id = 1649, PlayerId = 230, AttributeType = "Return", Value = 22 },

// Tatiana Prozorova (RUS)
new PlayerAttribute { Id = 1650, PlayerId = 231, AttributeType = "Backhand", Value = 25 },
new PlayerAttribute { Id = 1651, PlayerId = 231, AttributeType = "Forehand", Value = 33 },
new PlayerAttribute { Id = 1652, PlayerId = 231, AttributeType = "Speed", Value = 34 },
new PlayerAttribute { Id = 1653, PlayerId = 231, AttributeType = "Stamina", Value = 23 },
new PlayerAttribute { Id = 1654, PlayerId = 231, AttributeType = "Mental", Value = 22 },
new PlayerAttribute { Id = 1655, PlayerId = 231, AttributeType = "Volley", Value = 22 },
new PlayerAttribute { Id = 1656, PlayerId = 231, AttributeType = "Return", Value = 21 },

// Sijia Wei (CHN)
new PlayerAttribute { Id = 1657, PlayerId = 232, AttributeType = "Backhand", Value = 26 },
new PlayerAttribute { Id = 1658, PlayerId = 232, AttributeType = "Forehand", Value = 27 },
new PlayerAttribute { Id = 1659, PlayerId = 232, AttributeType = "Speed", Value = 25 },
new PlayerAttribute { Id = 1660, PlayerId = 232, AttributeType = "Stamina", Value = 24 },
new PlayerAttribute { Id = 1661, PlayerId = 232, AttributeType = "Mental", Value = 23 },
new PlayerAttribute { Id = 1662, PlayerId = 232, AttributeType = "Volley", Value = 23 },
new PlayerAttribute { Id = 1663, PlayerId = 232, AttributeType = "Return", Value = 22 },

// Jennifer Brady (USA)
new PlayerAttribute { Id = 1664, PlayerId = 233, AttributeType = "Backhand", Value = 47 },
new PlayerAttribute { Id = 1665, PlayerId = 233, AttributeType = "Forehand", Value = 48 },
new PlayerAttribute { Id = 1666, PlayerId = 233, AttributeType = "Speed", Value = 46 },
new PlayerAttribute { Id = 1667, PlayerId = 233, AttributeType = "Stamina", Value = 35 },
new PlayerAttribute { Id = 1668, PlayerId = 233, AttributeType = "Mental", Value = 44 },
new PlayerAttribute { Id = 1669, PlayerId = 233, AttributeType = "Volley", Value = 34 },
new PlayerAttribute { Id = 1670, PlayerId = 233, AttributeType = "Return", Value = 33 },

// Lesley Pattinama Kerkhove (NLD)
new PlayerAttribute { Id = 1671, PlayerId = 234, AttributeType = "Backhand", Value = 26 },
new PlayerAttribute { Id = 1672, PlayerId = 234, AttributeType = "Forehand", Value = 27 },
new PlayerAttribute { Id = 1673, PlayerId = 234, AttributeType = "Speed", Value = 25 },
new PlayerAttribute { Id = 1674, PlayerId = 234, AttributeType = "Stamina", Value = 24 },
new PlayerAttribute { Id = 1675, PlayerId = 234, AttributeType = "Mental", Value = 24 },
new PlayerAttribute { Id = 1676, PlayerId = 234, AttributeType = "Volley", Value = 33 },
new PlayerAttribute { Id = 1677, PlayerId = 234, AttributeType = "Return", Value = 23 },

// Margaux Rouvroy (FRA)
new PlayerAttribute { Id = 1678, PlayerId = 235, AttributeType = "Backhand", Value = 25 },
new PlayerAttribute { Id = 1679, PlayerId = 235, AttributeType = "Forehand", Value = 26 },
new PlayerAttribute { Id = 1680, PlayerId = 235, AttributeType = "Speed", Value = 24 },
new PlayerAttribute { Id = 1681, PlayerId = 235, AttributeType = "Stamina", Value = 23 },
new PlayerAttribute { Id = 1682, PlayerId = 235, AttributeType = "Mental", Value = 23 },
new PlayerAttribute { Id = 1683, PlayerId = 235, AttributeType = "Volley", Value = 22 },
new PlayerAttribute { Id = 1684, PlayerId = 235, AttributeType = "Return", Value = 22 },

// Carlota Martinez Cirez (ESP)
new PlayerAttribute { Id = 1685, PlayerId = 236, AttributeType = "Backhand", Value = 26 },
new PlayerAttribute { Id = 1686, PlayerId = 236, AttributeType = "Forehand", Value = 27 },
new PlayerAttribute { Id = 1687, PlayerId = 236, AttributeType = "Speed", Value = 25 },
new PlayerAttribute { Id = 1688, PlayerId = 236, AttributeType = "Stamina", Value = 24 },
new PlayerAttribute { Id = 1689, PlayerId = 236, AttributeType = "Mental", Value = 23 },
new PlayerAttribute { Id = 1690, PlayerId = 236, AttributeType = "Volley", Value = 23 },
new PlayerAttribute { Id = 1691, PlayerId = 236, AttributeType = "Return", Value = 22 },

// Lanlana Tararudee (THA)
new PlayerAttribute { Id = 1692, PlayerId = 237, AttributeType = "Backhand", Value = 25 },
new PlayerAttribute { Id = 1693, PlayerId = 237, AttributeType = "Forehand", Value = 26 },
new PlayerAttribute { Id = 1694, PlayerId = 237, AttributeType = "Speed", Value = 24 },
new PlayerAttribute { Id = 1695, PlayerId = 237, AttributeType = "Stamina", Value = 43 },
new PlayerAttribute { Id = 1696, PlayerId = 237, AttributeType = "Mental", Value = 43 },
new PlayerAttribute { Id = 1697, PlayerId = 237, AttributeType = "Volley", Value = 42 },
new PlayerAttribute { Id = 1698, PlayerId = 237, AttributeType = "Return", Value = 42 },

// Stacey Fung (CAN)
new PlayerAttribute { Id = 1699, PlayerId = 238, AttributeType = "Backhand", Value = 26 },
new PlayerAttribute { Id = 1700, PlayerId = 238, AttributeType = "Forehand", Value = 27 },
new PlayerAttribute { Id = 1701, PlayerId = 238, AttributeType = "Speed", Value = 25 },
new PlayerAttribute { Id = 1702, PlayerId = 238, AttributeType = "Stamina", Value = 24 },
new PlayerAttribute { Id = 1703, PlayerId = 238, AttributeType = "Mental", Value = 23 },
new PlayerAttribute { Id = 1704, PlayerId = 238, AttributeType = "Volley", Value = 23 },
new PlayerAttribute { Id = 1705, PlayerId = 238, AttributeType = "Return", Value = 22 },

// Kristina Mladenovic (FRA)
new PlayerAttribute { Id = 1706, PlayerId = 239, AttributeType = "Backhand", Value = 37 },
new PlayerAttribute { Id = 1707, PlayerId = 239, AttributeType = "Forehand", Value = 38 },
new PlayerAttribute { Id = 1708, PlayerId = 239, AttributeType = "Speed", Value = 26 },
new PlayerAttribute { Id = 1709, PlayerId = 239, AttributeType = "Stamina", Value = 25 },
new PlayerAttribute { Id = 1710, PlayerId = 239, AttributeType = "Mental", Value = 24 },
new PlayerAttribute { Id = 1711, PlayerId = 239, AttributeType = "Volley", Value = 64 },
new PlayerAttribute { Id = 1712, PlayerId = 239, AttributeType = "Return", Value = 23 },

// Dalila Jakupovic (SVN)
new PlayerAttribute { Id = 1713, PlayerId = 240, AttributeType = "Backhand", Value = 26 },
new PlayerAttribute { Id = 1714, PlayerId = 240, AttributeType = "Forehand", Value = 27 },
new PlayerAttribute { Id = 1715, PlayerId = 240, AttributeType = "Speed", Value = 25 },
new PlayerAttribute { Id = 1716, PlayerId = 240, AttributeType = "Stamina", Value = 24 },
new PlayerAttribute { Id = 1717, PlayerId = 240, AttributeType = "Mental", Value = 32 },
new PlayerAttribute { Id = 1718, PlayerId = 240, AttributeType = "Volley", Value = 23 },
new PlayerAttribute { Id = 1719, PlayerId = 240, AttributeType = "Return", Value = 22 },

// Croatia Antonia Ruzic (HRV)
new PlayerAttribute { Id = 1720, PlayerId = 241, AttributeType = "Backhand", Value = 25 },
new PlayerAttribute { Id = 1721, PlayerId = 241, AttributeType = "Forehand", Value = 26 },
new PlayerAttribute { Id = 1722, PlayerId = 241, AttributeType = "Speed", Value = 24 },
new PlayerAttribute { Id = 1723, PlayerId = 241, AttributeType = "Stamina", Value = 23 },
new PlayerAttribute { Id = 1724, PlayerId = 241, AttributeType = "Mental", Value = 23 },
new PlayerAttribute { Id = 1725, PlayerId = 241, AttributeType = "Volley", Value = 22 },
new PlayerAttribute { Id = 1726, PlayerId = 241, AttributeType = "Return", Value = 22 },

// Turkey Ipek Oz (TUR)
new PlayerAttribute { Id = 1727, PlayerId = 242, AttributeType = "Backhand", Value = 36 },
new PlayerAttribute { Id = 1728, PlayerId = 242, AttributeType = "Forehand", Value = 37 },
new PlayerAttribute { Id = 1729, PlayerId = 242, AttributeType = "Speed", Value = 25 },
new PlayerAttribute { Id = 1730, PlayerId = 242, AttributeType = "Stamina", Value = 24 },
new PlayerAttribute { Id = 1731, PlayerId = 242, AttributeType = "Mental", Value = 23 },
new PlayerAttribute { Id = 1732, PlayerId = 242, AttributeType = "Volley", Value = 23 },
new PlayerAttribute { Id = 1733, PlayerId = 242, AttributeType = "Return", Value = 23 },

// Australia Seone Mendez (AUS)
new PlayerAttribute { Id = 1734, PlayerId = 243, AttributeType = "Backhand", Value = 37 },
new PlayerAttribute { Id = 1735, PlayerId = 243, AttributeType = "Forehand", Value = 38 },
new PlayerAttribute { Id = 1736, PlayerId = 243, AttributeType = "Speed", Value = 26 },
new PlayerAttribute { Id = 1737, PlayerId = 243, AttributeType = "Stamina", Value = 25 },
new PlayerAttribute { Id = 1738, PlayerId = 243, AttributeType = "Mental", Value = 24 },
new PlayerAttribute { Id = 1739, PlayerId = 243, AttributeType = "Volley", Value = 24 },
new PlayerAttribute { Id = 1740, PlayerId = 243, AttributeType = "Return", Value = 23 },

// Romania Anca Alexia Todoni (ROU)
new PlayerAttribute { Id = 1741, PlayerId = 244, AttributeType = "Backhand", Value = 46 },
new PlayerAttribute { Id = 1742, PlayerId = 244, AttributeType = "Forehand", Value = 47 },
new PlayerAttribute { Id = 1743, PlayerId = 244, AttributeType = "Speed", Value = 35 },
new PlayerAttribute { Id = 1744, PlayerId = 244, AttributeType = "Stamina", Value = 34 },
new PlayerAttribute { Id = 1745, PlayerId = 244, AttributeType = "Mental", Value = 43 },
new PlayerAttribute { Id = 1746, PlayerId = 244, AttributeType = "Volley", Value = 43 },
new PlayerAttribute { Id = 1747, PlayerId = 244, AttributeType = "Return", Value = 42 },

// China Shuai Zhang (CHN)
new PlayerAttribute { Id = 1748, PlayerId = 245, AttributeType = "Backhand", Value = 47 },
new PlayerAttribute { Id = 1749, PlayerId = 245, AttributeType = "Forehand", Value = 48 },
new PlayerAttribute { Id = 1750, PlayerId = 245, AttributeType = "Speed", Value = 56 },
new PlayerAttribute { Id = 1751, PlayerId = 245, AttributeType = "Stamina", Value = 45 },
new PlayerAttribute { Id = 1752, PlayerId = 245, AttributeType = "Mental", Value = 54 },
new PlayerAttribute { Id = 1753, PlayerId = 245, AttributeType = "Volley", Value = 54 },
new PlayerAttribute { Id = 1754, PlayerId = 245, AttributeType = "Return", Value = 43 },

// Lithuania Justina Mikulskyte (LTU)
new PlayerAttribute { Id = 1755, PlayerId = 246, AttributeType = "Backhand", Value = 36 },
new PlayerAttribute { Id = 1756, PlayerId = 246, AttributeType = "Forehand", Value = 27 },
new PlayerAttribute { Id = 1757, PlayerId = 246, AttributeType = "Speed", Value = 25 },
new PlayerAttribute { Id = 1758, PlayerId = 246, AttributeType = "Stamina", Value = 24 },
new PlayerAttribute { Id = 1759, PlayerId = 246, AttributeType = "Mental", Value = 33 },
new PlayerAttribute { Id = 1760, PlayerId = 246, AttributeType = "Volley", Value = 33 },
new PlayerAttribute { Id = 1761, PlayerId = 246, AttributeType = "Return", Value = 13 },

// Germany Mona Barthel (DEU)
new PlayerAttribute { Id = 1762, PlayerId = 247, AttributeType = "Backhand", Value = 36 },
new PlayerAttribute { Id = 1763, PlayerId = 247, AttributeType = "Forehand", Value = 57 },
new PlayerAttribute { Id = 1764, PlayerId = 247, AttributeType = "Speed", Value = 35 },
new PlayerAttribute { Id = 1765, PlayerId = 247, AttributeType = "Stamina", Value = 34 },
new PlayerAttribute { Id = 1766, PlayerId = 247, AttributeType = "Mental", Value = 33 },
new PlayerAttribute { Id = 1767, PlayerId = 247, AttributeType = "Volley", Value = 43 },
new PlayerAttribute { Id = 1768, PlayerId = 247, AttributeType = "Return", Value = 32 },

// United Kingdom Sonay Kartal (GBR)
new PlayerAttribute { Id = 1769, PlayerId = 248, AttributeType = "Backhand", Value = 46 },
new PlayerAttribute { Id = 1770, PlayerId = 248, AttributeType = "Forehand", Value = 47 },
new PlayerAttribute { Id = 1771, PlayerId = 248, AttributeType = "Speed", Value = 35 },
new PlayerAttribute { Id = 1772, PlayerId = 248, AttributeType = "Stamina", Value = 44 },
new PlayerAttribute { Id = 1773, PlayerId = 248, AttributeType = "Mental", Value = 43 },
new PlayerAttribute { Id = 1774, PlayerId = 248, AttributeType = "Volley", Value = 33 },
new PlayerAttribute { Id = 1775, PlayerId = 248, AttributeType = "Return", Value = 43 },

// Denmark Caroline Wozniacki (DEN)
new PlayerAttribute { Id = 1776, PlayerId = 249, AttributeType = "Backhand", Value = 57 },
new PlayerAttribute { Id = 1777, PlayerId = 249, AttributeType = "Forehand", Value = 48 },
new PlayerAttribute { Id = 1778, PlayerId = 249, AttributeType = "Speed", Value = 46 },
new PlayerAttribute { Id = 1779, PlayerId = 249, AttributeType = "Stamina", Value = 47 },
new PlayerAttribute { Id = 1780, PlayerId = 249, AttributeType = "Mental", Value = 36 },
new PlayerAttribute { Id = 1781, PlayerId = 249, AttributeType = "Volley", Value = 34 },
new PlayerAttribute { Id = 1782, PlayerId = 249, AttributeType = "Return", Value = 45 },

// Bulgaria Gergana Topalova (BGR)
new PlayerAttribute { Id = 1783, PlayerId = 250, AttributeType = "Backhand", Value = 25 },
new PlayerAttribute { Id = 1784, PlayerId = 250, AttributeType = "Forehand", Value = 26 },
new PlayerAttribute { Id = 1785, PlayerId = 250, AttributeType = "Speed", Value = 24 },
new PlayerAttribute { Id = 1786, PlayerId = 250, AttributeType = "Stamina", Value = 23 },
new PlayerAttribute { Id = 1787, PlayerId = 250, AttributeType = "Mental", Value = 23 },
new PlayerAttribute { Id = 1788, PlayerId = 250, AttributeType = "Volley", Value = 32 },
new PlayerAttribute { Id = 1789, PlayerId = 250, AttributeType = "Return", Value = 32 },

// Belgium Maryna Zanevska (BEL)
new PlayerAttribute { Id = 1790, PlayerId = 251, AttributeType = "Backhand", Value = 36 },
new PlayerAttribute { Id = 1791, PlayerId = 251, AttributeType = "Forehand", Value = 37 },
new PlayerAttribute { Id = 1792, PlayerId = 251, AttributeType = "Speed", Value = 15 },
new PlayerAttribute { Id = 1793, PlayerId = 251, AttributeType = "Stamina", Value = 42 },
new PlayerAttribute { Id = 1794, PlayerId = 251, AttributeType = "Mental", Value = 23 },
new PlayerAttribute { Id = 1795, PlayerId = 251, AttributeType = "Volley", Value = 23 },
new PlayerAttribute { Id = 1796, PlayerId = 251, AttributeType = "Return", Value = 23 },

// Belgium Sofia Costoulas (BEL)
new PlayerAttribute { Id = 1797, PlayerId = 252, AttributeType = "Backhand", Value = 36 },
new PlayerAttribute { Id = 1798, PlayerId = 252, AttributeType = "Forehand", Value = 47 },
new PlayerAttribute { Id = 1799, PlayerId = 252, AttributeType = "Speed", Value = 36 },
new PlayerAttribute { Id = 1800, PlayerId = 252, AttributeType = "Stamina", Value = 35 },
new PlayerAttribute { Id = 1801, PlayerId = 252, AttributeType = "Mental", Value = 34 },
new PlayerAttribute { Id = 1802, PlayerId = 252, AttributeType = "Volley", Value = 24 },
new PlayerAttribute { Id = 1803, PlayerId = 252, AttributeType = "Return", Value = 24 },

// Taipei (CHN) Joanna Garland (TAI)
new PlayerAttribute { Id = 1804, PlayerId = 253, AttributeType = "Backhand", Value = 45 },
new PlayerAttribute { Id = 1805, PlayerId = 253, AttributeType = "Forehand", Value = 46 },
new PlayerAttribute { Id = 1806, PlayerId = 253, AttributeType = "Speed", Value = 35 },
new PlayerAttribute { Id = 1807, PlayerId = 253, AttributeType = "Stamina", Value = 34 },
new PlayerAttribute { Id = 1808, PlayerId = 253, AttributeType = "Mental", Value = 23 },
new PlayerAttribute { Id = 1809, PlayerId = 253, AttributeType = "Volley", Value = 23 },
new PlayerAttribute { Id = 1810, PlayerId = 253, AttributeType = "Return", Value = 23 },

// USA Makenna Jones (USA)
new PlayerAttribute { Id = 1811, PlayerId = 254, AttributeType = "Backhand", Value = 25 },
new PlayerAttribute { Id = 1812, PlayerId = 254, AttributeType = "Forehand", Value = 36 },
new PlayerAttribute { Id = 1813, PlayerId = 254, AttributeType = "Speed", Value = 35 },
new PlayerAttribute { Id = 1814, PlayerId = 254, AttributeType = "Stamina", Value = 24 },
new PlayerAttribute { Id = 1815, PlayerId = 254, AttributeType = "Mental", Value = 23 },
new PlayerAttribute { Id = 1816, PlayerId = 254, AttributeType = "Volley", Value = 22 },
new PlayerAttribute { Id = 1817, PlayerId = 254, AttributeType = "Return", Value = 22 },

// Ukraine Valeriya Strakhova (UKR)
new PlayerAttribute { Id = 1818, PlayerId = 255, AttributeType = "Backhand", Value = 26 },
new PlayerAttribute { Id = 1819, PlayerId = 255, AttributeType = "Forehand", Value = 27 },
new PlayerAttribute { Id = 1820, PlayerId = 255, AttributeType = "Speed", Value = 15 },
new PlayerAttribute { Id = 1821, PlayerId = 255, AttributeType = "Stamina", Value = 24 },
new PlayerAttribute { Id = 1822, PlayerId = 255, AttributeType = "Mental", Value = 23 },
new PlayerAttribute { Id = 1823, PlayerId = 255, AttributeType = "Volley", Value = 23 },
new PlayerAttribute { Id = 1824, PlayerId = 255, AttributeType = "Return", Value = 23 },

// Serbia Dejana Radanovic (SRB)
new PlayerAttribute { Id = 1825, PlayerId = 256, AttributeType = "Backhand", Value = 25 },
new PlayerAttribute { Id = 1826, PlayerId = 256, AttributeType = "Forehand", Value = 26 },
new PlayerAttribute { Id = 1827, PlayerId = 256, AttributeType = "Speed", Value = 24 },
new PlayerAttribute { Id = 1828, PlayerId = 256, AttributeType = "Stamina", Value = 14 },
new PlayerAttribute { Id = 1829, PlayerId = 256, AttributeType = "Mental", Value = 31 },
new PlayerAttribute { Id = 1830, PlayerId = 256, AttributeType = "Volley", Value = 23 },
new PlayerAttribute { Id = 1831, PlayerId = 256, AttributeType = "Return", Value = 23 },

// USA Hanna Chang (USA)
new PlayerAttribute { Id = 1832, PlayerId = 257, AttributeType = "Backhand", Value = 25 },
new PlayerAttribute { Id = 1833, PlayerId = 257, AttributeType = "Forehand", Value = 26 },
new PlayerAttribute { Id = 1834, PlayerId = 257, AttributeType = "Speed", Value = 25 },
new PlayerAttribute { Id = 1835, PlayerId = 257, AttributeType = "Stamina", Value = 24 },
new PlayerAttribute { Id = 1836, PlayerId = 257, AttributeType = "Mental", Value = 23 },
new PlayerAttribute { Id = 1837, PlayerId = 257, AttributeType = "Volley", Value = 23 },
new PlayerAttribute { Id = 1838, PlayerId = 257, AttributeType = "Return", Value = 23 },

// Russia Julia Avdeeva (RUS)
new PlayerAttribute { Id = 1839, PlayerId = 258, AttributeType = "Backhand", Value = 36 },
new PlayerAttribute { Id = 1840, PlayerId = 258, AttributeType = "Forehand", Value = 46 },
new PlayerAttribute { Id = 1841, PlayerId = 258, AttributeType = "Speed", Value = 25 },
new PlayerAttribute { Id = 1842, PlayerId = 258, AttributeType = "Stamina", Value = 14 },
new PlayerAttribute { Id = 1843, PlayerId = 258, AttributeType = "Mental", Value = 23 },
new PlayerAttribute { Id = 1844, PlayerId = 258, AttributeType = "Volley", Value = 13 },
new PlayerAttribute { Id = 1845, PlayerId = 258, AttributeType = "Return", Value = 33 },

// Czech Republic Lucie Havlickova (CZE)
new PlayerAttribute { Id = 1846, PlayerId = 259, AttributeType = "Backhand", Value = 36 },
new PlayerAttribute { Id = 1847, PlayerId = 259, AttributeType = "Forehand", Value = 37 },
new PlayerAttribute { Id = 1848, PlayerId = 259, AttributeType = "Speed", Value = 36 },
new PlayerAttribute { Id = 1849, PlayerId = 259, AttributeType = "Stamina", Value = 25 },
new PlayerAttribute { Id = 1850, PlayerId = 259, AttributeType = "Mental", Value = 44 },
new PlayerAttribute { Id = 1851, PlayerId = 259, AttributeType = "Volley", Value = 34 },
new PlayerAttribute { Id = 1852, PlayerId = 259, AttributeType = "Return", Value = 34 },

// Thailand Mananchaya Sawangkaew (THA)
new PlayerAttribute { Id = 1853, PlayerId = 260, AttributeType = "Backhand", Value = 35 },
new PlayerAttribute { Id = 1854, PlayerId = 260, AttributeType = "Forehand", Value = 36 },
new PlayerAttribute { Id = 1855, PlayerId = 260, AttributeType = "Speed", Value = 35 },
new PlayerAttribute { Id = 1856, PlayerId = 260, AttributeType = "Stamina", Value = 24 },
new PlayerAttribute { Id = 1857, PlayerId = 260, AttributeType = "Mental", Value = 23 },
new PlayerAttribute { Id = 1858, PlayerId = 260, AttributeType = "Volley", Value = 23 },
new PlayerAttribute { Id = 1859, PlayerId = 260, AttributeType = "Return", Value = 23 },

// Switzerland Ylena In-Albon (CHE)
new PlayerAttribute { Id = 1860, PlayerId = 261, AttributeType = "Backhand", Value = 37 },
new PlayerAttribute { Id = 1861, PlayerId = 261, AttributeType = "Forehand", Value = 37 },
new PlayerAttribute { Id = 1862, PlayerId = 261, AttributeType = "Speed", Value = 26 },
new PlayerAttribute { Id = 1863, PlayerId = 261, AttributeType = "Stamina", Value = 35 },
new PlayerAttribute { Id = 1864, PlayerId = 261, AttributeType = "Mental", Value = 24 },
new PlayerAttribute { Id = 1865, PlayerId = 261, AttributeType = "Volley", Value = 24 },
new PlayerAttribute { Id = 1866, PlayerId = 261, AttributeType = "Return", Value = 24 },

// Hungary Fanny Stollar (HUN)
new PlayerAttribute { Id = 1867, PlayerId = 262, AttributeType = "Backhand", Value = 26 },
new PlayerAttribute { Id = 1868, PlayerId = 262, AttributeType = "Forehand", Value = 27 },
new PlayerAttribute { Id = 1869, PlayerId = 262, AttributeType = "Speed", Value = 25 },
new PlayerAttribute { Id = 1870, PlayerId = 262, AttributeType = "Stamina", Value = 24 },
new PlayerAttribute { Id = 1871, PlayerId = 262, AttributeType = "Mental", Value = 23 },
new PlayerAttribute { Id = 1872, PlayerId = 262, AttributeType = "Volley", Value = 23 },
new PlayerAttribute { Id = 1873, PlayerId = 262, AttributeType = "Return", Value = 23 },

// Belarus Aliona Falei (BLR)
new PlayerAttribute { Id = 1874, PlayerId = 263, AttributeType = "Backhand", Value = 26 },
new PlayerAttribute { Id = 1875, PlayerId = 263, AttributeType = "Forehand", Value = 26 },
new PlayerAttribute { Id = 1876, PlayerId = 263, AttributeType = "Speed", Value = 25 },
new PlayerAttribute { Id = 1877, PlayerId = 263, AttributeType = "Stamina", Value = 24 },
new PlayerAttribute { Id = 1878, PlayerId = 263, AttributeType = "Mental", Value = 23 },
new PlayerAttribute { Id = 1879, PlayerId = 263, AttributeType = "Volley", Value = 23 },
new PlayerAttribute { Id = 1880, PlayerId = 263, AttributeType = "Return", Value = 23 },

// Turkey Berfu Cengiz (TUR)
new PlayerAttribute { Id = 1881, PlayerId = 264, AttributeType = "Backhand", Value = 25 },
new PlayerAttribute { Id = 1882, PlayerId = 264, AttributeType = "Forehand", Value = 26 },
new PlayerAttribute { Id = 1883, PlayerId = 264, AttributeType = "Speed", Value = 25 },
new PlayerAttribute { Id = 1884, PlayerId = 264, AttributeType = "Stamina", Value = 14 },
new PlayerAttribute { Id = 1885, PlayerId = 264, AttributeType = "Mental", Value = 23 },
new PlayerAttribute { Id = 1886, PlayerId = 264, AttributeType = "Volley", Value = 22 },
new PlayerAttribute { Id = 1887, PlayerId = 264, AttributeType = "Return", Value = 22 },

// Belgium Marie Benoit (BEL)
new PlayerAttribute { Id = 1888, PlayerId = 265, AttributeType = "Backhand", Value = 26 },
new PlayerAttribute { Id = 1889, PlayerId = 265, AttributeType = "Forehand", Value = 27 },
new PlayerAttribute { Id = 1890, PlayerId = 265, AttributeType = "Speed", Value = 26 },
new PlayerAttribute { Id = 1891, PlayerId = 265, AttributeType = "Stamina", Value = 15 },
new PlayerAttribute { Id = 1892, PlayerId = 265, AttributeType = "Mental", Value = 24 },
new PlayerAttribute { Id = 1893, PlayerId = 265, AttributeType = "Volley", Value = 24 },
new PlayerAttribute { Id = 1894, PlayerId = 265, AttributeType = "Return", Value = 24 },

// USA Louisa Chirico (USA)
new PlayerAttribute { Id = 1895, PlayerId = 266, AttributeType = "Backhand", Value = 26 },
new PlayerAttribute { Id = 1896, PlayerId = 266, AttributeType = "Forehand", Value = 26 },
new PlayerAttribute { Id = 1897, PlayerId = 266, AttributeType = "Speed", Value = 24 },
new PlayerAttribute { Id = 1898, PlayerId = 266, AttributeType = "Stamina", Value = 24 },
new PlayerAttribute { Id = 1899, PlayerId = 266, AttributeType = "Mental", Value = 24 },
new PlayerAttribute { Id = 1900, PlayerId = 266, AttributeType = "Volley", Value = 23 },
new PlayerAttribute { Id = 1901, PlayerId = 266, AttributeType = "Return", Value = 23 },

// Slovenia Polona Hercog (SVN)
new PlayerAttribute { Id = 1902, PlayerId = 267, AttributeType = "Backhand", Value = 27 },
new PlayerAttribute { Id = 1903, PlayerId = 267, AttributeType = "Forehand", Value = 27 },
new PlayerAttribute { Id = 1904, PlayerId = 267, AttributeType = "Speed", Value = 26 },
new PlayerAttribute { Id = 1905, PlayerId = 267, AttributeType = "Stamina", Value = 26 },
new PlayerAttribute { Id = 1906, PlayerId = 267, AttributeType = "Mental", Value = 25 },
new PlayerAttribute { Id = 1907, PlayerId = 267, AttributeType = "Volley", Value = 24 },
new PlayerAttribute { Id = 1908, PlayerId = 267, AttributeType = "Return", Value = 24 },

// China Xinyu Gao (CHN)
new PlayerAttribute { Id = 1909, PlayerId = 268, AttributeType = "Backhand", Value = 36 },
new PlayerAttribute { Id = 1910, PlayerId = 268, AttributeType = "Forehand", Value = 27 },
new PlayerAttribute { Id = 1911, PlayerId = 268, AttributeType = "Speed", Value = 26 },
new PlayerAttribute { Id = 1912, PlayerId = 268, AttributeType = "Stamina", Value = 15 },
new PlayerAttribute { Id = 1913, PlayerId = 268, AttributeType = "Mental", Value = 24 },
new PlayerAttribute { Id = 1914, PlayerId = 268, AttributeType = "Volley", Value = 24 },
new PlayerAttribute { Id = 1915, PlayerId = 268, AttributeType = "Return", Value = 24 },

// Spain Irene Burillo Escorihuela (ESP)
new PlayerAttribute { Id = 1916, PlayerId = 269, AttributeType = "Backhand", Value = 25 },
new PlayerAttribute { Id = 1917, PlayerId = 269, AttributeType = "Forehand", Value = 26 },
new PlayerAttribute { Id = 1918, PlayerId = 269, AttributeType = "Speed", Value = 35 },
new PlayerAttribute { Id = 1919, PlayerId = 269, AttributeType = "Stamina", Value = 35 },
new PlayerAttribute { Id = 1920, PlayerId = 269, AttributeType = "Mental", Value = 14 },
new PlayerAttribute { Id = 1921, PlayerId = 269, AttributeType = "Volley", Value = 13 },
new PlayerAttribute { Id = 1922, PlayerId = 269, AttributeType = "Return", Value = 13 },

// Australia Talia Gibson (AUS)
new PlayerAttribute { Id = 1923, PlayerId = 270, AttributeType = "Backhand", Value = 46 },
new PlayerAttribute { Id = 1924, PlayerId = 270, AttributeType = "Forehand", Value = 46 },
new PlayerAttribute { Id = 1925, PlayerId = 270, AttributeType = "Speed", Value = 45 },
new PlayerAttribute { Id = 1926, PlayerId = 270, AttributeType = "Stamina", Value = 34 },
new PlayerAttribute { Id = 1927, PlayerId = 270, AttributeType = "Mental", Value = 23 },
new PlayerAttribute { Id = 1928, PlayerId = 270, AttributeType = "Volley", Value = 23 },
new PlayerAttribute { Id = 1929, PlayerId = 270, AttributeType = "Return", Value = 23 },

// Japan Haruka Kaji (JPN)
new PlayerAttribute { Id = 1930, PlayerId = 271, AttributeType = "Backhand", Value = 25 },
new PlayerAttribute { Id = 1931, PlayerId = 271, AttributeType = "Forehand", Value = 26 },
new PlayerAttribute { Id = 1932, PlayerId = 271, AttributeType = "Speed", Value = 24 },
new PlayerAttribute { Id = 1933, PlayerId = 271, AttributeType = "Stamina", Value = 24 },
new PlayerAttribute { Id = 1934, PlayerId = 271, AttributeType = "Mental", Value = 23 },
new PlayerAttribute { Id = 1935, PlayerId = 271, AttributeType = "Volley", Value = 12 },
new PlayerAttribute { Id = 1936, PlayerId = 271, AttributeType = "Return", Value = 12 },

// Russia Vera Zvonareva (RUS)
new PlayerAttribute { Id = 1937, PlayerId = 272, AttributeType = "Backhand", Value = 27 },
new PlayerAttribute { Id = 1938, PlayerId = 272, AttributeType = "Forehand", Value = 37 },
new PlayerAttribute { Id = 1939, PlayerId = 272, AttributeType = "Speed", Value = 35 },
new PlayerAttribute { Id = 1940, PlayerId = 272, AttributeType = "Stamina", Value = 26 },
new PlayerAttribute { Id = 1941, PlayerId = 272, AttributeType = "Mental", Value = 26 },
new PlayerAttribute { Id = 1942, PlayerId = 272, AttributeType = "Volley", Value = 25 },
new PlayerAttribute { Id = 1943, PlayerId = 272, AttributeType = "Return", Value = 25 },

// Canada Marina Stakusic (CAN)
new PlayerAttribute { Id = 1944, PlayerId = 273, AttributeType = "Backhand", Value = 46 },
new PlayerAttribute { Id = 1945, PlayerId = 273, AttributeType = "Forehand", Value = 46 },
new PlayerAttribute { Id = 1946, PlayerId = 273, AttributeType = "Speed", Value = 35 },
new PlayerAttribute { Id = 1947, PlayerId = 273, AttributeType = "Stamina", Value = 34 },
new PlayerAttribute { Id = 1948, PlayerId = 273, AttributeType = "Mental", Value = 33 },
new PlayerAttribute { Id = 1949, PlayerId = 273, AttributeType = "Volley", Value = 33 },
new PlayerAttribute { Id = 1950, PlayerId = 273, AttributeType = "Return", Value = 33 },

// Bulgaria Isabella Shinikova (BGR)
new PlayerAttribute { Id = 1951, PlayerId = 274, AttributeType = "Backhand", Value = 26 },
new PlayerAttribute { Id = 1952, PlayerId = 274, AttributeType = "Forehand", Value = 26 },
new PlayerAttribute { Id = 1953, PlayerId = 274, AttributeType = "Speed", Value = 15 },
new PlayerAttribute { Id = 1954, PlayerId = 274, AttributeType = "Stamina", Value = 15 },
new PlayerAttribute { Id = 1955, PlayerId = 274, AttributeType = "Mental", Value = 24 },
new PlayerAttribute { Id = 1956, PlayerId = 274, AttributeType = "Volley", Value = 23 },
new PlayerAttribute { Id = 1957, PlayerId = 274, AttributeType = "Return", Value = 23 },

// Croatia Lucija Ciric Bagaric (HRV)
new PlayerAttribute { Id = 1958, PlayerId = 275, AttributeType = "Backhand", Value = 36 },
new PlayerAttribute { Id = 1959, PlayerId = 275, AttributeType = "Forehand", Value = 36 },
new PlayerAttribute { Id = 1960, PlayerId = 275, AttributeType = "Speed", Value = 45 },
new PlayerAttribute { Id = 1961, PlayerId = 275, AttributeType = "Stamina", Value = 44 },
new PlayerAttribute { Id = 1962, PlayerId = 275, AttributeType = "Mental", Value = 32 },
new PlayerAttribute { Id = 1963, PlayerId = 275, AttributeType = "Volley", Value = 32 },
new PlayerAttribute { Id = 1964, PlayerId = 275, AttributeType = "Return", Value = 32 },

// Ukraine Kateryna Volodko (UKR)
new PlayerAttribute { Id = 1965, PlayerId = 276, AttributeType = "Backhand", Value = 25 },
new PlayerAttribute { Id = 1966, PlayerId = 276, AttributeType = "Forehand", Value = 22 },
new PlayerAttribute { Id = 1967, PlayerId = 276, AttributeType = "Speed", Value = 25 },
new PlayerAttribute { Id = 1968, PlayerId = 276, AttributeType = "Stamina", Value = 24 },
new PlayerAttribute { Id = 1969, PlayerId = 276, AttributeType = "Mental", Value = 13 },
new PlayerAttribute { Id = 1970, PlayerId = 276, AttributeType = "Volley", Value = 22 },
new PlayerAttribute { Id = 1971, PlayerId = 276, AttributeType = "Return", Value = 22 },

// Taipei (CHN) En Shuo Liang (TAI)
new PlayerAttribute { Id = 1972, PlayerId = 277, AttributeType = "Backhand", Value = 46 },
new PlayerAttribute { Id = 1973, PlayerId = 277, AttributeType = "Forehand", Value = 44 },
new PlayerAttribute { Id = 1974, PlayerId = 277, AttributeType = "Speed", Value = 45 },
new PlayerAttribute { Id = 1975, PlayerId = 277, AttributeType = "Stamina", Value = 34 },
new PlayerAttribute { Id = 1976, PlayerId = 277, AttributeType = "Mental", Value = 23 },
new PlayerAttribute { Id = 1977, PlayerId = 277, AttributeType = "Volley", Value = 23 },
new PlayerAttribute { Id = 1978, PlayerId = 277, AttributeType = "Return", Value = 13 },

// Serbia Lola Radivojevic (SRB)
new PlayerAttribute { Id = 1979, PlayerId = 278, AttributeType = "Backhand", Value = 35 },
new PlayerAttribute { Id = 1980, PlayerId = 278, AttributeType = "Forehand", Value = 36 },
new PlayerAttribute { Id = 1981, PlayerId = 278, AttributeType = "Speed", Value = 25 },
new PlayerAttribute { Id = 1982, PlayerId = 278, AttributeType = "Stamina", Value = 24 },
new PlayerAttribute { Id = 1983, PlayerId = 278, AttributeType = "Mental", Value = 23 },
new PlayerAttribute { Id = 1984, PlayerId = 278, AttributeType = "Volley", Value = 23 },
new PlayerAttribute { Id = 1985, PlayerId = 278, AttributeType = "Return", Value = 23 },

// Germany Silvia Ambrosio (DEU)
new PlayerAttribute { Id = 1986, PlayerId = 279, AttributeType = "Backhand", Value = 25 },
new PlayerAttribute { Id = 1987, PlayerId = 279, AttributeType = "Forehand", Value = 16 },
new PlayerAttribute { Id = 1988, PlayerId = 279, AttributeType = "Speed", Value = 14 },
new PlayerAttribute { Id = 1989, PlayerId = 279, AttributeType = "Stamina", Value = 24 },
new PlayerAttribute { Id = 1990, PlayerId = 279, AttributeType = "Mental", Value = 23 },
new PlayerAttribute { Id = 1991, PlayerId = 279, AttributeType = "Volley", Value = 12 },
new PlayerAttribute { Id = 1992, PlayerId = 279, AttributeType = "Return", Value = 12 },

// United Kingdom Katie Swan (GBR)
new PlayerAttribute { Id = 1993, PlayerId = 280, AttributeType = "Backhand", Value = 36 },
new PlayerAttribute { Id = 1994, PlayerId = 280, AttributeType = "Forehand", Value = 36 },
new PlayerAttribute { Id = 1995, PlayerId = 280, AttributeType = "Speed", Value = 25 },
new PlayerAttribute { Id = 1996, PlayerId = 280, AttributeType = "Stamina", Value = 34 },
new PlayerAttribute { Id = 1997, PlayerId = 280, AttributeType = "Mental", Value = 23 },
new PlayerAttribute { Id = 1998, PlayerId = 280, AttributeType = "Volley", Value = 33 },
new PlayerAttribute { Id = 1999, PlayerId = 280, AttributeType = "Return", Value = 23 },

// Romania Cristina Dinu (ROU)
new PlayerAttribute { Id = 2000, PlayerId = 281, AttributeType = "Backhand", Value = 15 },
new PlayerAttribute { Id = 2001, PlayerId = 281, AttributeType = "Forehand", Value = 25 },
new PlayerAttribute { Id = 2002, PlayerId = 281, AttributeType = "Speed", Value = 25 },
new PlayerAttribute { Id = 2003, PlayerId = 281, AttributeType = "Stamina", Value = 24 },
new PlayerAttribute { Id = 2004, PlayerId = 281, AttributeType = "Mental", Value = 13 },
new PlayerAttribute { Id = 2005, PlayerId = 281, AttributeType = "Volley", Value = 12 },
new PlayerAttribute { Id = 2006, PlayerId = 281, AttributeType = "Return", Value = 12 },

// Hong Kong Eudice Wong Chong (HKG)
new PlayerAttribute { Id = 2007, PlayerId = 282, AttributeType = "Backhand", Value = 25 },
new PlayerAttribute { Id = 2008, PlayerId = 282, AttributeType = "Forehand", Value = 25 },
new PlayerAttribute { Id = 2009, PlayerId = 282, AttributeType = "Speed", Value = 25 },
new PlayerAttribute { Id = 2010, PlayerId = 282, AttributeType = "Stamina", Value = 14 },
new PlayerAttribute { Id = 2011, PlayerId = 282, AttributeType = "Mental", Value = 13 },
new PlayerAttribute { Id = 2012, PlayerId = 282, AttributeType = "Volley", Value = 12 },
new PlayerAttribute { Id = 2013, PlayerId = 282, AttributeType = "Return", Value = 12 },

// Greece Sapfo Sakellaridi (GRC)
new PlayerAttribute { Id = 2014, PlayerId = 283, AttributeType = "Backhand", Value = 15 },
new PlayerAttribute { Id = 2015, PlayerId = 283, AttributeType = "Forehand", Value = 16 },
new PlayerAttribute { Id = 2016, PlayerId = 283, AttributeType = "Speed", Value = 14 },
new PlayerAttribute { Id = 2017, PlayerId = 283, AttributeType = "Stamina", Value = 24 },
new PlayerAttribute { Id = 2018, PlayerId = 283, AttributeType = "Mental", Value = 23 },
new PlayerAttribute { Id = 2019, PlayerId = 283, AttributeType = "Volley", Value = 22 },
new PlayerAttribute { Id = 2020, PlayerId = 283, AttributeType = "Return", Value = 22 },

// USA Grace Min (USA)
new PlayerAttribute { Id = 2021, PlayerId = 284, AttributeType = "Backhand", Value = 15 },
new PlayerAttribute { Id = 2022, PlayerId = 284, AttributeType = "Forehand", Value = 15 },
new PlayerAttribute { Id = 2023, PlayerId = 284, AttributeType = "Speed", Value = 14 },
new PlayerAttribute { Id = 2024, PlayerId = 284, AttributeType = "Stamina", Value = 14 },
new PlayerAttribute { Id = 2025, PlayerId = 284, AttributeType = "Mental", Value = 13 },
new PlayerAttribute { Id = 2026, PlayerId = 284, AttributeType = "Volley", Value = 12 },
new PlayerAttribute { Id = 2027, PlayerId = 284, AttributeType = "Return", Value = 12 },

// Australia Maddison Inglis (AUS)
new PlayerAttribute { Id = 2028, PlayerId = 285, AttributeType = "Backhand", Value = 26 },
new PlayerAttribute { Id = 2029, PlayerId = 285, AttributeType = "Forehand", Value = 26 },
new PlayerAttribute { Id = 2030, PlayerId = 285, AttributeType = "Speed", Value = 25 },
new PlayerAttribute { Id = 2031, PlayerId = 285, AttributeType = "Stamina", Value = 24 },
new PlayerAttribute { Id = 2032, PlayerId = 285, AttributeType = "Mental", Value = 23 },
new PlayerAttribute { Id = 2033, PlayerId = 285, AttributeType = "Volley", Value = 23 },
new PlayerAttribute { Id = 2034, PlayerId = 285, AttributeType = "Return", Value = 23 },

// Romania Alexandra Cadantu (ROU)
new PlayerAttribute { Id = 2035, PlayerId = 286, AttributeType = "Backhand", Value = 15 },
new PlayerAttribute { Id = 2036, PlayerId = 286, AttributeType = "Forehand", Value = 25 },
new PlayerAttribute { Id = 2037, PlayerId = 286, AttributeType = "Speed", Value = 15 },
new PlayerAttribute { Id = 2038, PlayerId = 286, AttributeType = "Stamina", Value = 14 },
new PlayerAttribute { Id = 2039, PlayerId = 286, AttributeType = "Mental", Value = 13 },
new PlayerAttribute { Id = 2040, PlayerId = 286, AttributeType = "Volley", Value = 12 },
new PlayerAttribute { Id = 2041, PlayerId = 286, AttributeType = "Return", Value = 12 },

// Canada Eugenie Bouchard (CAN)
new PlayerAttribute { Id = 2042, PlayerId = 287, AttributeType = "Backhand", Value = 46 },
new PlayerAttribute { Id = 2043, PlayerId = 287, AttributeType = "Forehand", Value = 36 },
new PlayerAttribute { Id = 2044, PlayerId = 287, AttributeType = "Speed", Value = 35 },
new PlayerAttribute { Id = 2045, PlayerId = 287, AttributeType = "Stamina", Value = 24 },
new PlayerAttribute { Id = 2046, PlayerId = 287, AttributeType = "Mental", Value = 24 },
new PlayerAttribute { Id = 2047, PlayerId = 287, AttributeType = "Volley", Value = 23 },
new PlayerAttribute { Id = 2048, PlayerId = 287, AttributeType = "Return", Value = 33 },

// Japan Sakura Hosogi (JPN)
new PlayerAttribute { Id = 2049, PlayerId = 288, AttributeType = "Backhand", Value = 25 },
new PlayerAttribute { Id = 2050, PlayerId = 288, AttributeType = "Forehand", Value = 15 },
new PlayerAttribute { Id = 2051, PlayerId = 288, AttributeType = "Speed", Value = 25 },
new PlayerAttribute { Id = 2052, PlayerId = 288, AttributeType = "Stamina", Value = 24 },
new PlayerAttribute { Id = 2053, PlayerId = 288, AttributeType = "Mental", Value = 13 },
new PlayerAttribute { Id = 2054, PlayerId = 288, AttributeType = "Volley", Value = 13 },
new PlayerAttribute { Id = 2055, PlayerId = 288, AttributeType = "Return", Value = 13 },

// USA Maria Mateas (USA)
new PlayerAttribute { Id = 2056, PlayerId = 289, AttributeType = "Backhand", Value = 16 },
new PlayerAttribute { Id = 2057, PlayerId = 289, AttributeType = "Forehand", Value = 26 },
new PlayerAttribute { Id = 2058, PlayerId = 289, AttributeType = "Speed", Value = 25 },
new PlayerAttribute { Id = 2059, PlayerId = 289, AttributeType = "Stamina", Value = 24 },
new PlayerAttribute { Id = 2060, PlayerId = 289, AttributeType = "Mental", Value = 13 },
new PlayerAttribute { Id = 2061, PlayerId = 289, AttributeType = "Volley", Value = 23 },
new PlayerAttribute { Id = 2062, PlayerId = 289, AttributeType = "Return", Value = 23 },

// Australia Ajla Tomljanovic (AUS)
new PlayerAttribute { Id = 2063, PlayerId = 290, AttributeType = "Backhand", Value = 46 },
new PlayerAttribute { Id = 2064, PlayerId = 290, AttributeType = "Forehand", Value = 36 },
new PlayerAttribute { Id = 2065, PlayerId = 290, AttributeType = "Speed", Value = 45 },
new PlayerAttribute { Id = 2066, PlayerId = 290, AttributeType = "Stamina", Value = 44 },
new PlayerAttribute { Id = 2067, PlayerId = 290, AttributeType = "Mental", Value = 33 },
new PlayerAttribute { Id = 2068, PlayerId = 290, AttributeType = "Volley", Value = 43 },
new PlayerAttribute { Id = 2069, PlayerId = 290, AttributeType = "Return", Value = 43 },

// USA Varvara Lepchenko (USA)
new PlayerAttribute { Id = 2070, PlayerId = 291, AttributeType = "Backhand", Value = 35 },
new PlayerAttribute { Id = 2071, PlayerId = 291, AttributeType = "Forehand", Value = 35 },
new PlayerAttribute { Id = 2072, PlayerId = 291, AttributeType = "Speed", Value = 25 },
new PlayerAttribute { Id = 2073, PlayerId = 291, AttributeType = "Stamina", Value = 34 },
new PlayerAttribute { Id = 2074, PlayerId = 291, AttributeType = "Mental", Value = 32 },
new PlayerAttribute { Id = 2075, PlayerId = 291, AttributeType = "Volley", Value = 32 },
new PlayerAttribute { Id = 2076, PlayerId = 291, AttributeType = "Return", Value = 23 },

// Liechtenstein Kathinka Von Deichmann (LIE)
new PlayerAttribute { Id = 2077, PlayerId = 292, AttributeType = "Backhand", Value = 26 },
new PlayerAttribute { Id = 2078, PlayerId = 292, AttributeType = "Forehand", Value = 26 },
new PlayerAttribute { Id = 2079, PlayerId = 292, AttributeType = "Speed", Value = 25 },
new PlayerAttribute { Id = 2080, PlayerId = 292, AttributeType = "Stamina", Value = 24 },
new PlayerAttribute { Id = 2081, PlayerId = 292, AttributeType = "Mental", Value = 23 },
new PlayerAttribute { Id = 2082, PlayerId = 292, AttributeType = "Volley", Value = 23 },
new PlayerAttribute { Id = 2083, PlayerId = 292, AttributeType = "Return", Value = 23 },

// USA Jamie Loeb (USA)
new PlayerAttribute { Id = 2084, PlayerId = 293, AttributeType = "Backhand", Value = 25 },
new PlayerAttribute { Id = 2085, PlayerId = 293, AttributeType = "Forehand", Value = 25 },
new PlayerAttribute { Id = 2086, PlayerId = 293, AttributeType = "Speed", Value = 14 },
new PlayerAttribute { Id = 2087, PlayerId = 293, AttributeType = "Stamina", Value = 14 },
new PlayerAttribute { Id = 2088, PlayerId = 293, AttributeType = "Mental", Value = 23 },
new PlayerAttribute { Id = 2089, PlayerId = 293, AttributeType = "Volley", Value = 22 },
new PlayerAttribute { Id = 2090, PlayerId = 293, AttributeType = "Return", Value = 22 },

// Czech Republic Nikola Bartunkova (CZE)
new PlayerAttribute { Id = 2091, PlayerId = 294, AttributeType = "Backhand", Value = 36 },
new PlayerAttribute { Id = 2092, PlayerId = 294, AttributeType = "Forehand", Value = 36 },
new PlayerAttribute { Id = 2093, PlayerId = 294, AttributeType = "Speed", Value = 35 },
new PlayerAttribute { Id = 2094, PlayerId = 294, AttributeType = "Stamina", Value = 24 },
new PlayerAttribute { Id = 2095, PlayerId = 294, AttributeType = "Mental", Value = 33 },
new PlayerAttribute { Id = 2096, PlayerId = 294, AttributeType = "Volley", Value = 23 },
new PlayerAttribute { Id = 2097, PlayerId = 294, AttributeType = "Return", Value = 33 },

// Czech Republic Julie Struplova (CZE)
new PlayerAttribute { Id = 2098, PlayerId = 295, AttributeType = "Backhand", Value = 26 },
new PlayerAttribute { Id = 2099, PlayerId = 295, AttributeType = "Forehand", Value = 26 },
new PlayerAttribute { Id = 2100, PlayerId = 295, AttributeType = "Speed", Value = 15 },
new PlayerAttribute { Id = 2101, PlayerId = 295, AttributeType = "Stamina", Value = 14 },
new PlayerAttribute { Id = 2102, PlayerId = 295, AttributeType = "Mental", Value = 13 },
new PlayerAttribute { Id = 2103, PlayerId = 295, AttributeType = "Volley", Value = 23 },
new PlayerAttribute { Id = 2104, PlayerId = 295, AttributeType = "Return", Value = 13 },

// United Kingdom Francesca Jones (GBR)
new PlayerAttribute { Id = 2105, PlayerId = 296, AttributeType = "Backhand", Value = 25 },
new PlayerAttribute { Id = 2106, PlayerId = 296, AttributeType = "Forehand", Value = 35 },
new PlayerAttribute { Id = 2107, PlayerId = 296, AttributeType = "Speed", Value = 35 },
new PlayerAttribute { Id = 2108, PlayerId = 296, AttributeType = "Stamina", Value = 24 },
new PlayerAttribute { Id = 2109, PlayerId = 296, AttributeType = "Mental", Value = 23 },
new PlayerAttribute { Id = 2110, PlayerId = 296, AttributeType = "Volley", Value = 23 },
new PlayerAttribute { Id = 2111, PlayerId = 296, AttributeType = "Return", Value = 23 },

// Spain Rosa Vicens Mas (ESP)
new PlayerAttribute { Id = 2112, PlayerId = 297, AttributeType = "Backhand", Value = 25 },
new PlayerAttribute { Id = 2113, PlayerId = 297, AttributeType = "Forehand", Value = 25 },
new PlayerAttribute { Id = 2114, PlayerId = 297, AttributeType = "Speed", Value = 25 },
new PlayerAttribute { Id = 2115, PlayerId = 297, AttributeType = "Stamina", Value = 14 },
new PlayerAttribute { Id = 2116, PlayerId = 297, AttributeType = "Mental", Value = 13 },
new PlayerAttribute { Id = 2117, PlayerId = 297, AttributeType = "Volley", Value = 13 },
new PlayerAttribute { Id = 2118, PlayerId = 297, AttributeType = "Return", Value = 13 },

// United Kingdom Emma Raducanu (GBR)
new PlayerAttribute { Id = 2119, PlayerId = 298, AttributeType = "Backhand", Value = 46 },
new PlayerAttribute { Id = 2120, PlayerId = 298, AttributeType = "Forehand", Value = 56 },
new PlayerAttribute { Id = 2121, PlayerId = 298, AttributeType = "Speed", Value = 56 },
new PlayerAttribute { Id = 2122, PlayerId = 298, AttributeType = "Stamina", Value = 45 },
new PlayerAttribute { Id = 2123, PlayerId = 298, AttributeType = "Mental", Value = 44 },
new PlayerAttribute { Id = 2124, PlayerId = 298, AttributeType = "Volley", Value = 43 },
new PlayerAttribute { Id = 2125, PlayerId = 298, AttributeType = "Return", Value = 34 },

// Spain Guiomar Zuleta De Reales (ESP)
new PlayerAttribute { Id = 2126, PlayerId = 299, AttributeType = "Backhand", Value = 25 },
new PlayerAttribute { Id = 2127, PlayerId = 299, AttributeType = "Forehand", Value = 25 },
new PlayerAttribute { Id = 2128, PlayerId = 299, AttributeType = "Speed", Value = 25 },
new PlayerAttribute { Id = 2129, PlayerId = 299, AttributeType = "Stamina", Value = 24 },
new PlayerAttribute { Id = 2130, PlayerId = 299, AttributeType = "Mental", Value = 13 },
new PlayerAttribute { Id = 2131, PlayerId = 299, AttributeType = "Volley", Value = 13 },
new PlayerAttribute { Id = 2132, PlayerId = 299, AttributeType = "Return", Value = 23 },

// Switzerland Valentina Ryser (CHE)
new PlayerAttribute { Id = 2133, PlayerId = 300, AttributeType = "Backhand", Value = 15 },
new PlayerAttribute { Id = 2134, PlayerId = 300, AttributeType = "Forehand", Value = 15 },
new PlayerAttribute { Id = 2135, PlayerId = 300, AttributeType = "Speed", Value = 14 },
new PlayerAttribute { Id = 2136, PlayerId = 300, AttributeType = "Stamina", Value = 14 },
new PlayerAttribute { Id = 2137, PlayerId = 300, AttributeType = "Mental", Value = 23 },
new PlayerAttribute { Id = 2138, PlayerId = 300, AttributeType = "Volley", Value = 13 },
new PlayerAttribute { Id = 2139, PlayerId = 300, AttributeType = "Return", Value = 13 },

// Mexico Ana Sofia Sanchez (MEX)
new PlayerAttribute { Id = 2140, PlayerId = 301, AttributeType = "Backhand", Value = 15 },
new PlayerAttribute { Id = 2141, PlayerId = 301, AttributeType = "Forehand", Value = 11 },
new PlayerAttribute { Id = 2142, PlayerId = 301, AttributeType = "Speed", Value = 14 },
new PlayerAttribute { Id = 2143, PlayerId = 301, AttributeType = "Stamina", Value = 14 },
new PlayerAttribute { Id = 2144, PlayerId = 301, AttributeType = "Mental", Value = 23 },
new PlayerAttribute { Id = 2145, PlayerId = 301, AttributeType = "Volley", Value = 12 },
new PlayerAttribute { Id = 2146, PlayerId = 301, AttributeType = "Return", Value = 12 },

// Italy Georgia Pedone (ITA)
new PlayerAttribute { Id = 2147, PlayerId = 302, AttributeType = "Backhand", Value = 25 },
new PlayerAttribute { Id = 2148, PlayerId = 302, AttributeType = "Forehand", Value = 25 },
new PlayerAttribute { Id = 2149, PlayerId = 302, AttributeType = "Speed", Value = 15 },
new PlayerAttribute { Id = 2150, PlayerId = 302, AttributeType = "Stamina", Value = 14 },
new PlayerAttribute { Id = 2151, PlayerId = 302, AttributeType = "Mental", Value = 13 },
new PlayerAttribute { Id = 2152, PlayerId = 302, AttributeType = "Volley", Value = 13 },
new PlayerAttribute { Id = 2153, PlayerId = 302, AttributeType = "Return", Value = 13 },

// Belgium Hanne Vandewinkel (BEL)
new PlayerAttribute { Id = 2154, PlayerId = 303, AttributeType = "Backhand", Value = 35 },
new PlayerAttribute { Id = 2155, PlayerId = 303, AttributeType = "Forehand", Value = 45 },
new PlayerAttribute { Id = 2156, PlayerId = 303, AttributeType = "Speed", Value = 35 },
new PlayerAttribute { Id = 2157, PlayerId = 303, AttributeType = "Stamina", Value = 24 },
new PlayerAttribute { Id = 2158, PlayerId = 303, AttributeType = "Mental", Value = 23 },
new PlayerAttribute { Id = 2159, PlayerId = 303, AttributeType = "Volley", Value = 23 },
new PlayerAttribute { Id = 2160, PlayerId = 303, AttributeType = "Return", Value = 33 },

// Brazil Carolina Meligeni Alves (BRA)
new PlayerAttribute { Id = 2161, PlayerId = 304, AttributeType = "Backhand", Value = 26 },
new PlayerAttribute { Id = 2162, PlayerId = 304, AttributeType = "Forehand", Value = 16 },
new PlayerAttribute { Id = 2163, PlayerId = 304, AttributeType = "Speed", Value = 15 },
new PlayerAttribute { Id = 2164, PlayerId = 304, AttributeType = "Stamina", Value = 14 },
new PlayerAttribute { Id = 2165, PlayerId = 304, AttributeType = "Mental", Value = 14 },
new PlayerAttribute { Id = 2166, PlayerId = 304, AttributeType = "Volley", Value = 24 },
new PlayerAttribute { Id = 2167, PlayerId = 304, AttributeType = "Return", Value = 24 },

// Spain Leyre Romero Gormaz (ESP)
new PlayerAttribute { Id = 2168, PlayerId = 305, AttributeType = "Backhand", Value = 15 },
new PlayerAttribute { Id = 2169, PlayerId = 305, AttributeType = "Forehand", Value = 15 },
new PlayerAttribute { Id = 2170, PlayerId = 305, AttributeType = "Speed", Value = 25 },
new PlayerAttribute { Id = 2171, PlayerId = 305, AttributeType = "Stamina", Value = 24 },
new PlayerAttribute { Id = 2172, PlayerId = 305, AttributeType = "Mental", Value = 13 },
new PlayerAttribute { Id = 2173, PlayerId = 305, AttributeType = "Volley", Value = 13 },
new PlayerAttribute { Id = 2174, PlayerId = 305, AttributeType = "Return", Value = 13 },

// United Kingdom Amarni Banks (GBR)
new PlayerAttribute { Id = 2175, PlayerId = 306, AttributeType = "Backhand", Value = 25 },
new PlayerAttribute { Id = 2176, PlayerId = 306, AttributeType = "Forehand", Value = 25 },
new PlayerAttribute { Id = 2177, PlayerId = 306, AttributeType = "Speed", Value = 15 },
new PlayerAttribute { Id = 2178, PlayerId = 306, AttributeType = "Stamina", Value = 14 },
new PlayerAttribute { Id = 2179, PlayerId = 306, AttributeType = "Mental", Value = 12 },
new PlayerAttribute { Id = 2180, PlayerId = 306, AttributeType = "Volley", Value = 13 },
new PlayerAttribute { Id = 2181, PlayerId = 306, AttributeType = "Return", Value = 23 },

// Andorra Victoria Jimenez Kasintseva (AND)
new PlayerAttribute { Id = 2182, PlayerId = 307, AttributeType = "Backhand", Value = 36 },
new PlayerAttribute { Id = 2183, PlayerId = 307, AttributeType = "Forehand", Value = 36 },
new PlayerAttribute { Id = 2184, PlayerId = 307, AttributeType = "Speed", Value = 53 },
new PlayerAttribute { Id = 2185, PlayerId = 307, AttributeType = "Stamina", Value = 24 },
new PlayerAttribute { Id = 2186, PlayerId = 307, AttributeType = "Mental", Value = 24 },
new PlayerAttribute { Id = 2187, PlayerId = 307, AttributeType = "Volley", Value = 14 },
new PlayerAttribute { Id = 2188, PlayerId = 307, AttributeType = "Return", Value = 24 },

// Finland Anastasia Kulikova (FIN)
new PlayerAttribute { Id = 2189, PlayerId = 308, AttributeType = "Backhand", Value = 15 },
new PlayerAttribute { Id = 2190, PlayerId = 308, AttributeType = "Forehand", Value = 15 },
new PlayerAttribute { Id = 2191, PlayerId = 308, AttributeType = "Speed", Value = 15 },
new PlayerAttribute { Id = 2192, PlayerId = 308, AttributeType = "Stamina", Value = 14 },
new PlayerAttribute { Id = 2193, PlayerId = 308, AttributeType = "Mental", Value = 13 },
new PlayerAttribute { Id = 2194, PlayerId = 308, AttributeType = "Volley", Value = 13 },
new PlayerAttribute { Id = 2195, PlayerId = 308, AttributeType = "Return", Value = 13 },

// Republic of Korea Sohyun Park (KOR)
new PlayerAttribute { Id = 2196, PlayerId = 309, AttributeType = "Backhand", Value = 15 },
new PlayerAttribute { Id = 2197, PlayerId = 309, AttributeType = "Forehand", Value = 15 },
new PlayerAttribute { Id = 2198, PlayerId = 309, AttributeType = "Speed", Value = 15 },
new PlayerAttribute { Id = 2199, PlayerId = 309, AttributeType = "Stamina", Value = 14 },
new PlayerAttribute { Id = 2200, PlayerId = 309, AttributeType = "Mental", Value = 13 },
new PlayerAttribute { Id = 2201, PlayerId = 309, AttributeType = "Volley", Value = 23 },
new PlayerAttribute { Id = 2202, PlayerId = 309, AttributeType = "Return", Value = 13 },

// Russia Maria Bondarenko (RUS)
new PlayerAttribute { Id = 2203, PlayerId = 310, AttributeType = "Backhand", Value = 15 },
new PlayerAttribute { Id = 2204, PlayerId = 310, AttributeType = "Forehand", Value = 25 },
new PlayerAttribute { Id = 2205, PlayerId = 310, AttributeType = "Speed", Value = 24 },
new PlayerAttribute { Id = 2206, PlayerId = 310, AttributeType = "Stamina", Value = 24 },
new PlayerAttribute { Id = 2207, PlayerId = 310, AttributeType = "Mental", Value = 32 },
new PlayerAttribute { Id = 2208, PlayerId = 310, AttributeType = "Volley", Value = 23 },
new PlayerAttribute { Id = 2209, PlayerId = 310, AttributeType = "Return", Value = 23 },

// Germany Sabine Lisicki (DEU)
new PlayerAttribute { Id = 2210, PlayerId = 311, AttributeType = "Backhand", Value = 26 },
new PlayerAttribute { Id = 2211, PlayerId = 311, AttributeType = "Forehand", Value = 26 },
new PlayerAttribute { Id = 2212, PlayerId = 311, AttributeType = "Speed", Value = 23 },
new PlayerAttribute { Id = 2213, PlayerId = 311, AttributeType = "Stamina", Value = 24 },
new PlayerAttribute { Id = 2214, PlayerId = 311, AttributeType = "Mental", Value = 24 },
new PlayerAttribute { Id = 2215, PlayerId = 311, AttributeType = "Volley", Value = 15 },
new PlayerAttribute { Id = 2216, PlayerId = 311, AttributeType = "Return", Value = 24 },

// France Lois Boisson (FRA)
new PlayerAttribute { Id = 2217, PlayerId = 312, AttributeType = "Backhand", Value = 34 },
new PlayerAttribute { Id = 2218, PlayerId = 312, AttributeType = "Forehand", Value = 44 },
new PlayerAttribute { Id = 2219, PlayerId = 312, AttributeType = "Speed", Value = 24 },
new PlayerAttribute { Id = 2220, PlayerId = 312, AttributeType = "Stamina", Value = 13 },
new PlayerAttribute { Id = 2221, PlayerId = 312, AttributeType = "Mental", Value = 13 },
new PlayerAttribute { Id = 2222, PlayerId = 312, AttributeType = "Volley", Value = 23 },
new PlayerAttribute { Id = 2223, PlayerId = 312, AttributeType = "Return", Value = 23 },

// France Amandine Hesse (FRA)
new PlayerAttribute { Id = 2224, PlayerId = 313, AttributeType = "Backhand", Value = 25 },
new PlayerAttribute { Id = 2225, PlayerId = 313, AttributeType = "Forehand", Value = 15 },
new PlayerAttribute { Id = 2226, PlayerId = 313, AttributeType = "Speed", Value = 41 },
new PlayerAttribute { Id = 2227, PlayerId = 313, AttributeType = "Stamina", Value = 24 },
new PlayerAttribute { Id = 2228, PlayerId = 313, AttributeType = "Mental", Value = 23 },
new PlayerAttribute { Id = 2229, PlayerId = 313, AttributeType = "Volley", Value = 23 },
new PlayerAttribute { Id = 2230, PlayerId = 313, AttributeType = "Return", Value = 13 },

// Russia Veronica Miroshnichenko (RUS)
new PlayerAttribute { Id = 2231, PlayerId = 314, AttributeType = "Backhand", Value = 15 },
new PlayerAttribute { Id = 2232, PlayerId = 314, AttributeType = "Forehand", Value = 15 },
new PlayerAttribute { Id = 2233, PlayerId = 314, AttributeType = "Speed", Value = 24 },
new PlayerAttribute { Id = 2234, PlayerId = 314, AttributeType = "Stamina", Value = 23 },
new PlayerAttribute { Id = 2235, PlayerId = 314, AttributeType = "Mental", Value = 13 },
new PlayerAttribute { Id = 2236, PlayerId = 314, AttributeType = "Volley", Value = 13 },
new PlayerAttribute { Id = 2237, PlayerId = 314, AttributeType = "Return", Value = 13 },

// Malta Francesca Curmi (MLT)
new PlayerAttribute { Id = 2238, PlayerId = 315, AttributeType = "Backhand", Value = 34 },
new PlayerAttribute { Id = 2239, PlayerId = 315, AttributeType = "Forehand", Value = 14 },
new PlayerAttribute { Id = 2240, PlayerId = 315, AttributeType = "Speed", Value = 14 },
new PlayerAttribute { Id = 2241, PlayerId = 315, AttributeType = "Stamina", Value = 13 },
new PlayerAttribute { Id = 2242, PlayerId = 315, AttributeType = "Mental", Value = 13 },
new PlayerAttribute { Id = 2243, PlayerId = 315, AttributeType = "Volley", Value = 13 },
new PlayerAttribute { Id = 2244, PlayerId = 315, AttributeType = "Return", Value = 13 },

// Japan Ayano Shimizu (JPN)
new PlayerAttribute { Id = 2245, PlayerId = 316, AttributeType = "Backhand", Value = 15 },
new PlayerAttribute { Id = 2246, PlayerId = 316, AttributeType = "Forehand", Value = 15 },
new PlayerAttribute { Id = 2247, PlayerId = 316, AttributeType = "Speed", Value = 14 },
new PlayerAttribute { Id = 2248, PlayerId = 316, AttributeType = "Stamina", Value = 13 },
new PlayerAttribute { Id = 2249, PlayerId = 316, AttributeType = "Mental", Value = 13 },
new PlayerAttribute { Id = 2250, PlayerId = 316, AttributeType = "Volley", Value = 53 },
new PlayerAttribute { Id = 2251, PlayerId = 316, AttributeType = "Return", Value = 13 },

// Australia Lizette Cabrera (AUS)
new PlayerAttribute { Id = 2252, PlayerId = 317, AttributeType = "Backhand", Value = 25 },
new PlayerAttribute { Id = 2253, PlayerId = 317, AttributeType = "Forehand", Value = 35 },
new PlayerAttribute { Id = 2254, PlayerId = 317, AttributeType = "Speed", Value = 14 },
new PlayerAttribute { Id = 2255, PlayerId = 317, AttributeType = "Stamina", Value = 14 },
new PlayerAttribute { Id = 2256, PlayerId = 317, AttributeType = "Mental", Value = 11 },
new PlayerAttribute { Id = 2257, PlayerId = 317, AttributeType = "Volley", Value = 13 },
new PlayerAttribute { Id = 2258, PlayerId = 317, AttributeType = "Return", Value = 13 },

// Greece Martha Matoula (GRC)
new PlayerAttribute { Id = 2259, PlayerId = 318, AttributeType = "Backhand", Value = 25 },
new PlayerAttribute { Id = 2260, PlayerId = 318, AttributeType = "Forehand", Value = 15 },
new PlayerAttribute { Id = 2261, PlayerId = 318, AttributeType = "Speed", Value = 14 },
new PlayerAttribute { Id = 2262, PlayerId = 318, AttributeType = "Stamina", Value = 13 },
new PlayerAttribute { Id = 2263, PlayerId = 318, AttributeType = "Mental", Value = 23 },
new PlayerAttribute { Id = 2264, PlayerId = 318, AttributeType = "Volley", Value = 13 },
new PlayerAttribute { Id = 2265, PlayerId = 318, AttributeType = "Return", Value = 13 },

// USA Liv Hovde (USA)
new PlayerAttribute { Id = 2266, PlayerId = 319, AttributeType = "Backhand", Value = 36 },
new PlayerAttribute { Id = 2267, PlayerId = 319, AttributeType = "Forehand", Value = 46 },
new PlayerAttribute { Id = 2268, PlayerId = 319, AttributeType = "Speed", Value = 35 },
new PlayerAttribute { Id = 2269, PlayerId = 319, AttributeType = "Stamina", Value = 44 },
new PlayerAttribute { Id = 2270, PlayerId = 319, AttributeType = "Mental", Value = 14 },
new PlayerAttribute { Id = 2271, PlayerId = 319, AttributeType = "Volley", Value = 14 },
new PlayerAttribute { Id = 2272, PlayerId = 319, AttributeType = "Return", Value = 14 },

// Serbia Katarina Kozarov (SRB)
new PlayerAttribute { Id = 2273, PlayerId = 320, AttributeType = "Backhand", Value = 15 },
new PlayerAttribute { Id = 2274, PlayerId = 320, AttributeType = "Forehand", Value = 15 },
new PlayerAttribute { Id = 2275, PlayerId = 320, AttributeType = "Speed", Value = 15 },
new PlayerAttribute { Id = 2276, PlayerId = 320, AttributeType = "Stamina", Value = 14 },
new PlayerAttribute { Id = 2277, PlayerId = 320, AttributeType = "Mental", Value = 23 },
new PlayerAttribute { Id = 2278, PlayerId = 320, AttributeType = "Volley", Value = 23 },
new PlayerAttribute { Id = 2279, PlayerId = 320, AttributeType = "Return", Value = 13 },

// Republic of Korea Na-Lae Han (KOR)
new PlayerAttribute { Id = 2280, PlayerId = 321, AttributeType = "Backhand", Value = 15 },
new PlayerAttribute { Id = 2281, PlayerId = 321, AttributeType = "Forehand", Value = 15 },
new PlayerAttribute { Id = 2282, PlayerId = 321, AttributeType = "Speed", Value = 14 },
new PlayerAttribute { Id = 2283, PlayerId = 321, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2284, PlayerId = 321, AttributeType = "Mental", Value = 13 },
new PlayerAttribute { Id = 2285, PlayerId = 321, AttributeType = "Volley", Value = 13 },
new PlayerAttribute { Id = 2286, PlayerId = 321, AttributeType = "Return", Value = 13 },

// France Audrey Albie (FRA)
new PlayerAttribute { Id = 2287, PlayerId = 322, AttributeType = "Backhand", Value = 14 },
new PlayerAttribute { Id = 2288, PlayerId = 322, AttributeType = "Forehand", Value = 14 },
new PlayerAttribute { Id = 2289, PlayerId = 322, AttributeType = "Speed", Value = 14 },
new PlayerAttribute { Id = 2290, PlayerId = 322, AttributeType = "Stamina", Value = 3 },
new PlayerAttribute { Id = 2291, PlayerId = 322, AttributeType = "Mental", Value = 13 },
new PlayerAttribute { Id = 2292, PlayerId = 322, AttributeType = "Volley", Value = 23 },
new PlayerAttribute { Id = 2293, PlayerId = 322, AttributeType = "Return", Value = 13 },

// Italy Camilla Rosatello (ITA)
new PlayerAttribute { Id = 2294, PlayerId = 323, AttributeType = "Backhand", Value = 15 },
new PlayerAttribute { Id = 2295, PlayerId = 323, AttributeType = "Forehand", Value = 15 },
new PlayerAttribute { Id = 2296, PlayerId = 323, AttributeType = "Speed", Value = 14 },
new PlayerAttribute { Id = 2297, PlayerId = 323, AttributeType = "Stamina", Value = 14 },
new PlayerAttribute { Id = 2298, PlayerId = 323, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2299, PlayerId = 323, AttributeType = "Volley", Value = 13 },
new PlayerAttribute { Id = 2300, PlayerId = 323, AttributeType = "Return", Value = 13 },

// Czech Republic Linda Klimovicova (CZE)
new PlayerAttribute { Id = 2301, PlayerId = 324, AttributeType = "Backhand", Value = 25 },
new PlayerAttribute { Id = 2302, PlayerId = 324, AttributeType = "Forehand", Value = 25 },
new PlayerAttribute { Id = 2303, PlayerId = 324, AttributeType = "Speed", Value = 24 },
new PlayerAttribute { Id = 2304, PlayerId = 324, AttributeType = "Stamina", Value = 24 },
new PlayerAttribute { Id = 2305, PlayerId = 324, AttributeType = "Mental", Value = 23 },
new PlayerAttribute { Id = 2306, PlayerId = 324, AttributeType = "Volley", Value = 23 },
new PlayerAttribute { Id = 2307, PlayerId = 324, AttributeType = "Return", Value = 13 },

// Romania Andreea Prisacariu (ROU)
new PlayerAttribute { Id = 2308, PlayerId = 325, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2309, PlayerId = 325, AttributeType = "Forehand", Value = 15 },
new PlayerAttribute { Id = 2310, PlayerId = 325, AttributeType = "Speed", Value = 14 },
new PlayerAttribute { Id = 2311, PlayerId = 325, AttributeType = "Stamina", Value = 14 },
new PlayerAttribute { Id = 2312, PlayerId = 325, AttributeType = "Mental", Value = 13 },
new PlayerAttribute { Id = 2313, PlayerId = 325, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2314, PlayerId = 325, AttributeType = "Return", Value = 13 },

// Belarus Kristina Dmitruk (BLR)
new PlayerAttribute { Id = 2315, PlayerId = 326, AttributeType = "Backhand", Value = 35 },
new PlayerAttribute { Id = 2316, PlayerId = 326, AttributeType = "Forehand", Value = 45 },
new PlayerAttribute { Id = 2317, PlayerId = 326, AttributeType = "Speed", Value = 24 },
new PlayerAttribute { Id = 2318, PlayerId = 326, AttributeType = "Stamina", Value = 24 },
new PlayerAttribute { Id = 2319, PlayerId = 326, AttributeType = "Mental", Value = 13 },
new PlayerAttribute { Id = 2320, PlayerId = 326, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2321, PlayerId = 326, AttributeType = "Return", Value = 3 },

// Russia Polina Iatcenko (RUS)
new PlayerAttribute { Id = 2322, PlayerId = 327, AttributeType = "Backhand", Value = 25 },
new PlayerAttribute { Id = 2323, PlayerId = 327, AttributeType = "Forehand", Value = 25 },
new PlayerAttribute { Id = 2324, PlayerId = 327, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2325, PlayerId = 327, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2326, PlayerId = 327, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2327, PlayerId = 327, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2328, PlayerId = 327, AttributeType = "Return", Value = 3 },

// Russia Alina Charaeva (RUS)
new PlayerAttribute { Id = 2329, PlayerId = 328, AttributeType = "Backhand", Value = 35 },
new PlayerAttribute { Id = 2330, PlayerId = 328, AttributeType = "Forehand", Value = 45 },
new PlayerAttribute { Id = 2331, PlayerId = 328, AttributeType = "Speed", Value = 34 },
new PlayerAttribute { Id = 2332, PlayerId = 328, AttributeType = "Stamina", Value = 24 },
new PlayerAttribute { Id = 2333, PlayerId = 328, AttributeType = "Mental", Value = 33 },
new PlayerAttribute { Id = 2334, PlayerId = 328, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2335, PlayerId = 328, AttributeType = "Return", Value = 3 },

// India Karman Kaur Thandi (IND)
new PlayerAttribute { Id = 2336, PlayerId = 329, AttributeType = "Backhand", Value = 15 },
new PlayerAttribute { Id = 2337, PlayerId = 329, AttributeType = "Forehand", Value = 15 },
new PlayerAttribute { Id = 2338, PlayerId = 329, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2339, PlayerId = 329, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2340, PlayerId = 329, AttributeType = "Mental", Value = 13 },
new PlayerAttribute { Id = 2341, PlayerId = 329, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2342, PlayerId = 329, AttributeType = "Return", Value = 3 },

// Burundi Sada Nahimana (BDI)
new PlayerAttribute { Id = 2343, PlayerId = 330, AttributeType = "Backhand", Value = 24 },
new PlayerAttribute { Id = 2344, PlayerId = 330, AttributeType = "Forehand", Value = 14 },
new PlayerAttribute { Id = 2345, PlayerId = 330, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2346, PlayerId = 330, AttributeType = "Stamina", Value = 3 },
new PlayerAttribute { Id = 2347, PlayerId = 330, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2348, PlayerId = 330, AttributeType = "Volley", Value = 13 },
new PlayerAttribute { Id = 2349, PlayerId = 330, AttributeType = "Return", Value = 3 },

// Georgia Ekaterine Gorgodze (GEO)
new PlayerAttribute { Id = 2350, PlayerId = 331, AttributeType = "Backhand", Value = 15 },
new PlayerAttribute { Id = 2351, PlayerId = 331, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2352, PlayerId = 331, AttributeType = "Speed", Value = 24 },
new PlayerAttribute { Id = 2353, PlayerId = 331, AttributeType = "Stamina", Value = 14 },
new PlayerAttribute { Id = 2354, PlayerId = 331, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2355, PlayerId = 331, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2356, PlayerId = 331, AttributeType = "Return", Value = 3 },

// USA Raveena Kingsley (USA)
new PlayerAttribute { Id = 2357, PlayerId = 332, AttributeType = "Backhand", Value = 25 },
new PlayerAttribute { Id = 2358, PlayerId = 332, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2359, PlayerId = 332, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2360, PlayerId = 332, AttributeType = "Stamina", Value = 3 },
new PlayerAttribute { Id = 2361, PlayerId = 332, AttributeType = "Mental", Value = 23 },
new PlayerAttribute { Id = 2362, PlayerId = 332, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2363, PlayerId = 332, AttributeType = "Return", Value = 3 },

// Canada Victoria Mboko (CAN)
new PlayerAttribute { Id = 2364, PlayerId = 333, AttributeType = "Backhand", Value = 25 },
new PlayerAttribute { Id = 2365, PlayerId = 333, AttributeType = "Forehand", Value = 25 },
new PlayerAttribute { Id = 2366, PlayerId = 333, AttributeType = "Speed", Value = 24 },
new PlayerAttribute { Id = 2367, PlayerId = 333, AttributeType = "Stamina", Value = 24 },
new PlayerAttribute { Id = 2368, PlayerId = 333, AttributeType = "Mental", Value = 23 },
new PlayerAttribute { Id = 2369, PlayerId = 333, AttributeType = "Volley", Value = 23 },
new PlayerAttribute { Id = 2370, PlayerId = 333, AttributeType = "Return", Value = 23 },

// Ukraine Anastasiia Sobolieva (UKR)
new PlayerAttribute { Id = 2371, PlayerId = 334, AttributeType = "Backhand", Value = 25 },
new PlayerAttribute { Id = 2372, PlayerId = 334, AttributeType = "Forehand", Value = 35 },
new PlayerAttribute { Id = 2373, PlayerId = 334, AttributeType = "Speed", Value = 24 },
new PlayerAttribute { Id = 2374, PlayerId = 334, AttributeType = "Stamina", Value = 14 },
new PlayerAttribute { Id = 2375, PlayerId = 334, AttributeType = "Mental", Value = 32 },
new PlayerAttribute { Id = 2376, PlayerId = 334, AttributeType = "Volley", Value = 23 },
new PlayerAttribute { Id = 2377, PlayerId = 334, AttributeType = "Return", Value = 23 },

// Serbia Mia Ristic (SRB)
new PlayerAttribute { Id = 2378, PlayerId = 335, AttributeType = "Backhand", Value = 15 },
new PlayerAttribute { Id = 2379, PlayerId = 335, AttributeType = "Forehand", Value = 15 },
new PlayerAttribute { Id = 2380, PlayerId = 335, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2381, PlayerId = 335, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2382, PlayerId = 335, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2383, PlayerId = 335, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2384, PlayerId = 335, AttributeType = "Return", Value = 3 },

// Japan Kyoka Okamura (JPN)
new PlayerAttribute { Id = 2385, PlayerId = 336, AttributeType = "Backhand", Value = 25 },
new PlayerAttribute { Id = 2386, PlayerId = 336, AttributeType = "Forehand", Value = 25 },
new PlayerAttribute { Id = 2387, PlayerId = 336, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2388, PlayerId = 336, AttributeType = "Stamina", Value = 14 },
new PlayerAttribute { Id = 2389, PlayerId = 336, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2390, PlayerId = 336, AttributeType = "Volley", Value = 13 },
new PlayerAttribute { Id = 2391, PlayerId = 336, AttributeType = "Return", Value = 3 },

// Switzerland Susan Bandecchi (CHE)
new PlayerAttribute { Id = 2392, PlayerId = 337, AttributeType = "Backhand", Value = 15 },
new PlayerAttribute { Id = 2393, PlayerId = 337, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2394, PlayerId = 337, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2395, PlayerId = 337, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2396, PlayerId = 337, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2397, PlayerId = 337, AttributeType = "Volley", Value = 13 },
new PlayerAttribute { Id = 2398, PlayerId = 337, AttributeType = "Return", Value = 13 },

// India Rutuja Bhosale (IND)
new PlayerAttribute { Id = 2399, PlayerId = 338, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2400, PlayerId = 338, AttributeType = "Forehand", Value = 15 },
new PlayerAttribute { Id = 2401, PlayerId = 338, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2402, PlayerId = 338, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2403, PlayerId = 338, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2404, PlayerId = 338, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2405, PlayerId = 338, AttributeType = "Return", Value = 3 },

// USA Victoria Hu (USA)
new PlayerAttribute { Id = 2406, PlayerId = 339, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2407, PlayerId = 339, AttributeType = "Forehand", Value = 15 },
new PlayerAttribute { Id = 2408, PlayerId = 339, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2409, PlayerId = 339, AttributeType = "Stamina", Value = 13 },
new PlayerAttribute { Id = 2410, PlayerId = 339, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2411, PlayerId = 339, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2412, PlayerId = 339, AttributeType = "Return", Value = 3 },

// Italy Dalila Spiteri (ITA)
new PlayerAttribute { Id = 2413, PlayerId = 340, AttributeType = "Backhand", Value = 15 },
new PlayerAttribute { Id = 2414, PlayerId = 340, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2415, PlayerId = 340, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2416, PlayerId = 340, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2417, PlayerId = 340, AttributeType = "Mental", Value = 31 },
new PlayerAttribute { Id = 2418, PlayerId = 340, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2419, PlayerId = 340, AttributeType = "Return", Value = 3 },

// Italy Lisa Pigato (ITA)
new PlayerAttribute { Id = 2420, PlayerId = 341, AttributeType = "Backhand", Value = 25 },
new PlayerAttribute { Id = 2421, PlayerId = 341, AttributeType = "Forehand", Value = 15 },
new PlayerAttribute { Id = 2422, PlayerId = 341, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2423, PlayerId = 341, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2424, PlayerId = 341, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2425, PlayerId = 341, AttributeType = "Volley", Value = 23 },
new PlayerAttribute { Id = 2426, PlayerId = 341, AttributeType = "Return", Value = 3 },

// Russia Elena Pridankina (RUS)
new PlayerAttribute { Id = 2427, PlayerId = 342, AttributeType = "Backhand", Value = 35 },
new PlayerAttribute { Id = 2428, PlayerId = 342, AttributeType = "Forehand", Value = 35 },
new PlayerAttribute { Id = 2429, PlayerId = 342, AttributeType = "Speed", Value = 34 },
new PlayerAttribute { Id = 2430, PlayerId = 342, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2431, PlayerId = 342, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2432, PlayerId = 342, AttributeType = "Volley", Value = 43 },
new PlayerAttribute { Id = 2433, PlayerId = 342, AttributeType = "Return", Value = 3 },

// Hungary Reka-Luca Jani (HUN)
new PlayerAttribute { Id = 2434, PlayerId = 343, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2435, PlayerId = 343, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2436, PlayerId = 343, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2437, PlayerId = 343, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2438, PlayerId = 343, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2439, PlayerId = 343, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2440, PlayerId = 343, AttributeType = "Return", Value = 3 },

// Belgium Alison Van Uytvanck (BEL)
new PlayerAttribute { Id = 2441, PlayerId = 344, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2442, PlayerId = 344, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2443, PlayerId = 344, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2444, PlayerId = 344, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2445, PlayerId = 344, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2446, PlayerId = 344, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2447, PlayerId = 344, AttributeType = "Return", Value = 3 },

// USA Madison Sieg (USA)
new PlayerAttribute { Id = 2448, PlayerId = 345, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2449, PlayerId = 345, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2450, PlayerId = 345, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2451, PlayerId = 345, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2452, PlayerId = 345, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2453, PlayerId = 345, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2454, PlayerId = 345, AttributeType = "Return", Value = 3 },

// Latvia Diana Marcinkevica (LVA)
new PlayerAttribute { Id = 2455, PlayerId = 346, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2456, PlayerId = 346, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2457, PlayerId = 346, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2458, PlayerId = 346, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2459, PlayerId = 346, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2460, PlayerId = 346, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2461, PlayerId = 346, AttributeType = "Return", Value = 3 },

// Czech Republic Barbora Palicova (CZE)
new PlayerAttribute { Id = 2462, PlayerId = 347, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2463, PlayerId = 347, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2464, PlayerId = 347, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2465, PlayerId = 347, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2466, PlayerId = 347, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2467, PlayerId = 347, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2468, PlayerId = 347, AttributeType = "Return", Value = 3 },

// Mexico Fernanda Contreras Gomez (MEX)
new PlayerAttribute { Id = 2469, PlayerId = 348, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2470, PlayerId = 348, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2471, PlayerId = 348, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2472, PlayerId = 348, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2473, PlayerId = 348, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2474, PlayerId = 348, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2475, PlayerId = 348, AttributeType = "Return", Value = 3 },

// Belgium Magali Kempen (BEL)
new PlayerAttribute { Id = 2476, PlayerId = 349, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2477, PlayerId = 349, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2478, PlayerId = 349, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2479, PlayerId = 349, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2480, PlayerId = 349, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2481, PlayerId = 349, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2482, PlayerId = 349, AttributeType = "Return", Value = 3 },

// Switzerland Conny Perrin (CHE)
new PlayerAttribute { Id = 2483, PlayerId = 350, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2484, PlayerId = 350, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2485, PlayerId = 350, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2486, PlayerId = 350, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2487, PlayerId = 350, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2488, PlayerId = 350, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2489, PlayerId = 350, AttributeType = "Return", Value = 3 },

// Russia Daria Lodikova (RUS)
new PlayerAttribute { Id = 2490, PlayerId = 351, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2491, PlayerId = 351, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2492, PlayerId = 351, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2493, PlayerId = 351, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2494, PlayerId = 351, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2495, PlayerId = 351, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2496, PlayerId = 351, AttributeType = "Return", Value = 3 },

// Estonia Elena Malygina (EST)
new PlayerAttribute { Id = 2497, PlayerId = 352, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2498, PlayerId = 352, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2499, PlayerId = 352, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2500, PlayerId = 352, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2501, PlayerId = 352, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2502, PlayerId = 352, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2503, PlayerId = 352, AttributeType = "Return", Value = 3 },

// Czech Republic Anna Siskova (CZE)
new PlayerAttribute { Id = 2504, PlayerId = 353, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2505, PlayerId = 353, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2506, PlayerId = 353, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2507, PlayerId = 353, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2508, PlayerId = 353, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2509, PlayerId = 353, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2510, PlayerId = 353, AttributeType = "Return", Value = 3 },

// China Jia-Jing Lu (CHN)
new PlayerAttribute { Id = 2511, PlayerId = 354, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2512, PlayerId = 354, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2513, PlayerId = 354, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2514, PlayerId = 354, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2515, PlayerId = 354, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2516, PlayerId = 354, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2517, PlayerId = 354, AttributeType = "Return", Value = 3 },

// Israel Lina Glushko (ISR)
new PlayerAttribute { Id = 2518, PlayerId = 355, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2519, PlayerId = 355, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2520, PlayerId = 355, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2521, PlayerId = 355, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2522, PlayerId = 355, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2523, PlayerId = 355, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2524, PlayerId = 355, AttributeType = "Return", Value = 3 },

// USA Allie Kiick (USA)
new PlayerAttribute { Id = 2525, PlayerId = 356, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2526, PlayerId = 356, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2527, PlayerId = 356, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2528, PlayerId = 356, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2529, PlayerId = 356, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2530, PlayerId = 356, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2531, PlayerId = 356, AttributeType = "Return", Value = 3 },

// Holland Eva Vedder (NLD)
new PlayerAttribute { Id = 2532, PlayerId = 357, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2533, PlayerId = 357, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2534, PlayerId = 357, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2535, PlayerId = 357, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2536, PlayerId = 357, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2537, PlayerId = 357, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2538, PlayerId = 357, AttributeType = "Return", Value = 3 },

// Japan Sara Saito (JPN)
new PlayerAttribute { Id = 2539, PlayerId = 358, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2540, PlayerId = 358, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2541, PlayerId = 358, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2542, PlayerId = 358, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2543, PlayerId = 358, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2544, PlayerId = 358, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2545, PlayerId = 358, AttributeType = "Return", Value = 3 },

// Poland Maja Chwalinska (POL)
new PlayerAttribute { Id = 2546, PlayerId = 359, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2547, PlayerId = 359, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2548, PlayerId = 359, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2549, PlayerId = 359, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2550, PlayerId = 359, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2551, PlayerId = 359, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2552, PlayerId = 359, AttributeType = "Return", Value = 3 },

// Germany Katharina Hobgarski (DEU)
new PlayerAttribute { Id = 2553, PlayerId = 360, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2554, PlayerId = 360, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2555, PlayerId = 360, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2556, PlayerId = 360, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2557, PlayerId = 360, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2558, PlayerId = 360, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2559, PlayerId = 360, AttributeType = "Return", Value = 3 },

// Turkey Ayla Aksu (TUR)
new PlayerAttribute { Id = 2560, PlayerId = 361, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2561, PlayerId = 361, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2562, PlayerId = 361, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2563, PlayerId = 361, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2564, PlayerId = 361, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2565, PlayerId = 361, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2566, PlayerId = 361, AttributeType = "Return", Value = 3 },

// Romania Ilinca Dalina Amariei (ROU)
new PlayerAttribute { Id = 2567, PlayerId = 362, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2568, PlayerId = 362, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2569, PlayerId = 362, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2570, PlayerId = 362, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2571, PlayerId = 362, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2572, PlayerId = 362, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2573, PlayerId = 362, AttributeType = "Return", Value = 3 },

// Poland Martyna Kubka (POL)
new PlayerAttribute { Id = 2574, PlayerId = 363, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2575, PlayerId = 363, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2576, PlayerId = 363, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2577, PlayerId = 363, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2578, PlayerId = 363, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2579, PlayerId = 363, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2580, PlayerId = 363, AttributeType = "Return", Value = 3 },

// Bosnia and Herzegovina Nefisa Berberovic (BIH)
new PlayerAttribute { Id = 2581, PlayerId = 364, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2582, PlayerId = 364, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2583, PlayerId = 364, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2584, PlayerId = 364, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2585, PlayerId = 364, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2586, PlayerId = 364, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2587, PlayerId = 364, AttributeType = "Return", Value = 3 },

// USA Asia Muhammad (USA)
new PlayerAttribute { Id = 2588, PlayerId = 365, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2589, PlayerId = 365, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2590, PlayerId = 365, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2591, PlayerId = 365, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2592, PlayerId = 365, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2593, PlayerId = 365, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2594, PlayerId = 365, AttributeType = "Return", Value = 3 },

// Russia Ksenia Zaytseva (RUS)
new PlayerAttribute { Id = 2595, PlayerId = 366, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2596, PlayerId = 366, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2597, PlayerId = 366, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2598, PlayerId = 366, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2599, PlayerId = 366, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2600, PlayerId = 366, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2601, PlayerId = 366, AttributeType = "Return", Value = 3 },

// United Kingdom Katy Dunne (GBR)
new PlayerAttribute { Id = 2602, PlayerId = 367, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2603, PlayerId = 367, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2604, PlayerId = 367, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2605, PlayerId = 367, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2606, PlayerId = 367, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2607, PlayerId = 367, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2608, PlayerId = 367, AttributeType = "Return", Value = 3 },

// United Kingdom Eden Silva (GBR)
new PlayerAttribute { Id = 2609, PlayerId = 368, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2610, PlayerId = 368, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2611, PlayerId = 368, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2612, PlayerId = 368, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2613, PlayerId = 368, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2614, PlayerId = 368, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2615, PlayerId = 368, AttributeType = "Return", Value = 3 },

// USA Amanda Anisimova (USA)
new PlayerAttribute { Id = 2616, PlayerId = 369, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2617, PlayerId = 369, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2618, PlayerId = 369, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2619, PlayerId = 369, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2620, PlayerId = 369, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2621, PlayerId = 369, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2622, PlayerId = 369, AttributeType = "Return", Value = 3 },

// USA Sophie Chang (USA)
new PlayerAttribute { Id = 2623, PlayerId = 370, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2624, PlayerId = 370, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2625, PlayerId = 370, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2626, PlayerId = 370, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2627, PlayerId = 370, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2628, PlayerId = 370, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2629, PlayerId = 370, AttributeType = "Return", Value = 3 },

// Spain Georgina Garcia-Perez (ESP)
new PlayerAttribute { Id = 2630, PlayerId = 371, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2631, PlayerId = 371, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2632, PlayerId = 371, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2633, PlayerId = 371, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2634, PlayerId = 371, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2635, PlayerId = 371, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2636, PlayerId = 371, AttributeType = "Return", Value = 3 },

// United Kingdom Anna Brogan (GBR)
new PlayerAttribute { Id = 2637, PlayerId = 372, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2638, PlayerId = 372, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2639, PlayerId = 372, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2640, PlayerId = 372, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2641, PlayerId = 372, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2642, PlayerId = 372, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2643, PlayerId = 372, AttributeType = "Return", Value = 3 },

// Mexico Victoria Rodriguez (MEX)
new PlayerAttribute { Id = 2644, PlayerId = 373, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2645, PlayerId = 373, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2646, PlayerId = 373, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2647, PlayerId = 373, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2648, PlayerId = 373, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2649, PlayerId = 373, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2650, PlayerId = 373, AttributeType = "Return", Value = 3 },

// Japan Natsumi Kawaguchi (JPN)
new PlayerAttribute { Id = 2651, PlayerId = 374, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2652, PlayerId = 374, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2653, PlayerId = 374, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2654, PlayerId = 374, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2655, PlayerId = 374, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2656, PlayerId = 374, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2657, PlayerId = 374, AttributeType = "Return", Value = 3 },

// Latvia Daniela Vismane (LVA)
new PlayerAttribute { Id = 2658, PlayerId = 375, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2659, PlayerId = 375, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2660, PlayerId = 375, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2661, PlayerId = 375, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2662, PlayerId = 375, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2663, PlayerId = 375, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2664, PlayerId = 375, AttributeType = "Return", Value = 3 },

// Romania Ylona-Georgiana Ghioroaie (ROU)
new PlayerAttribute { Id = 2665, PlayerId = 376, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2666, PlayerId = 376, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2667, PlayerId = 376, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2668, PlayerId = 376, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2669, PlayerId = 376, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2670, PlayerId = 376, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2671, PlayerId = 376, AttributeType = "Return", Value = 3 },

// Germany Vivian Wolff (DEU)
new PlayerAttribute { Id = 2672, PlayerId = 377, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2673, PlayerId = 377, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2674, PlayerId = 377, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2675, PlayerId = 377, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2676, PlayerId = 377, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2677, PlayerId = 377, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2678, PlayerId = 377, AttributeType = "Return", Value = 3 },

// Italy Martina Colmegna (ITA)
new PlayerAttribute { Id = 2679, PlayerId = 378, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2680, PlayerId = 378, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2681, PlayerId = 378, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2682, PlayerId = 378, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2683, PlayerId = 378, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2684, PlayerId = 378, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2685, PlayerId = 378, AttributeType = "Return", Value = 3 },

// Germany Julia Middendorf (DEU)
new PlayerAttribute { Id = 2686, PlayerId = 379, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2687, PlayerId = 379, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2688, PlayerId = 379, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2689, PlayerId = 379, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2690, PlayerId = 379, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2691, PlayerId = 379, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2692, PlayerId = 379, AttributeType = "Return", Value = 3 },

// France Manon Leonard (FRA)
new PlayerAttribute { Id = 2693, PlayerId = 380, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2694, PlayerId = 380, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2695, PlayerId = 380, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2696, PlayerId = 380, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2697, PlayerId = 380, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2698, PlayerId = 380, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2699, PlayerId = 380, AttributeType = "Return", Value = 3 },

// Japan Rina Saigo (JPN)
new PlayerAttribute { Id = 2700, PlayerId = 381, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2701, PlayerId = 381, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2702, PlayerId = 381, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2703, PlayerId = 381, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2704, PlayerId = 381, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2705, PlayerId = 381, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2706, PlayerId = 381, AttributeType = "Return", Value = 3 },

// Turkey Cagla Buyukakcay (TUR)
new PlayerAttribute { Id = 2707, PlayerId = 382, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2708, PlayerId = 382, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2709, PlayerId = 382, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2710, PlayerId = 382, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2711, PlayerId = 382, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2712, PlayerId = 382, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2713, PlayerId = 382, AttributeType = "Return", Value = 3 },

// Japan Aoi Ito (JPN)
new PlayerAttribute { Id = 2714, PlayerId = 383, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2715, PlayerId = 383, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2716, PlayerId = 383, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2717, PlayerId = 383, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2718, PlayerId = 383, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2719, PlayerId = 383, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2720, PlayerId = 383, AttributeType = "Return", Value = 3 },

// Brazil Gabriela Ce (BRA)
new PlayerAttribute { Id = 2721, PlayerId = 384, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2722, PlayerId = 384, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2723, PlayerId = 384, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2724, PlayerId = 384, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2725, PlayerId = 384, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2726, PlayerId = 384, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2727, PlayerId = 384, AttributeType = "Return", Value = 3 },

// Argentina Guillermina Naya (ARG)
new PlayerAttribute { Id = 2728, PlayerId = 385, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2729, PlayerId = 385, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2730, PlayerId = 385, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2731, PlayerId = 385, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2732, PlayerId = 385, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2733, PlayerId = 385, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2734, PlayerId = 385, AttributeType = "Return", Value = 3 },

// Spain Lucia Cortez Llorca (ESP)
new PlayerAttribute { Id = 2735, PlayerId = 386, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2736, PlayerId = 386, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2737, PlayerId = 386, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2738, PlayerId = 386, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2739, PlayerId = 386, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2740, PlayerId = 386, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2741, PlayerId = 386, AttributeType = "Return", Value = 3 },

// China Zongyu Li (CHN)
new PlayerAttribute { Id = 2742, PlayerId = 387, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2743, PlayerId = 387, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2744, PlayerId = 387, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2745, PlayerId = 387, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2746, PlayerId = 387, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2747, PlayerId = 387, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2748, PlayerId = 387, AttributeType = "Return", Value = 3 },

// Austria Tamira Paszek (AUT)
new PlayerAttribute { Id = 2749, PlayerId = 388, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2750, PlayerId = 388, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2751, PlayerId = 388, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2752, PlayerId = 388, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2753, PlayerId = 388, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2754, PlayerId = 388, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2755, PlayerId = 388, AttributeType = "Return", Value = 3 },

// USA Chloe Beck (USA)
new PlayerAttribute { Id = 2756, PlayerId = 389, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2757, PlayerId = 389, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2758, PlayerId = 389, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2759, PlayerId = 389, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2760, PlayerId = 389, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2761, PlayerId = 389, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2762, PlayerId = 389, AttributeType = "Return", Value = 3 },

// USA Jessie Aney (USA)
new PlayerAttribute { Id = 2763, PlayerId = 390, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2764, PlayerId = 390, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2765, PlayerId = 390, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2766, PlayerId = 390, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2767, PlayerId = 390, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2768, PlayerId = 390, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2769, PlayerId = 390, AttributeType = "Return", Value = 3 },

// Croatia Oleksandra Oliynykova (HRV)
new PlayerAttribute { Id = 2770, PlayerId = 391, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2771, PlayerId = 391, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2772, PlayerId = 391, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2773, PlayerId = 391, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2774, PlayerId = 391, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2775, PlayerId = 391, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2776, PlayerId = 391, AttributeType = "Return", Value = 3 },

// Spain Eva Guerrero Alvarez (ESP)
new PlayerAttribute { Id = 2777, PlayerId = 392, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2778, PlayerId = 392, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2779, PlayerId = 392, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2780, PlayerId = 392, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2781, PlayerId = 392, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2782, PlayerId = 392, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2783, PlayerId = 392, AttributeType = "Return", Value = 3 },

// Romania Gabriela Lee (ROU)
new PlayerAttribute { Id = 2784, PlayerId = 393, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2785, PlayerId = 393, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2786, PlayerId = 393, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2787, PlayerId = 393, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2788, PlayerId = 393, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2789, PlayerId = 393, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2790, PlayerId = 393, AttributeType = "Return", Value = 3 },

// USA Robin Anderson (USA)
new PlayerAttribute { Id = 2791, PlayerId = 394, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2792, PlayerId = 394, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2793, PlayerId = 394, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2794, PlayerId = 394, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2795, PlayerId = 394, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2796, PlayerId = 394, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2797, PlayerId = 394, AttributeType = "Return", Value = 3 },

// Mexico Marcela Zacarias (MEX)
new PlayerAttribute { Id = 2798, PlayerId = 395, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2799, PlayerId = 395, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2800, PlayerId = 395, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2801, PlayerId = 395, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2802, PlayerId = 395, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2803, PlayerId = 395, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2804, PlayerId = 395, AttributeType = "Return", Value = 3 },

// Poland Weronika Falkowska (POL)
new PlayerAttribute { Id = 2805, PlayerId = 396, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2806, PlayerId = 396, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2807, PlayerId = 396, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2808, PlayerId = 396, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2809, PlayerId = 396, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2810, PlayerId = 396, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2811, PlayerId = 396, AttributeType = "Return", Value = 3 },

// USA Ashley Lahey (USA)
new PlayerAttribute { Id = 2812, PlayerId = 397, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2813, PlayerId = 397, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2814, PlayerId = 397, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2815, PlayerId = 397, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2816, PlayerId = 397, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2817, PlayerId = 397, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2818, PlayerId = 397, AttributeType = "Return", Value = 3 },

// USA Whitney Osuigwe (USA)
new PlayerAttribute { Id = 2819, PlayerId = 398, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2820, PlayerId = 398, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2821, PlayerId = 398, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2822, PlayerId = 398, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2823, PlayerId = 398, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2824, PlayerId = 398, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2825, PlayerId = 398, AttributeType = "Return", Value = 3 },

// France Emma Lene (FRA)
new PlayerAttribute { Id = 2826, PlayerId = 399, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2827, PlayerId = 399, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2828, PlayerId = 399, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2829, PlayerId = 399, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2830, PlayerId = 399, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2831, PlayerId = 399, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2832, PlayerId = 399, AttributeType = "Return", Value = 3 },

// Slovenia Nika Radisic (SVN)
new PlayerAttribute { Id = 2833, PlayerId = 400, AttributeType = "Backhand", Value = 5 },
new PlayerAttribute { Id = 2834, PlayerId = 400, AttributeType = "Forehand", Value = 5 },
new PlayerAttribute { Id = 2835, PlayerId = 400, AttributeType = "Speed", Value = 4 },
new PlayerAttribute { Id = 2836, PlayerId = 400, AttributeType = "Stamina", Value = 4 },
new PlayerAttribute { Id = 2837, PlayerId = 400, AttributeType = "Mental", Value = 3 },
new PlayerAttribute { Id = 2838, PlayerId = 400, AttributeType = "Volley", Value = 3 },
new PlayerAttribute { Id = 2839, PlayerId = 400, AttributeType = "Return", Value = 3 }



            );
        }
    }
}
