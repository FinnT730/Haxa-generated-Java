// Generated by Haxe 4.1.0-rc.1+18b5e7d10

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public sealed class FieldHashConflict {
		
		public FieldHashConflict(int hash, string name, object @value, global::haxe.lang.FieldHashConflict next) {
			#line 34 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
			this.hash = hash;
			this.name = name;
			#line 36 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
			this.@value = @value;
			this.next = next;
		}
		#line default
		
		public readonly int hash;
		
		public readonly string name;
		
		public object @value;
		
		public global::haxe.lang.FieldHashConflict next;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public sealed class FieldLookup {
		
		#pragma warning disable 628
		static FieldLookup() {
			#line 50 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
			global::haxe.lang.FieldLookup.length = ( global::haxe.lang.FieldLookup.fieldIds as global::System.Array ).Length;
		}
		#line default
		
		public FieldLookup() {
		}
		
		
		protected static int[] fieldIds = new int[]{4745537, 5442204, 5594513, 57476627, 76061764, 78945784, 87367608, 142301684, 221637784, 302979532, 312752480, 328878574, 359333139, 407283053, 452737314, 501039929, 520590566, 572311959, 630156697, 746281503, 834174833, 863972113, 946786476, 1067353468, 1103412149, 1177754921, 1181037546, 1204816148, 1224901875, 1228056441, 1247875546, 1257164128, 1273207865, 1280845662, 1282943179, 1352786672, 1398464674, 1431819701, 1436822557, 1460447810, 1532710347, 1547539107, 1620824029, 1621420777, 1623148745, 1648581351, 1705629508, 1768617329, 1825849507, 1830310359, 1915412854, 1916009602, 1937159360, 1981972957, 2025055113, 2054707467, 2082663554, 2127021138};
		
		protected static string[] fields = new string[]{"__a", "map", "pop", "getEnumConstructs", "remove", "__previousException", "filter", "resize", "__nativeException", "methodName", "get_native", "iterator", "lastIndexOf", "hasNext", "reverse", "insert", "length", "native", "array", "contains", "value", "__nativeStack", "toString", "splice", "copy", "__skipStack", "join", "concat", "next", "enumConstructor", "push", "keyValueIterator", "current", "sort", "quicksort", "spliceVoid", "getEnumName", "createEnumIndex", "createEnum", "__ownStack", "concatNative", "className", "__unsafe_get", "__unsafe_set", "indexOf", "fileName", "toDynamic", "allEnums", "unwrap", "customParams", "__get", "__set", "__hx_deleteField", "lineNumber", "unshift", "enumParameters", "shift", "slice"};
		
		protected static int length;
		
		public static void addFields(int[] nids, string[] nfields) {
			unchecked {
				#line 55 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				int[] cids = global::haxe.lang.FieldLookup.fieldIds;
				#line 55 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				string[] cfields = global::haxe.lang.FieldLookup.fields;
				int nlen = ( nids as global::System.Array ).Length;
				#line 57 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				int clen = global::haxe.lang.FieldLookup.length;
				if (( ( nfields as global::System.Array ).Length != nlen )) {
					#line 59 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					throw ((global::System.Exception) (global::haxe.Exception.thrown(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Different fields length: ", global::haxe.lang.Runtime.toString(nlen)), " and "), global::haxe.lang.Runtime.toString(( nfields as global::System.Array ).Length)))) );
				}
				
				#line 62 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				bool needsChange = false;
				{
					#line 63 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					int[] _g_arr = nids;
					#line 63 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					uint _g_idx = ((uint) (0) );
					#line 63 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					while (( _g_idx < ( _g_arr as global::System.Array ).Length )) {
						#line 63 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						_g_idx += ((uint) (1) );
						#line 63 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						int i = _g_arr[((int) (((uint) (( _g_idx - 1 )) )) )];
						if (( global::haxe.lang.FieldLookup.findHash(i, cids, clen) < 0 )) {
							#line 65 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
							needsChange = true;
							break;
						}
						
					}
					
				}
				
				#line 71 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				if (needsChange) {
					#line 72 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					lock(typeof(global::haxe.lang.FieldLookup)){
						#line 74 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						int[] ansIds = new int[( clen + nlen )];
						#line 74 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						string[] ansFields = new string[( clen + nlen )];
						#line 76 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						int ci = 0;
						#line 76 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						int ni = 0;
						#line 76 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						int ansi = 0;
						while (true) {
							#line 77 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
							if ( ! ((( (( ci < clen )) ? (( ni < nlen )) : (false) ))) ) {
								#line 77 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
								break;
							}
							
							#line 78 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
							if (( cids[ci] < nids[ni] )) {
								#line 79 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
								ansIds[ansi] = cids[ci];
								ansFields[ansi] = ((string) (cfields[ci]) );
								#line 81 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
								ci = ( ci + 1 );
							}
							else {
								#line 83 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
								ansIds[ansi] = nids[ni];
								ansFields[ansi] = ((string) (nfields[ni]) );
								#line 85 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
								ni = ( ni + 1 );
							}
							
							#line 87 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
							ansi = ( ansi + 1 );
						}
						
						#line 90 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						if (( ci < clen )) {
							#line 91 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
							global::System.Array.Copy(((global::System.Array) (cids) ), ((int) (ci) ), ((global::System.Array) (ansIds) ), ((int) (ansi) ), ((int) (( clen - ci )) ));
							global::System.Array.Copy(((global::System.Array) (cfields) ), ((int) (ci) ), ((global::System.Array) (ansFields) ), ((int) (ansi) ), ((int) (( clen - ci )) ));
							#line 93 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
							ansi = ( ansi + (( clen - ci )) );
						}
						
						#line 96 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						if (( ni < nlen )) {
							#line 97 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
							global::System.Array.Copy(((global::System.Array) (nids) ), ((int) (ni) ), ((global::System.Array) (ansIds) ), ((int) (ansi) ), ((int) (( nlen - ni )) ));
							global::System.Array.Copy(((global::System.Array) (nfields) ), ((int) (ni) ), ((global::System.Array) (ansFields) ), ((int) (ansi) ), ((int) (( nlen - ni )) ));
							#line 99 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
							ansi = ( ansi + (( nlen - ni )) );
						}
						
						#line 103 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						global::haxe.lang.FieldLookup.fieldIds = ansIds;
						global::haxe.lang.FieldLookup.fields = ansFields;
						#line 105 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						global::haxe.lang.FieldLookup.length = ansi;
					}
					;
				}
				
			}
			#line default
		}
		
		
		public static int doHash(string s) {
			unchecked {
				#line 112 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				int acc = 0;
				{
					#line 113 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					int _g = 0;
					#line 113 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					int _g1 = s.Length;
					#line 113 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					while (( _g < _g1 )) {
						#line 113 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						int i = _g++;
						acc = ( ( ( 223 * (( acc >> 1 )) ) + ((int) (s[i]) ) ) << 1 );
					}
					
				}
				
				#line 117 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				return ((int) (( ((uint) (acc) ) >> 1 )) );
			}
			#line default
		}
		
		
		public static string lookupHash(int key) {
			unchecked {
				#line 121 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				int[] ids = global::haxe.lang.FieldLookup.fieldIds;
				int min = 0;
				#line 123 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				int max = global::haxe.lang.FieldLookup.length;
				#line 125 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				while (( min < max )) {
					#line 126 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					int mid = ( min + ( (( max - min )) / 2 ) );
					int imid = ids[mid];
					#line 128 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					if (( key < imid )) {
						#line 129 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						max = mid;
					}
					else if (( key > imid )) {
						#line 131 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						min = ( mid + 1 );
					}
					else {
						#line 133 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						return ((string) (global::haxe.lang.FieldLookup.fields[mid]) );
					}
					
				}
				
				#line 137 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				throw ((global::System.Exception) (global::haxe.Exception.thrown(global::haxe.lang.Runtime.concat("Field not found for hash ", global::haxe.lang.Runtime.toString(key)))) );
			}
			#line default
		}
		
		
		public static int hash(string s) {
			unchecked {
				#line 140 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				while (true) {
					#line 141 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					if (( s == null )) {
						#line 142 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						return 0;
					}
					
					#line 144 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					int acc = 0;
					#line 144 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					{
						#line 144 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						int _g = 0;
						#line 144 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						int _g1 = s.Length;
						#line 144 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						while (( _g < _g1 )) {
							#line 144 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
							int i = _g++;
							#line 144 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
							acc = ( ( ( 223 * (( acc >> 1 )) ) + ((int) (s[i]) ) ) << 1 );
						}
						
					}
					
					#line 144 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					int key = ((int) (( ((uint) (acc) ) >> 1 )) );
					#line 146 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					int[] ids = global::haxe.lang.FieldLookup.fieldIds;
					#line 146 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					string[] fld = global::haxe.lang.FieldLookup.fields;
					int min = 0;
					#line 148 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					int max = global::haxe.lang.FieldLookup.length;
					#line 150 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					int len = global::haxe.lang.FieldLookup.length;
					#line 152 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					while (( min < max )) {
						#line 153 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						int mid = ((int) (( min + ( ((double) ((( max - min ))) ) / 2 ) )) );
						int imid = ids[mid];
						#line 155 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						if (( key < imid )) {
							#line 156 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
							max = mid;
						}
						else if (( key > imid )) {
							#line 158 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
							min = ( mid + 1 );
						}
						else {
							#line 160 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
							string field = ((string) (fld[mid]) );
							if (( field != s )) {
								#line 162 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
								return  ~ (key) ;
							}
							
							#line 163 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
							return key;
						}
						
					}
					
					#line 169 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					lock(typeof(global::haxe.lang.FieldLookup)){
						#line 170 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						if (( len != global::haxe.lang.FieldLookup.length )) {
							#line 171 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
							string _gtmp = s;
							#line 171 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
							s = _gtmp;
							continue;
						}
						
						#line 173 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						global::haxe.lang.FieldLookup.fieldIds = global::haxe.lang.FieldLookup.insertInt(global::haxe.lang.FieldLookup.fieldIds, global::haxe.lang.FieldLookup.length, min, key);
						global::haxe.lang.FieldLookup.fields = global::haxe.lang.FieldLookup.insertString(global::haxe.lang.FieldLookup.fields, global::haxe.lang.FieldLookup.length, min, s);
						#line 175 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						 ++ global::haxe.lang.FieldLookup.length;
					}
					;
					#line 177 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					return key;
				}
				
				#line 140 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				return default(int);
			}
			#line default
		}
		
		
		public static int findHash(int hash, int[] hashs, int length) {
			unchecked {
				#line 181 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				int min = 0;
				int max = length;
				#line 184 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				while (( min < max )) {
					#line 185 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					int mid = ( (( max + min )) / 2 );
					int imid = hashs[mid];
					#line 187 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					if (( hash < imid )) {
						#line 188 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						max = mid;
					}
					else if (( hash > imid )) {
						#line 190 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						min = ( mid + 1 );
					}
					else {
						#line 192 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						return mid;
					}
					
				}
				
				#line 196 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				return  ~ (min) ;
			}
			#line default
		}
		
		
		public static void removeInt(int[] a, int length, int pos) {
			unchecked {
				#line 200 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				global::System.Array.Copy(((global::System.Array) (a) ), ((int) (( pos + 1 )) ), ((global::System.Array) (a) ), ((int) (pos) ), ((int) (( ( length - pos ) - 1 )) ));
				a[( length - 1 )] = 0;
			}
			#line default
		}
		
		
		public static void removeFloat(double[] a, int length, int pos) {
			unchecked {
				#line 205 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				global::System.Array.Copy(((global::System.Array) (a) ), ((int) (( pos + 1 )) ), ((global::System.Array) (a) ), ((int) (pos) ), ((int) (( ( length - pos ) - 1 )) ));
				a[( length - 1 )] = ((double) (0) );
			}
			#line default
		}
		
		
		public static void removeDynamic(object[] a, int length, int pos) {
			unchecked {
				#line 210 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				global::System.Array.Copy(((global::System.Array) (a) ), ((int) (( pos + 1 )) ), ((global::System.Array) (a) ), ((int) (pos) ), ((int) (( ( length - pos ) - 1 )) ));
				a[( length - 1 )] = null;
			}
			#line default
		}
		
		
		public static int[] insertInt(int[] a, int length, int pos, int x) {
			unchecked {
				#line 246 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				int[] a1 = a;
				#line 246 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				int capacity = ( a as global::System.Array ).Length;
				#line 246 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				if (( pos == length )) {
					#line 246 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					if (( capacity == length )) {
						#line 246 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						int[] newarr = new int[( (( length << 1 )) + 1 )];
						#line 246 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						( a as global::System.Array ).CopyTo(((global::System.Array) (newarr) ), ((int) (0) ));
						#line 246 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						a1 = newarr;
					}
					
				}
				else if (( pos == 0 )) {
					#line 246 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					if (( capacity == length )) {
						#line 246 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						int[] newarr1 = new int[( (( length << 1 )) + 1 )];
						#line 246 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						global::System.Array.Copy(((global::System.Array) (a) ), ((int) (0) ), ((global::System.Array) (newarr1) ), ((int) (1) ), ((int) (length) ));
						#line 246 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						a1 = newarr1;
					}
					else {
						#line 246 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						global::System.Array.Copy(((global::System.Array) (a) ), ((int) (0) ), ((global::System.Array) (a) ), ((int) (1) ), ((int) (length) ));
					}
					
				}
				else if (( capacity == length )) {
					#line 246 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					int[] newarr2 = new int[( (( length << 1 )) + 1 )];
					#line 246 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					global::System.Array.Copy(((global::System.Array) (a) ), ((int) (0) ), ((global::System.Array) (newarr2) ), ((int) (0) ), ((int) (pos) ));
					#line 246 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					global::System.Array.Copy(((global::System.Array) (a) ), ((int) (pos) ), ((global::System.Array) (newarr2) ), ((int) (( pos + 1 )) ), ((int) (( length - pos )) ));
					#line 246 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					a1 = newarr2;
				}
				else {
					#line 246 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					global::System.Array.Copy(((global::System.Array) (a) ), ((int) (pos) ), ((global::System.Array) (a) ), ((int) (( pos + 1 )) ), ((int) (( length - pos )) ));
					#line 246 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					global::System.Array.Copy(((global::System.Array) (a) ), ((int) (0) ), ((global::System.Array) (a) ), ((int) (0) ), ((int) (pos) ));
				}
				
				#line 246 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				a1[pos] = x;
				#line 246 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				return a1;
			}
			#line default
		}
		
		
		public static double[] insertFloat(double[] a, int length, int pos, double x) {
			unchecked {
				#line 249 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				double[] a1 = a;
				#line 249 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				int capacity = ( a as global::System.Array ).Length;
				#line 249 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				if (( pos == length )) {
					#line 249 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					if (( capacity == length )) {
						#line 249 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						double[] newarr = new double[( (( length << 1 )) + 1 )];
						#line 249 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						( a as global::System.Array ).CopyTo(((global::System.Array) (newarr) ), ((int) (0) ));
						#line 249 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						a1 = newarr;
					}
					
				}
				else if (( pos == 0 )) {
					#line 249 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					if (( capacity == length )) {
						#line 249 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						double[] newarr1 = new double[( (( length << 1 )) + 1 )];
						#line 249 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						global::System.Array.Copy(((global::System.Array) (a) ), ((int) (0) ), ((global::System.Array) (newarr1) ), ((int) (1) ), ((int) (length) ));
						#line 249 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						a1 = newarr1;
					}
					else {
						#line 249 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						global::System.Array.Copy(((global::System.Array) (a) ), ((int) (0) ), ((global::System.Array) (a) ), ((int) (1) ), ((int) (length) ));
					}
					
				}
				else if (( capacity == length )) {
					#line 249 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					double[] newarr2 = new double[( (( length << 1 )) + 1 )];
					#line 249 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					global::System.Array.Copy(((global::System.Array) (a) ), ((int) (0) ), ((global::System.Array) (newarr2) ), ((int) (0) ), ((int) (pos) ));
					#line 249 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					global::System.Array.Copy(((global::System.Array) (a) ), ((int) (pos) ), ((global::System.Array) (newarr2) ), ((int) (( pos + 1 )) ), ((int) (( length - pos )) ));
					#line 249 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					a1 = newarr2;
				}
				else {
					#line 249 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					global::System.Array.Copy(((global::System.Array) (a) ), ((int) (pos) ), ((global::System.Array) (a) ), ((int) (( pos + 1 )) ), ((int) (( length - pos )) ));
					#line 249 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					global::System.Array.Copy(((global::System.Array) (a) ), ((int) (0) ), ((global::System.Array) (a) ), ((int) (0) ), ((int) (pos) ));
				}
				
				#line 249 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				a1[pos] = x;
				#line 249 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				return a1;
			}
			#line default
		}
		
		
		public static object[] insertDynamic(object[] a, int length, int pos, object x) {
			unchecked {
				#line 252 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				object[] a1 = a;
				#line 252 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				int capacity = ( a as global::System.Array ).Length;
				#line 252 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				if (( pos == length )) {
					#line 252 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					if (( capacity == length )) {
						#line 252 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						object[] newarr = new object[( (( length << 1 )) + 1 )];
						#line 252 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						( a as global::System.Array ).CopyTo(((global::System.Array) (newarr) ), ((int) (0) ));
						#line 252 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						a1 = newarr;
					}
					
				}
				else if (( pos == 0 )) {
					#line 252 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					if (( capacity == length )) {
						#line 252 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						object[] newarr1 = new object[( (( length << 1 )) + 1 )];
						#line 252 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						global::System.Array.Copy(((global::System.Array) (a) ), ((int) (0) ), ((global::System.Array) (newarr1) ), ((int) (1) ), ((int) (length) ));
						#line 252 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						a1 = newarr1;
					}
					else {
						#line 252 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						global::System.Array.Copy(((global::System.Array) (a) ), ((int) (0) ), ((global::System.Array) (a) ), ((int) (1) ), ((int) (length) ));
					}
					
				}
				else if (( capacity == length )) {
					#line 252 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					object[] newarr2 = new object[( (( length << 1 )) + 1 )];
					#line 252 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					global::System.Array.Copy(((global::System.Array) (a) ), ((int) (0) ), ((global::System.Array) (newarr2) ), ((int) (0) ), ((int) (pos) ));
					#line 252 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					global::System.Array.Copy(((global::System.Array) (a) ), ((int) (pos) ), ((global::System.Array) (newarr2) ), ((int) (( pos + 1 )) ), ((int) (( length - pos )) ));
					#line 252 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					a1 = newarr2;
				}
				else {
					#line 252 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					global::System.Array.Copy(((global::System.Array) (a) ), ((int) (pos) ), ((global::System.Array) (a) ), ((int) (( pos + 1 )) ), ((int) (( length - pos )) ));
					#line 252 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					global::System.Array.Copy(((global::System.Array) (a) ), ((int) (0) ), ((global::System.Array) (a) ), ((int) (0) ), ((int) (pos) ));
				}
				
				#line 252 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				a1[pos] = ((object) (x) );
				#line 252 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				return a1;
			}
			#line default
		}
		
		
		public static string[] insertString(string[] a, int length, int pos, string x) {
			unchecked {
				#line 255 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				string[] a1 = a;
				#line 255 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				int capacity = ( a as global::System.Array ).Length;
				#line 255 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				if (( pos == length )) {
					#line 255 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					if (( capacity == length )) {
						#line 255 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						string[] newarr = new string[( (( length << 1 )) + 1 )];
						#line 255 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						( a as global::System.Array ).CopyTo(((global::System.Array) (newarr) ), ((int) (0) ));
						#line 255 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						a1 = newarr;
					}
					
				}
				else if (( pos == 0 )) {
					#line 255 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					if (( capacity == length )) {
						#line 255 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						string[] newarr1 = new string[( (( length << 1 )) + 1 )];
						#line 255 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						global::System.Array.Copy(((global::System.Array) (a) ), ((int) (0) ), ((global::System.Array) (newarr1) ), ((int) (1) ), ((int) (length) ));
						#line 255 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						a1 = newarr1;
					}
					else {
						#line 255 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						global::System.Array.Copy(((global::System.Array) (a) ), ((int) (0) ), ((global::System.Array) (a) ), ((int) (1) ), ((int) (length) ));
					}
					
				}
				else if (( capacity == length )) {
					#line 255 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					string[] newarr2 = new string[( (( length << 1 )) + 1 )];
					#line 255 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					global::System.Array.Copy(((global::System.Array) (a) ), ((int) (0) ), ((global::System.Array) (newarr2) ), ((int) (0) ), ((int) (pos) ));
					#line 255 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					global::System.Array.Copy(((global::System.Array) (a) ), ((int) (pos) ), ((global::System.Array) (newarr2) ), ((int) (( pos + 1 )) ), ((int) (( length - pos )) ));
					#line 255 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					a1 = newarr2;
				}
				else {
					#line 255 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					global::System.Array.Copy(((global::System.Array) (a) ), ((int) (pos) ), ((global::System.Array) (a) ), ((int) (( pos + 1 )) ), ((int) (( length - pos )) ));
					#line 255 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					global::System.Array.Copy(((global::System.Array) (a) ), ((int) (0) ), ((global::System.Array) (a) ), ((int) (0) ), ((int) (pos) ));
				}
				
				#line 255 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				a1[pos] = x;
				#line 255 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				return a1;
			}
			#line default
		}
		
		
		public static global::haxe.lang.FieldHashConflict getHashConflict(global::haxe.lang.FieldHashConflict head, int hash, string name) {
			#line 258 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
			while (( head != null )) {
				#line 259 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				if (( ( head.hash == hash ) && ( head.name == name ) )) {
					#line 260 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					return head;
				}
				
				#line 262 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				head = head.next;
			}
			
			#line 264 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
			return null;
		}
		#line default
		
		public static void setHashConflict(ref global::haxe.lang.FieldHashConflict head, int hash, string name, object @value) {
			#line 268 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
			global::haxe.lang.FieldHashConflict node = head;
			while (( node != null )) {
				#line 270 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				if (( ( node.hash == hash ) && ( node.name == name ) )) {
					#line 271 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					node.@value = @value;
					return;
				}
				
				#line 274 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				node = ((global::haxe.lang.FieldHashConflict) (node.next) );
			}
			
			#line 276 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
			head = ((global::haxe.lang.FieldHashConflict) (new global::haxe.lang.FieldHashConflict(hash, name, @value, ((global::haxe.lang.FieldHashConflict) (head) ))) );
		}
		#line default
		
		public static bool deleteHashConflict(ref global::haxe.lang.FieldHashConflict head, int hash, string name) {
			#line 281 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
			if (( head == null )) {
				#line 282 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				return false;
			}
			
			#line 286 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
			if (( ( head.hash == hash ) && ( head.name == name ) )) {
				#line 287 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				head = ((global::haxe.lang.FieldHashConflict) (head.next) );
				return true;
			}
			
			#line 292 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
			global::haxe.lang.FieldHashConflict prev = head;
			#line 292 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
			global::haxe.lang.FieldHashConflict node = head.next;
			while (( node != null )) {
				#line 294 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				if (( ( node.hash == hash ) && ( node.name == name ) )) {
					#line 295 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					prev.next = node.next;
					return true;
				}
				
				#line 298 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				node = node.next;
			}
			
			#line 302 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
			return false;
		}
		#line default
		
		public static void addHashConflictNames(global::haxe.lang.FieldHashConflict head, global::Array<string> arr) {
			#line 306 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
			while (( head != null )) {
				#line 307 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				arr.push(head.name);
				head = head.next;
			}
			
		}
		#line default
		
	}
}


