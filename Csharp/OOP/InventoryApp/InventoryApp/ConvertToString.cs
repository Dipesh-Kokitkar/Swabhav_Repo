using System;

namespace InventoryApp
{
    public class ConvertToString
    {
        public string BuilderToString(Builder builder) {
            switch (builder) {
                case Builder.ANY:
                    return "Any";
                case Builder.COLLINGS:
                    return "Collings";
                case Builder.FENDER:
                    return "Fender";
                case Builder.GIBSON:
                    return "Gibson";
                case Builder.MARTIN:
                    return "Martin";
                case Builder.OLSON:
                    return "Olson";
                case Builder.PRS:
                    return "PRS";
                case Builder.RYAN:
                    return "Ryan";
            }
            return null;
        }

        public string WoodToString(Wood wood) {
            switch (wood) {
                case Wood.ADIRONDACK:
                    return "Adirondack";
                case Wood.ALDER:
                    return "Alder";
                case Wood.BRAZILIAN_ROSEWOOD:
                    return "Brazilian Rosewood";
                case Wood.CEDAR:
                    return "Cedar";
                case Wood.COCOBOLA:
                    return "Cocobola";
                case Wood.INDIAN_ROSEWOOD:
                    return "Indian Rosewood";
                case Wood.MAHOGANY:
                    return "Mahogany";
                case Wood.MAPLE:
                    return "Maple";
                case Wood.SITKA:
                    return "Sitka";
            }
            return null;
        }

        public string TypeToString(Type type) {
            switch (type) {
                case Type.ACOUSTIC:
                    return "Acoustic";
                case Type.ELECTRIC:
                    return "Electric";
            }
            return null;
        }
    }
}
