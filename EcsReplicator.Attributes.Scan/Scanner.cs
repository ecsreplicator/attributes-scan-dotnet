/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Peter Bjorklund. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using System.Collections.Generic;
using System.Linq;
using Mono.CecilEx;
using Piot.Clog;

namespace EcsReplicator.Attributes.Scan
{
	public static class Scanner
	{
		public static IEnumerable<DataStructInfo> Scan(ILog log, AssemblyDefinition compiledAssembly)
		{
			var definitions = ScanForReplicate.Scan(log, compiledAssembly);
			var uniqueId = 0u;
			return definitions.Select(x => new DataStructInfo(uniqueId++, x));
		}

		public static AssemblyDefinition ReadAssembly(string completePathToAssembly)
		{
			return AssemblyDefinition.ReadAssembly(completePathToAssembly);
		}
	}
}