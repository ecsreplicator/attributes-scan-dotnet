/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Peter Bjorklund. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using Mono.CecilEx;

namespace EcsReplicator.Attributes.Scan
{
	public class DataStructInfo
	{
		public TypeDefinition TypeDefinition => typeDefinition;
		public uint UniqueId => uniqueId;

		private uint uniqueId;
		private TypeDefinition typeDefinition;

		public DataStructInfo(uint uniqueId, TypeDefinition typeDefinition)
		{
			this.uniqueId = uniqueId;
			this.typeDefinition = typeDefinition;
		}
	}
}