module.exports = function (grunt) {

    var path = require('path');

	// Load the package JSON file
	var pkg = grunt.file.readJSON('package.json');

	// Load information about the assembly
	var assembly = grunt.file.readJSON('src/' + pkg + '/Properties/AssemblyInfo.json');

	// Get the version of the package
    var version = assembly.informationalVersion ? assembly.informationalVersion : assembly.version;

	grunt.initConfig({
	    pkg: pkg,
	    nugetpack: {
	        release: {
	            src: 'src/' + pkg + '/' + pkg + '.csproj',
	            dest: 'releases/nuget/'
	        }
	    },
		zip: {
		    release: {
		        router: function (filepath) {
		            return path.basename(filepath);
		        },
		        src: [
					'src/' + pkg + '/bin/Release/Skybrud.Social.dll',
					'src/' + pkg + '/bin/Release/Skybrud.Social.xml',
					'src/' + pkg + '/bin/Release/' + pkg + '.dll',
					'src/' + pkg + '/bin/Release/' + pkg + '.xml',
					'src/' + pkg + '/LICENSE.txt'
				],
			    dest: 'releases/github/' + pkg + '.v' + version + '.zip'
			}
		}
	});

	grunt.loadNpmTasks('grunt-nuget');
	grunt.loadNpmTasks('grunt-zip');

	grunt.registerTask('release', ['nugetpack', 'zip']);

	grunt.registerTask('default', ['release']);

};