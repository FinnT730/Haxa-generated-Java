// Generated by Haxe 4.1.0-rc.1+18b5e7d10

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public interface IHxObject {
		
		object __hx_lookupField(string field, int hash, bool throwErrors, bool isCheck);
		
		double __hx_lookupField_f(string field, int hash, bool throwErrors);
		
		object __hx_lookupSetField(string field, int hash, object @value);
		
		double __hx_lookupSetField_f(string field, int hash, double @value);
		
		double __hx_setField_f(string field, int hash, double @value, bool handleProperties);
		
		object __hx_setField(string field, int hash, object @value, bool handleProperties);
		
		object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties);
		
		double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties);
		
		object __hx_invokeField(string field, int hash, object[] dynargs);
		
		void __hx_getFields(global::Array<string> baseArr);
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public class HxObject : global::haxe.lang.IHxObject {
		
		public HxObject(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public HxObject() {
			#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			global::haxe.lang.HxObject.__hx_ctor_haxe_lang_HxObject(this);
		}
		#line default
		
		protected static void __hx_ctor_haxe_lang_HxObject(global::haxe.lang.HxObject __hx_this) {
		}
		
		
		public virtual bool __hx_deleteField(string field, int hash) {
			#line 34 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			return false;
		}
		#line default
		
		public virtual object __hx_lookupField(string field, int hash, bool throwErrors, bool isCheck) {
			#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			if (isCheck) {
				#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				return global::haxe.lang.Runtime.undefined;
			}
			else if (throwErrors) {
				#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				throw new global::System.MemberAccessException("Field not found.");
			}
			else {
				#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				return null;
			}
			
		}
		#line default
		
		public virtual double __hx_lookupField_f(string field, int hash, bool throwErrors) {
			#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			if (throwErrors) {
				#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				throw new global::System.MemberAccessException("Field not found or incompatible field type.");
			}
			else {
				#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				return default(double);
			}
			
		}
		#line default
		
		public virtual object __hx_lookupSetField(string field, int hash, object @value) {
			#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			throw new global::System.MemberAccessException("Cannot access field for writing.");
		}
		#line default
		
		public virtual double __hx_lookupSetField_f(string field, int hash, double @value) {
			#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			throw new global::System.MemberAccessException("Cannot access field for writing or incompatible type.");
		}
		#line default
		
		public virtual double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			switch (hash) {
				default:
				{
					#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					return this.__hx_lookupSetField_f(field, hash, @value);
				}
				
			}
			
		}
		#line default
		
		public virtual object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			switch (hash) {
				default:
				{
					#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					return this.__hx_lookupSetField(field, hash, @value);
				}
				
			}
			
		}
		#line default
		
		public virtual object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				switch (hash) {
					case 1937159360:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "__hx_deleteField", 1937159360)) );
					}
					
					
					default:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
						return this.__hx_lookupField(field, hash, throwErrors, isCheck);
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			switch (hash) {
				default:
				{
					#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					return this.__hx_lookupField_f(field, hash, throwErrors);
				}
				
			}
			
		}
		#line default
		
		public virtual object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				switch (hash) {
					case 1937159360:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
						return this.__hx_deleteField(global::haxe.lang.Runtime.toString(dynargs[0]), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
					}
					
					
					default:
					{
						#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
						return ((global::haxe.lang.Function) (this.__hx_getField(field, hash, true, false, false)) ).__hx_invokeDynamic(dynargs);
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual void __hx_getFields(global::Array<string> baseArr) {
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public class DynamicObject : global::haxe.lang.HxObject {
		
		static DynamicObject() {
			#line 56 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			global::haxe.lang.DynamicObject.__hx_toString_depth = 0;
		}
		#line default
		
		public DynamicObject(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY) {
		}
		
		
		public DynamicObject(int[] hashes, object[] dynamics, int[] hashes_f, double[] dynamics_f) {
			#line 66 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			global::haxe.lang.DynamicObject.__hx_ctor_haxe_lang_DynamicObject(((global::haxe.lang.DynamicObject) (this) ), ((int[]) (hashes) ), ((object[]) (dynamics) ), ((int[]) (hashes_f) ), ((double[]) (dynamics_f) ));
		}
		#line default
		
		public DynamicObject() {
			#line 58 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			global::haxe.lang.DynamicObject.__hx_ctor_haxe_lang_DynamicObject(((global::haxe.lang.DynamicObject) (this) ));
		}
		#line default
		
		protected static void __hx_ctor_haxe_lang_DynamicObject(global::haxe.lang.DynamicObject __hx_this, int[] hashes, object[] dynamics, int[] hashes_f, double[] dynamics_f) {
			#line 67 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			__hx_this.__hx_hashes = hashes;
			__hx_this.__hx_dynamics = dynamics;
			#line 69 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			__hx_this.__hx_hashes_f = hashes_f;
			__hx_this.__hx_dynamics_f = dynamics_f;
			#line 71 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			__hx_this.__hx_length = ( hashes as global::System.Array ).Length;
			__hx_this.__hx_length_f = ( hashes_f as global::System.Array ).Length;
			#line 73 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			__hx_this.__hx_conflicts = null;
		}
		#line default
		
		protected static void __hx_ctor_haxe_lang_DynamicObject(global::haxe.lang.DynamicObject __hx_this) {
			#line 59 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			__hx_this.__hx_hashes = new int[0];
			__hx_this.__hx_dynamics = new object[0];
			#line 61 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			__hx_this.__hx_hashes_f = new int[0];
			__hx_this.__hx_dynamics_f = new double[0];
			#line 63 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			__hx_this.__hx_conflicts = null;
		}
		#line default
		
		public static int __hx_toString_depth;
		
		public int[] __hx_hashes;
		
		public object[] __hx_dynamics;
		
		public int[] __hx_hashes_f;
		
		public double[] __hx_dynamics_f;
		
		public int __hx_length;
		
		public int __hx_length_f;
		
		public global::haxe.lang.FieldHashConflict __hx_conflicts;
		
		public override bool __hx_deleteField(string field, int hash) {
			#line 77 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			if (( hash < 0 )) {
				#line 78 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				return global::haxe.lang.FieldLookup.deleteHashConflict(ref this.__hx_conflicts, hash, field);
			}
			
			#line 81 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			int res = global::haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes, this.__hx_length);
			if (( res >= 0 )) {
				#line 83 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				global::haxe.lang.FieldLookup.removeInt(this.__hx_hashes, this.__hx_length, res);
				global::haxe.lang.FieldLookup.removeDynamic(this.__hx_dynamics, this.__hx_length, res);
				#line 85 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				this.__hx_length--;
				return true;
			}
			
			#line 88 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			res = global::haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes_f, this.__hx_length_f);
			if (( res >= 0 )) {
				#line 90 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				global::haxe.lang.FieldLookup.removeInt(this.__hx_hashes_f, this.__hx_length_f, res);
				global::haxe.lang.FieldLookup.removeFloat(this.__hx_dynamics_f, this.__hx_length_f, res);
				#line 92 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				this.__hx_length_f--;
				return true;
			}
			
			#line 95 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			return false;
		}
		#line default
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			#line 99 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			if (( hash < 0 )) {
				#line 100 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				global::haxe.lang.FieldHashConflict conflict = global::haxe.lang.FieldLookup.getHashConflict(this.__hx_conflicts, hash, field);
				if (( conflict != null )) {
					#line 102 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					return conflict.@value;
				}
				
			}
			
			#line 106 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			int res = global::haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes, this.__hx_length);
			if (( res >= 0 )) {
				#line 108 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				return this.__hx_dynamics[res];
			}
			
			#line 110 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			res = global::haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes_f, this.__hx_length_f);
			if (( res >= 0 )) {
				#line 112 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				return this.__hx_dynamics_f[res];
			}
			
			#line 115 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			if (isCheck) {
				#line 115 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				return global::haxe.lang.Runtime.undefined;
			}
			else {
				#line 115 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				return null;
			}
			
		}
		#line default
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			#line 119 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			if (( hash < 0 )) {
				#line 120 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				global::haxe.lang.FieldLookup.setHashConflict(ref this.__hx_conflicts, hash, field, @value);
				return @value;
			}
			
			#line 124 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			int res = global::haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes, this.__hx_length);
			if (( res >= 0 )) {
				#line 126 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				return this.__hx_dynamics[res] = @value;
			}
			else {
				#line 128 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				int res1 = global::haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes_f, this.__hx_length_f);
				if (( res1 >= 0 )) {
					#line 130 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					if ((( ( @value is double ) || ( ( @value is int ) || ( @value is uint ) ) ))) {
						#line 131 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
						return this.__hx_dynamics_f[res1] = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
					}
					
					#line 134 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					global::haxe.lang.FieldLookup.removeInt(this.__hx_hashes_f, this.__hx_length_f, res1);
					global::haxe.lang.FieldLookup.removeFloat(this.__hx_dynamics_f, this.__hx_length_f, res1);
					#line 136 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					this.__hx_length_f--;
				}
				
			}
			
			#line 140 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			this.__hx_hashes = global::haxe.lang.FieldLookup.insertInt(this.__hx_hashes, this.__hx_length,  ~ (res) , hash);
			this.__hx_dynamics = global::haxe.lang.FieldLookup.insertDynamic(this.__hx_dynamics, this.__hx_length,  ~ (res) , @value);
			#line 142 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			this.__hx_length++;
			return @value;
		}
		#line default
		
		public override double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			#line 147 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			if (( hash < 0 )) {
				#line 148 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				global::haxe.lang.FieldHashConflict conflict = global::haxe.lang.FieldLookup.getHashConflict(this.__hx_conflicts, hash, field);
				if (( conflict != null )) {
					#line 150 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					return ((double) (global::haxe.lang.Runtime.toDouble(conflict.@value)) );
				}
				
			}
			
			#line 154 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			int res = global::haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes_f, this.__hx_length_f);
			if (( res >= 0 )) {
				#line 156 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				return this.__hx_dynamics_f[res];
			}
			
			#line 158 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			res = global::haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes, this.__hx_length);
			if (( res >= 0 )) {
				#line 160 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				return ((double) (global::haxe.lang.Runtime.toDouble(this.__hx_dynamics[res])) );
			}
			
			#line 163 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			return 0.0;
		}
		#line default
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			#line 167 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			if (( hash < 0 )) {
				#line 168 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				global::haxe.lang.FieldLookup.setHashConflict(ref this.__hx_conflicts, hash, field, @value);
				return @value;
			}
			
			#line 172 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			int res = global::haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes_f, this.__hx_length_f);
			if (( res >= 0 )) {
				#line 174 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				return this.__hx_dynamics_f[res] = @value;
			}
			else {
				#line 176 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				int res1 = global::haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes, this.__hx_length);
				if (( res1 >= 0 )) {
					#line 179 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					global::haxe.lang.FieldLookup.removeInt(this.__hx_hashes, this.__hx_length, res1);
					global::haxe.lang.FieldLookup.removeDynamic(this.__hx_dynamics, this.__hx_length, res1);
					#line 181 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					this.__hx_length--;
				}
				
			}
			
			#line 185 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			this.__hx_hashes_f = global::haxe.lang.FieldLookup.insertInt(this.__hx_hashes_f, this.__hx_length_f,  ~ (res) , hash);
			this.__hx_dynamics_f = global::haxe.lang.FieldLookup.insertFloat(this.__hx_dynamics_f, this.__hx_length_f,  ~ (res) , @value);
			#line 187 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			this.__hx_length_f++;
			return @value;
		}
		#line default
		
		public override void __hx_getFields(global::Array<string> baseArr) {
			#line 192 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			{
				#line 192 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				int _g = 0;
				#line 192 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				int _g1 = this.__hx_length;
				#line 192 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				while (( _g < _g1 )) {
					#line 192 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					int i = _g++;
					baseArr.push(global::haxe.lang.FieldLookup.lookupHash(this.__hx_hashes[i]));
				}
				
			}
			
			#line 195 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			{
				#line 195 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				int _g2 = 0;
				#line 195 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				int _g3 = this.__hx_length_f;
				#line 195 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				while (( _g2 < _g3 )) {
					#line 195 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					int i1 = _g2++;
					baseArr.push(global::haxe.lang.FieldLookup.lookupHash(this.__hx_hashes_f[i1]));
				}
				
			}
			
			#line 198 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			global::haxe.lang.FieldLookup.addHashConflictNames(this.__hx_conflicts, baseArr);
		}
		#line default
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			#line 202 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			if (( field == "toString" )) {
				#line 203 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				return this.toString();
			}
			
			#line 205 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			global::haxe.lang.Function fn = ((global::haxe.lang.Function) (this.__hx_getField(field, hash, false, false, false)) );
			if (( fn == null )) {
				#line 207 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				throw ((global::System.Exception) (global::haxe.Exception.thrown(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Cannot invoke field ", field), ": It does not exist"))) );
			}
			
			#line 210 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			return fn.__hx_invokeDynamic(dynargs);
		}
		#line default
		
		public virtual string toString() {
			unchecked {
				#line 214 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				if (( global::haxe.lang.DynamicObject.__hx_toString_depth >= 5 )) {
					#line 215 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					return "...";
				}
				
				#line 217 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				 ++ global::haxe.lang.DynamicObject.__hx_toString_depth;
				try {
					#line 219 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					string s = this.__hx_toString();
					 -- global::haxe.lang.DynamicObject.__hx_toString_depth;
					#line 221 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					return s;
				}
				catch (global::System.Exception _g){
					object _g1 = global::haxe.Exception.caught(_g).unwrap();
					#line 222 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					{
						#line 223 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
						 -- global::haxe.lang.DynamicObject.__hx_toString_depth;
						throw ((global::System.Exception) (global::haxe.Exception.thrown(_g1)) );
					}
					
				}
				
				
			}
			#line default
		}
		
		
		public virtual string __hx_toString() {
			#line 229 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			global::haxe.lang.Function ts = ((global::haxe.lang.Function) (global::haxe.lang.Runtime.getField(this, "toString", 946786476, false)) );
			if (( ts != null )) {
				#line 231 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				return global::haxe.lang.Runtime.toString(ts.__hx_invoke0_o());
			}
			
			#line 232 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			global::System.Text.StringBuilder ret_b = new global::System.Text.StringBuilder();
			ret_b.Append(((string) ("{") ));
			#line 234 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			bool first = true;
			{
				#line 235 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				int _g = 0;
				#line 235 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				global::Array<string> _g1 = global::Reflect.fields(this);
				#line 235 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				while (( _g < _g1.length )) {
					#line 235 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					string f = _g1[_g];
					#line 235 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					 ++ _g;
					if (first) {
						#line 237 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
						first = false;
					}
					else {
						#line 239 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
						ret_b.Append(((string) (",") ));
					}
					
					#line 240 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					ret_b.Append(((string) (" ") ));
					ret_b.Append(((string) (global::Std.@string(f)) ));
					#line 242 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					ret_b.Append(((string) (" : ") ));
					ret_b.Append(((string) (global::Std.@string(((object) (global::Reflect.field(this, f)) ))) ));
				}
				
			}
			
			#line 245 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			if ( ! (first) ) {
				#line 246 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				ret_b.Append(((string) (" ") ));
			}
			
			#line 247 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			ret_b.Append(((string) ("}") ));
			return ret_b.ToString();
		}
		#line default
		
		public override string ToString(){
			return this.toString();
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public interface IGenericObject : global::haxe.lang.IHxObject {
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public class GenericInterface : global::System.Attribute {
		
		public GenericInterface(global::System.Type generic) : base() {
			#line 260 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			this.generic = generic;
		}
		#line default
		
		public readonly global::System.Type generic;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public class Enum {
		
		protected Enum(int index) {
			#line 275 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			this._hx_index = index;
		}
		#line default
		
		protected static string paramsToString(string tag, object[] @params) {
			#line 291 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			global::System.Text.StringBuilder ret_b = new global::System.Text.StringBuilder();
			ret_b.Append(((string) (global::Std.@string(tag)) ));
			#line 293 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			ret_b.Append(((string) ("(") ));
			bool first = true;
			#line 295 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			{
				#line 295 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				int _g = 0;
				#line 295 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				while (( _g < ( ((object[]) (@params) ) as global::System.Array ).Length )) {
					#line 295 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					object p = ((object[]) (@params) )[_g];
					#line 295 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					 ++ _g;
					if (first) {
						#line 297 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
						first = false;
					}
					else {
						#line 299 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
						ret_b.Append(((string) (",") ));
					}
					
					#line 300 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					ret_b.Append(((string) (global::Std.@string(((object) (p) ))) ));
				}
				
			}
			
			#line 302 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			ret_b.Append(((string) (")") ));
			return ret_b.ToString();
		}
		#line default
		
		protected static int paramsGetHashCode(int index, object[] @params) {
			unchecked {
				#line 307 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				int h = 19;
				if (( @params != null )) {
					#line 309 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					int _g = 0;
					#line 309 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
					while (( _g < ( ((object[]) (@params) ) as global::System.Array ).Length )) {
						#line 309 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
						object p = ((object[]) (@params) )[_g];
						#line 309 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
						 ++ _g;
						h *= 31;
						#line 311 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
						if (( p != null )) {
							#line 312 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
							h += ((int) (global::haxe.lang.Runtime.toInt(p.GetHashCode())) );
						}
						
					}
					
				}
				
				#line 314 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
				h += index;
				return h;
			}
			#line default
		}
		
		
		public readonly int _hx_index;
		
		public virtual string getTag() {
			#line 279 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			throw ((global::System.Exception) (global::haxe.Exception.thrown("Not Implemented")) );
		}
		#line default
		
		public virtual global::Array<object> getParams() {
			#line 283 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			return new global::Array<object>(new object[]{});
		}
		#line default
		
		public virtual string toString() {
			#line 287 "C:\\HaxeToolkit\\haxe\\std\\cs\\internal\\HxObject.hx"
			return this.getTag();
		}
		#line default
		
		public override string ToString(){
			return this.toString();
		}
		
		
	}
}


