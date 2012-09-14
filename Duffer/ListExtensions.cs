﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Duffer
{
    static class ListExtensions
    {
        // These are hard to do as extension methods, because the compiler starts complaining
        // And I wanted them to be indepedently unit-testable, so this code is not just
        // dropped into the location where this method gets called

        internal static void ExportParentListToStream(IList<Parent> list, StreamWriter toStream)
        {
            toStream.WriteLine("\tPARENT_LIST {");
            toStream.WriteLine(String.Format("\t\tPARENT_COUNT {0}", list.Count));
            for (int i = 0; i < list.Count; i++)
            {
                //note: double {{ wil output as single { in string.format
                toStream.WriteLine(String.Format("\t\tPARENT {0} {{", i));
                list.ElementAt(i).Export(toStream);
                toStream.WriteLine("\t\t}");
            }

            toStream.WriteLine("\t}");
        }

        /* For "MODEL RESOURCE_LIST*/
        internal static void ExportShadingListToStream(IList<ShadingDescription> list, StreamWriter toStream)
        {
            if (list.Count() == 0) return; //return if list has no items -> this isn't possible -> every model needs shading resource

            toStream.WriteLine("\t\t\tMODEL_SHADING_DESCRIPTION_LIST {");
            for (int i = 0; i < list.Count; i++)
            {
                //note: double {{ wil output as single { in string.format
                toStream.WriteLine(String.Format("\t\t\t\tSHADING_DESCRIPTION {0} {{", i));
                list.ElementAt(i).Export(toStream);
                toStream.WriteLine("\t\t\t\t}");
            }

            toStream.WriteLine("\t\t\t}");
        }
        internal static void ExportTextureCoordListToStream(IList<int> list, StreamWriter toStream)
        {
            if (list.Count() == 0) return;

            toStream.WriteLine("\t\t\t\t\tTEXTURE_COORD_DIMENSION_LIST {");
            for (int i = 0; i < list.Count; i++)
            {
                toStream.WriteLine(String.Format("\t\t\t\t\t\tTEXTURE_LAYER {0}	DIMENSION: {1}", i, list[i]));
            }

            toStream.WriteLine("\t\t\t\t\t}");
        }

        internal static void ExportMeshFaceTextureCoordListToStream(IList<FaceTextureCoord> list, StreamWriter toStream)
        {
            if (list.Count() == 0) return;

            toStream.WriteLine(String.Format("\t\t\tMESH_FACE_TEXTURE_COORD_LIST {{"));
            
            for (int i = 0; i < list.Count(); i++)
            {
                toStream.WriteLine(String.Format("\t\t\t\tFACE {0} {{", i.ToString()));
                ListExtensions.ExportTextureCoordListToStream(list[i].TextureCoordDimensionList, toStream);
                toStream.WriteLine(String.Format("\t\t\t\t}}", i.ToString()));
            }
            toStream.WriteLine(String.Format("\t\t\t}}"));
        }
        internal static void ExportTextureCoordListToStream(IList<Int3> list, StreamWriter toStream)
        {
            for (int i = 0; i < list.Count; i++)
            {
                toStream.WriteLine(String.Format("\t\t\t\t\tTEXTURE_LAYER {0} TEX_COORD: {1}", i, list[i].ToString()));
            }
        }

        internal static void ExportInt3ListToStream(IList<Int3> list, StreamWriter toStream, string listName)
        {
            if (list.Count() == 0) return; //return if list has no items

            toStream.WriteLine(String.Format("\t\t\t{0} {{", listName));
            for (int i = 0; i < list.Count; i++)
            {
                toStream.WriteLine(String.Format("\t\t\t\t{0}", list[i].ToString()));
            }
            toStream.WriteLine("\t\t\t}");
        }
        internal static void ExportIntListToStream(IList<int> list, StreamWriter toStream, string listName)
        {
            if (list.Count() == 0) return; //return if list has no items

            toStream.WriteLine(String.Format("\t\t\t{0} {{", listName));
            for (int i = 0; i < list.Count; i++)
            {
                //note: double {{ wil output as single { in string.format
                toStream.WriteLine(String.Format("\t\t\t\t{0}", list[i].ToString()));
            }

            toStream.WriteLine("\t\t\t}");

        }
        internal static void ExportPoint3ListToStream(IList<Point3> list, StreamWriter toStream, string listName)
        {
            if (list.Count() == 0) return; //return if list has no items

            toStream.WriteLine(String.Format("\t\t\t{0} {{", listName));
            for (int i = 0; i < list.Count; i++)
            {
                //note: double {{ wil output as single { in string.format
                toStream.WriteLine(String.Format("\t\t\t\t{0}", list[i].ToString()));
            }

            toStream.WriteLine("\t\t\t}");

        }
        internal static void ExportVector4ListToStream(IList<Vector4> list, StreamWriter toStream, string listName)
        {
            if (list.Count() == 0) return; //return if list has no items

            toStream.WriteLine(String.Format("\t\t\t{0} {{", listName));
            for (int i = 0; i < list.Count; i++)
            {
                //note: double {{ wil output as single { in string.format
                toStream.WriteLine(String.Format("\t\t\t\t{0}", list[i].ToString()));
            }

            toStream.WriteLine("\t\t\t}");

        }
        internal static void ExportColor4ListToStream(IList<System.Drawing.Color> list, StreamWriter toStream, string listName)
        {
            if (list.Count() == 0) return; //return if list has no items

            toStream.WriteLine(String.Format("\t\t\t{0} {{", listName));
            for (int i = 0; i < list.Count; i++)
            {
                //note: double {{ wil output as single { in string.format
                toStream.WriteLine(String.Format("\t\t\t\t{0}", list[i].ToIDTFStringRGBA()));
            }

            toStream.WriteLine("\t\t\t}");

        }


        /* For "SHADER RESOURCE_LIST*/
        internal static void ExportShaderTextureLayerListToStream(IList<TextureLayer> list, StreamWriter toStream)
        {
            toStream.WriteLine("\t\tSHADER_ACTIVE_TEXTURE_COUNT {0}", list.Count.ToString());
            if (list.Count() > 0)
            {
                toStream.WriteLine("\t\tSHADER_TEXTURE_LAYER_LIST {");
                for (int i = 0; i < list.Count; i++)
                {
                    toStream.WriteLine("\t\t\tTEXTURE_LAYER {0} {{", i.ToString());
                    list.ElementAt(i).Export(toStream);
                    toStream.WriteLine("\t\t\t}");
                }

                toStream.WriteLine("\t\t}");
            }
        }

        /* For "TEXTURE RESOURCE_LIST*/
        internal static void ExportTextureImageFormatListToStream(IList<TextureImageFormat> list, StreamWriter toStream)
        {
            if (list.Count == 0) return;

            toStream.WriteLine("\t\tTEXTURE_IMAGE_COUNT {0}", list.Count.ToString());
            if (list.Count() > 0)
            {
                toStream.WriteLine("\t\tIMAGE_FORMAT_LIST {");
                for (int i = 0; i < list.Count; i++)
                {
                    toStream.WriteLine("\t\t\tIMAGE_FORMAT {0} {{", i.ToString());
                    list.ElementAt(i).Export(toStream);
                    toStream.WriteLine("\t\t\t}");
                }

                toStream.WriteLine("\t\t}");
            }
        }

        internal static void ExportUrlListToStream(IList<Url> list, StreamWriter toStream)
        {
            if (list.Count == 0) return;

            toStream.WriteLine("\t\t\tURL_COUNT {0}", list.Count.ToString());
            if (list.Count() > 0)
            {
                toStream.WriteLine("\t\t\t\tURL_LIST {");
                for (int i = 0; i < list.Count; i++)
                {
                    toStream.WriteLine("\t\t\t\tURL {0} {1}", i.ToString(), list[i].UrlPath);
                }

                toStream.WriteLine("\t\t\t}");
            }
        }
    }
}
