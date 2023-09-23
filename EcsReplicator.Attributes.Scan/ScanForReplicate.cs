/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Peter Bjorklund. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using System.Linq;
using Mono.CecilEx;
using Piot.Clog;

namespace EcsReplicator.Attributes.Scan
{
	public class ScanForReplicate
	{
		public static TypeDefinition[] Scan(ILog log, AssemblyDefinition compiledAssembly)
		{
			var replicatedStructs =
				AttributeScanner.ScanForStructWithAttribute(log, new[] { compiledAssembly },
					typeof(ReplicateComponentAttribute));
			if (!replicatedStructs.Any())
			{
				log.Debug($"Skip {compiledAssembly.MainModule.Name}, since it has no references to replicated components");
				//throw new Exception("skip {compiledAssembly.MainModule.Name} no logics found");
			}

			return replicatedStructs.ToArray();
		}
	}
}