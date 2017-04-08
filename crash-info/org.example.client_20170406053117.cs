S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 13129
Date: 2017-04-06 05:31:17+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 13129, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00003349
r2   = 0x00000006, r3   = 0xb40b04c0
r4   = 0x00000002, r5   = 0xb40b0000
r6   = 0xb67aa09c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb5ed8708
r10  = 0xb85955a0, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbea9dc2c
lr   = 0xb66a0f18, pc   = 0xb669fb84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:     73920 KB
Buffers:     63680 KB
Cached:     287980 KB
VmPeak:     133920 KB
VmSize:     133916 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       28340 KB
VmRSS:       28340 KB
VmData:      45860 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35780 KB
VmPTE:          98 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 13129 TID = 13129
13129 13130 13390 13391 13399 

Maps Information
aee4c000 af64b000 rw-p [stack:13399]
b0f56000 b0f67000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b0f77000 b0f7c000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b137e000 b1386000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1398000 b1b97000 rw-p [stack:13391]
b1b97000 b1b98000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1ba8000 b1bbc000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1bd0000 b1bd1000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1be1000 b1be4000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1bf5000 b1bf6000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c06000 b1c08000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c18000 b1c1a000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c2a000 b1c3a000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c4a000 b1c56000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c68000 b2467000 rw-p [stack:13390]
b2798000 b279f000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27b2000 b27b8000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27c8000 b27e4000 r-xp /opt/usr/apps/org.example.client/bin/client
b293c000 b2a1f000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a56000 b2a7e000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a90000 b328f000 rw-p [stack:13130]
b328f000 b3291000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32a1000 b32ab000 r-xp /lib/libnss_files-2.20-2014.11.so
b32bc000 b32c5000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32d6000 b32e7000 r-xp /lib/libnsl-2.20-2014.11.so
b32fa000 b3300000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3311000 b3312000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b333a000 b3341000 r-xp /usr/lib/libminizip.so.1.0.0
b3351000 b3356000 r-xp /usr/lib/libstorage.so.0.1
b3366000 b33c5000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33db000 b33ef000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33ff000 b3443000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3453000 b345b000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b346b000 b349b000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34ae000 b3567000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b357b000 b35ce000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b35df000 b35fa000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b360a000 b36cb000 r-xp /usr/lib/libprotobuf.so.9.0.1
b36de000 b36ee000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36fe000 b370b000 r-xp /usr/lib/libmdm-common.so.1.0.98
b371c000 b3723000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3733000 b3774000 r-xp /usr/lib/libmdm.so.1.2.12
b3784000 b378c000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b379b000 b37ab000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37cc000 b382c000 r-xp /usr/lib/libasound.so.2.0.0
b383e000 b3841000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3851000 b3854000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3864000 b3869000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3879000 b387a000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b388a000 b3895000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38a9000 b38b0000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38c0000 b38c6000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38d6000 b38db000 r-xp /usr/lib/libmmfsession.so.0.0.1
b38eb000 b3906000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3916000 b391d000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b392d000 b3930000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3941000 b396f000 r-xp /usr/lib/libidn.so.11.5.44
b397f000 b3995000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39a6000 b39b0000 r-xp /usr/lib/libcares.so.2.1.0
b39c0000 b39ca000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b39da000 b39dc000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b39ec000 b39ed000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39fd000 b3a01000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a12000 b3a3a000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a4b000 b3a74000 r-xp /usr/lib/libturbojpeg.so
b3a94000 b3a9a000 r-xp /usr/lib/libgif.so.4.1.6
b3aaa000 b3af0000 r-xp /usr/lib/libcurl.so.4.3.0
b3b01000 b3b22000 r-xp /usr/lib/libexif.so.12.3.3
b3b3d000 b3b52000 r-xp /usr/lib/libtts.so
b3b63000 b3b6b000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b7b000 b3c41000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c61000 b3d59000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d78000 b3e46000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e5d000 b3e5f000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e6f000 b3e75000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e85000 b3ea8000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3eb9000 b3ebb000 r-xp /usr/lib/libappsvc.so.0.1.0
b3ecb000 b3ecd000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3ede000 b3ee3000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3efa000 b3efc000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f0c000 b3f13000 r-xp /usr/lib/libsensord-share.so
b3f23000 b3f3b000 r-xp /usr/lib/libsensor.so.1.1.0
b3f4c000 b3f4f000 r-xp /usr/lib/libXv.so.1.0.0
b3f5f000 b3f64000 r-xp /usr/lib/libutilX.so.1.1.0
b3f74000 b3f79000 r-xp /usr/lib/libappcore-common.so.1.1
b3f89000 b3f90000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3fa3000 b3fa7000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3fb8000 b4096000 r-xp /usr/lib/libCOREGL.so.4.0
b40b6000 b40b9000 r-xp /usr/lib/libuuid.so.1.3.0
b40c9000 b40e0000 r-xp /usr/lib/libblkid.so.1.1.0
b40f1000 b40f3000 r-xp /usr/lib/libXau.so.6.0.0
b4103000 b414a000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b415c000 b4162000 r-xp /usr/lib/libjson-c.so.2.0.1
b4173000 b4177000 r-xp /usr/lib/libogg.so.0.7.1
b4187000 b41a9000 r-xp /usr/lib/libvorbis.so.0.4.3
b41b9000 b429d000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42b9000 b42bc000 r-xp /usr/lib/libEGL.so.1.4
b42cd000 b42d3000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42e3000 b42e5000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42f5000 b4302000 r-xp /usr/lib/libGLESv2.so.2.0
b4313000 b4375000 r-xp /usr/lib/libpixman-1.so.0.28.2
b438a000 b43a2000 r-xp /usr/lib/libmount.so.1.1.0
b43b4000 b43c8000 r-xp /usr/lib/libxcb.so.1.1.0
b43d8000 b43df000 r-xp /lib/libcrypt-2.20-2014.11.so
b4417000 b4419000 r-xp /usr/lib/libiri.so
b4429000 b4434000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4445000 b447b000 r-xp /usr/lib/libpulse.so.0.16.2
b448c000 b44cf000 r-xp /usr/lib/libsndfile.so.1.0.25
b44e4000 b44f9000 r-xp /lib/libexpat.so.1.5.2
b450b000 b45c9000 r-xp /usr/lib/libcairo.so.2.11200.14
b45dd000 b45e5000 r-xp /usr/lib/libdrm.so.2.4.0
b45f5000 b45f8000 r-xp /usr/lib/libdri2.so.0.0.0
b4608000 b4656000 r-xp /usr/lib/libssl.so.1.0.0
b466b000 b4677000 r-xp /usr/lib/libeeze.so.1.13.0
b4688000 b4691000 r-xp /usr/lib/libethumb.so.1.13.0
b46a1000 b46a4000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46b4000 b486b000 r-xp /usr/lib/libcrypto.so.1.0.0
b5656000 b565f000 r-xp /usr/lib/libXi.so.6.1.0
b566f000 b5671000 r-xp /usr/lib/libXgesture.so.7.0.0
b5681000 b5685000 r-xp /usr/lib/libXtst.so.6.1.0
b5695000 b569b000 r-xp /usr/lib/libXrender.so.1.3.0
b56ab000 b56b1000 r-xp /usr/lib/libXrandr.so.2.2.0
b56c1000 b56c3000 r-xp /usr/lib/libXinerama.so.1.0.0
b56d4000 b56d7000 r-xp /usr/lib/libXfixes.so.3.1.0
b56e7000 b56f2000 r-xp /usr/lib/libXext.so.6.4.0
b5702000 b5704000 r-xp /usr/lib/libXdamage.so.1.1.0
b5714000 b5716000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5726000 b5808000 r-xp /usr/lib/libX11.so.6.3.0
b581c000 b5823000 r-xp /usr/lib/libXcursor.so.1.0.2
b5833000 b584b000 r-xp /usr/lib/libudev.so.1.6.0
b584d000 b5850000 r-xp /lib/libattr.so.1.1.0
b5860000 b5880000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5881000 b5886000 r-xp /usr/lib/libffi.so.6.0.2
b5897000 b58af000 r-xp /lib/libz.so.1.2.8
b58bf000 b58c1000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58d1000 b59a6000 r-xp /usr/lib/libxml2.so.2.9.2
b59bb000 b5a56000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a72000 b5a75000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a85000 b5a9e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5aaf000 b5ac0000 r-xp /lib/libresolv-2.20-2014.11.so
b5ad4000 b5b4e000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b63000 b5b65000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b75000 b5b7c000 r-xp /usr/lib/libembryo.so.1.13.0
b5b8c000 b5b96000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5ba7000 b5bbf000 r-xp /usr/lib/libpng12.so.0.50.0
b5bd0000 b5bf3000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c14000 b5c28000 r-xp /usr/lib/libector.so.1.13.0
b5c39000 b5c51000 r-xp /usr/lib/liblua-5.1.so
b5c62000 b5cb9000 r-xp /usr/lib/libfreetype.so.6.11.3
b5ccd000 b5cf5000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d06000 b5d19000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d2a000 b5d64000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d75000 b5d83000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d93000 b5d9b000 r-xp /usr/lib/libtbm.so.1.0.0
b5dab000 b5db8000 r-xp /usr/lib/libeio.so.1.13.0
b5dc8000 b5dca000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5dda000 b5ddf000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5def000 b5e06000 r-xp /usr/lib/libefreet.so.1.13.0
b5e18000 b5e38000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e48000 b5e68000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e6a000 b5e70000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e80000 b5e91000 r-xp /usr/lib/libemotion.so.1.13.0
b5ea2000 b5ea9000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5eb9000 b5ec8000 r-xp /usr/lib/libeo.so.1.13.0
b5ed9000 b5eeb000 r-xp /usr/lib/libecore_input.so.1.13.0
b5efc000 b5f01000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f11000 b5f2a000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f3a000 b5f57000 r-xp /usr/lib/libeet.so.1.13.0
b5f70000 b5fb8000 r-xp /usr/lib/libeina.so.1.13.0
b5fc9000 b5fd9000 r-xp /usr/lib/libefl.so.1.13.0
b5fea000 b60cf000 r-xp /usr/lib/libicuuc.so.51.1
b60ec000 b622c000 r-xp /usr/lib/libicui18n.so.51.1
b6243000 b627b000 r-xp /usr/lib/libecore_x.so.1.13.0
b628d000 b6290000 r-xp /lib/libcap.so.2.21
b62a0000 b62c9000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62da000 b62e1000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62f3000 b632a000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b633b000 b6426000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6439000 b64b2000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64c4000 b64c9000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64d9000 b64e3000 r-xp /usr/lib/libvconf.so.0.2.45
b64f3000 b64f5000 r-xp /usr/lib/libvasum.so.0.3.1
b6505000 b6507000 r-xp /usr/lib/libttrace.so.1.1
b6517000 b651a000 r-xp /usr/lib/libiniparser.so.0
b652a000 b6550000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6560000 b6565000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6576000 b658d000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b659e000 b6609000 r-xp /lib/libm-2.20-2014.11.so
b661a000 b6620000 r-xp /lib/librt-2.20-2014.11.so
b6631000 b663e000 r-xp /usr/lib/libunwind.so.8.0.1
b6674000 b6798000 r-xp /lib/libc-2.20-2014.11.so
b67ad000 b67c6000 r-xp /lib/libgcc_s-4.9.so.1
b67d6000 b68b8000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68c9000 b68f3000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6904000 b6940000 r-xp /usr/lib/libsystemd.so.0.4.0
b6942000 b69c5000 r-xp /usr/lib/libedje.so.1.13.0
b69d8000 b69f6000 r-xp /usr/lib/libecore.so.1.13.0
b6a16000 b6b9d000 r-xp /usr/lib/libevas.so.1.13.0
b6bd2000 b6be6000 r-xp /lib/libpthread-2.20-2014.11.so
b6bfa000 b6e2e000 r-xp /usr/lib/libelementary.so.1.13.0
b6e5d000 b6e61000 r-xp /usr/lib/libsmack.so.1.0.0
b6e71000 b6e78000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e88000 b6e8a000 r-xp /usr/lib/libdlog.so.0.0.0
b6e9a000 b6e9d000 r-xp /usr/lib/libbundle.so.0.1.22
b6ead000 b6eaf000 r-xp /lib/libdl-2.20-2014.11.so
b6ec0000 b6ed8000 r-xp /usr/lib/libaul.so.0.1.0
b6eec000 b6ef1000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f02000 b6f0f000 r-xp /usr/lib/liblptcp.so
b6f21000 b6f25000 r-xp /usr/lib/libsys-assert.so
b6f36000 b6f56000 r-xp /lib/ld-2.20-2014.11.so
b6f67000 b6f6c000 r-xp /usr/bin/launchpad-loader
b8212000 b85f1000 rw-p [heap]
bea7e000 bea9f000 rw-p [stack]
End of Maps Information

Callstack Information (PID:13129)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb669fb84) [/lib/libc.so.6] + 0x2bb84
End of Call Stack

Package Information
Package Name: org.example.client
Package ID : org.example.client
Version: 1.0.0
Package Type: tpk
App Name: client
App ID: org.example.client
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
8553) is dead. cmd(5) is canceled
04-06 05:30:59.694+0900 W/AUL     (13179): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-06 05:30:59.694+0900 E/PKGMGR_SERVER(13179): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-06 05:30:59.694+0900 E/PKGMGR_SERVER(13179): [0;m
04-06 05:30:59.694+0900 W/AUL     (13179): launch.c: app_request_to_launchpad(396) > request cmd(5) to(26716)
04-06 05:30:59.694+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-06 05:30:59.694+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(26716) is dead. cmd(5) is canceled
04-06 05:30:59.694+0900 W/AUL     (13179): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-06 05:30:59.694+0900 E/PKGMGR_SERVER(13179): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-06 05:30:59.694+0900 E/PKGMGR_SERVER(13179): [0;m
04-06 05:30:59.694+0900 W/AUL     (13179): launch.c: app_request_to_launchpad(396) > request cmd(5) to(29758)
04-06 05:30:59.694+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-06 05:30:59.694+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(29758) is dead. cmd(5) is canceled
04-06 05:30:59.694+0900 W/AUL     (13179): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-06 05:30:59.694+0900 E/PKGMGR_SERVER(13179): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-06 05:30:59.694+0900 E/PKGMGR_SERVER(13179): [0;m
04-06 05:30:59.694+0900 W/AUL     (13179): launch.c: app_request_to_launchpad(396) > request cmd(5) to(31243)
04-06 05:30:59.694+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-06 05:30:59.694+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(31243) is dead. cmd(5) is canceled
04-06 05:30:59.694+0900 W/AUL     (13179): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-06 05:30:59.694+0900 E/PKGMGR_SERVER(13179): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-06 05:30:59.694+0900 E/PKGMGR_SERVER(13179): [0;m
04-06 05:30:59.694+0900 W/AUL     (13179): launch.c: app_request_to_launchpad(396) > request cmd(5) to(7973)
04-06 05:30:59.694+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-06 05:30:59.694+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(7973) is dead. cmd(5) is canceled
04-06 05:30:59.694+0900 W/AUL     (13179): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-06 05:30:59.694+0900 E/PKGMGR_SERVER(13179): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-06 05:30:59.694+0900 E/PKGMGR_SERVER(13179): [0;m
04-06 05:30:59.694+0900 W/AUL     (13179): launch.c: app_request_to_launchpad(396) > request cmd(5) to(9190)
04-06 05:30:59.704+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-06 05:30:59.704+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(9190) is dead. cmd(5) is canceled
04-06 05:30:59.704+0900 W/AUL     (13179): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-06 05:30:59.704+0900 E/PKGMGR_SERVER(13179): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-06 05:30:59.704+0900 E/PKGMGR_SERVER(13179): [0;m
04-06 05:30:59.704+0900 W/AUL     (13179): launch.c: app_request_to_launchpad(396) > request cmd(5) to(9309)
04-06 05:30:59.704+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-06 05:30:59.704+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(9309) is dead. cmd(5) is canceled
04-06 05:30:59.704+0900 W/AUL     (13179): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-06 05:30:59.704+0900 E/PKGMGR_SERVER(13179): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-06 05:30:59.704+0900 E/PKGMGR_SERVER(13179): [0;m
04-06 05:30:59.704+0900 W/AUL     (13179): launch.c: app_request_to_launchpad(396) > request cmd(5) to(9436)
04-06 05:30:59.704+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-06 05:30:59.704+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(9436) is dead. cmd(5) is canceled
04-06 05:30:59.704+0900 W/AUL     (13179): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-06 05:30:59.704+0900 E/PKGMGR_SERVER(13179): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-06 05:30:59.704+0900 E/PKGMGR_SERVER(13179): [0;m
04-06 05:30:59.704+0900 W/AUL     (13179): launch.c: app_request_to_launchpad(396) > request cmd(5) to(9715)
04-06 05:30:59.704+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-06 05:30:59.704+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(9715) is dead. cmd(5) is canceled
04-06 05:30:59.704+0900 W/AUL     (13179): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-06 05:30:59.704+0900 E/PKGMGR_SERVER(13179): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-06 05:30:59.704+0900 E/PKGMGR_SERVER(13179): [0;m
04-06 05:30:59.704+0900 W/AUL     (13179): launch.c: app_request_to_launchpad(396) > request cmd(5) to(10450)
04-06 05:30:59.704+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-06 05:30:59.704+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(10450) is dead. cmd(5) is canceled
04-06 05:30:59.704+0900 W/AUL     (13179): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-06 05:30:59.704+0900 E/PKGMGR_SERVER(13179): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-06 05:30:59.704+0900 E/PKGMGR_SERVER(13179): [0;m
04-06 05:30:59.704+0900 W/AUL     (13179): launch.c: app_request_to_launchpad(396) > request cmd(5) to(10574)
04-06 05:30:59.704+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-06 05:30:59.704+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(10574) is dead. cmd(5) is canceled
04-06 05:30:59.704+0900 W/AUL     (13179): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-06 05:30:59.704+0900 E/PKGMGR_SERVER(13179): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-06 05:30:59.704+0900 E/PKGMGR_SERVER(13179): [0;m
04-06 05:30:59.704+0900 W/AUL     (13179): launch.c: app_request_to_launchpad(396) > request cmd(5) to(11226)
04-06 05:30:59.704+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-06 05:30:59.704+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(11226) is dead. cmd(5) is canceled
04-06 05:30:59.704+0900 W/AUL     (13179): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-06 05:30:59.704+0900 E/PKGMGR_SERVER(13179): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-06 05:30:59.704+0900 E/PKGMGR_SERVER(13179): [0;m
04-06 05:30:59.704+0900 W/AUL     (13179): launch.c: app_request_to_launchpad(396) > request cmd(5) to(11354)
04-06 05:30:59.704+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-06 05:30:59.704+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(11354) is dead. cmd(5) is canceled
04-06 05:30:59.704+0900 W/AUL     (13179): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-06 05:30:59.704+0900 E/PKGMGR_SERVER(13179): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-06 05:30:59.704+0900 E/PKGMGR_SERVER(13179): [0;m
04-06 05:30:59.704+0900 W/AUL     (13179): launch.c: app_request_to_launchpad(396) > request cmd(5) to(11514)
04-06 05:30:59.704+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-06 05:30:59.704+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(11514) is dead. cmd(5) is canceled
04-06 05:30:59.704+0900 W/AUL     (13179): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-06 05:30:59.704+0900 E/PKGMGR_SERVER(13179): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-06 05:30:59.704+0900 E/PKGMGR_SERVER(13179): [0;m
04-06 05:30:59.704+0900 W/AUL     (13179): launch.c: app_request_to_launchpad(396) > request cmd(5) to(12730)
04-06 05:30:59.714+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-06 05:30:59.714+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(12730) is dead. cmd(5) is canceled
04-06 05:30:59.714+0900 W/AUL     (13179): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-06 05:30:59.714+0900 E/PKGMGR_SERVER(13179): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-06 05:30:59.714+0900 E/PKGMGR_SERVER(13179): [0;m
04-06 05:30:59.714+0900 W/AUL     (13179): launch.c: app_request_to_launchpad(396) > request cmd(5) to(12853)
04-06 05:30:59.714+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-06 05:30:59.714+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(12853) is dead. cmd(5) is canceled
04-06 05:30:59.714+0900 W/AUL     (13179): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-06 05:30:59.714+0900 E/PKGMGR_SERVER(13179): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-06 05:30:59.714+0900 E/PKGMGR_SERVER(13179): [0;m
04-06 05:30:59.714+0900 W/AUL     (13179): launch.c: app_request_to_launchpad(396) > request cmd(5) to(12578)
04-06 05:30:59.714+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-06 05:30:59.714+0900 I/APP_CORE(12578): appcore-efl.c: __do_app(514) > [APP 12578] Event: TERMINATE State: RUNNING
04-06 05:30:59.714+0900 W/AUL_AMD (  610): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(12578), cmd(4)
04-06 05:30:59.714+0900 W/AUL     (13179): launch.c: app_request_to_launchpad(425) > request cmd(5) result(0)
04-06 05:30:59.714+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 05:30:59.714+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 12578
04-06 05:30:59.714+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
04-06 05:30:59.714+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
04-06 05:30:59.714+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
04-06 05:30:59.714+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
04-06 05:30:59.724+0900 I/TIZEN_N_EFL_UTIL_WINDOW(12578): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 10
04-06 05:30:59.724+0900 E/APP_CORE(12578): appcore-efl.c: _capture_and_make_file(1619) > win[5800002] widget[720] height[1280]
04-06 05:30:59.724+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 33
04-06 05:30:59.724+0900 E/APP_CORE(12578): appcore-efl.c: _capture_and_make_file(1622) > cannot a capture file for the package of [org.example.client]
04-06 05:30:59.734+0900 I/CAPI_APPFW_APPLICATION(12578): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-06 05:30:59.734+0900 I/CAPI_APPFW_APPLICATION(12578): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
04-06 05:30:59.734+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:30:59.734+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(3)
04-06 05:30:59.734+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:30:59.734+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 05:30:59.734+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(858)
04-06 05:30:59.734+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: fg
04-06 05:30:59.774+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(0)
04-06 05:30:59.814+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: RESUME State: PAUSED
04-06 05:30:59.814+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 05:30:59.814+0900 E/cluster-home(  858): homescreen.cpp: OnResume(233) >  app resume
04-06 05:30:59.814+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:30:59.814+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 05:30:59.814+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
04-06 05:30:59.824+0900 E/PKGMGR_SERVER(13176): pkgmgr-server.c: sighandler(417) > child NORMAL exit [13179]
04-06 05:30:59.834+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-06 05:30:59.854+0900 I/Tizen::System( 1231): (259) > Active app [com.samsun], current [org.exampl] 
04-06 05:30:59.854+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 05:30:59.854+0900 I/TIZEN_N_SOUND_MANAGER(  912): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-06 05:30:59.854+0900 E/TIZEN_N_SOUND_MANAGER(  912): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 05:30:59.864+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 05:30:59.864+0900 I/TIZEN_N_SOUND_MANAGER(  912): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-06 05:30:59.864+0900 E/TIZEN_N_SOUND_MANAGER(  912): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 05:30:59.864+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 05:30:59.874+0900 E/weather-widget( 1448): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-06 05:30:59.904+0900 E/weather-common( 1448): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-06 05:30:59.924+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_create(409) > New handle created[0xb7b730a8]
04-06 05:30:59.924+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_get_type(463) > Connected Network = 2
04-06 05:30:59.924+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_destroy(427) > Destroy handle: 0xb7b730a8
04-06 05:30:59.934+0900 E/weather-common( 1448): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-06 05:30:59.934+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-06 05:30:59.934+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-06 05:30:59.934+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-06 05:30:59.934+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: com.samsung.weather-m-widget, status: fg
04-06 05:31:00.235+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(195) > ""
04-06 05:31:00.245+0900 E/UXT     (  661): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 5:31
04-06 05:31:00.245+0900 I/INDICATOR(  661): clock.c: getTimeFormatted(176) > "time format : 오전 5:31"
04-06 05:31:00.245+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 5:31"
04-06 05:31:00.245+0900 W/INDICATOR(  661): clock.c: indicator_clock_changed_cb(272) > 
04-06 05:31:00.245+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146245040 Time: <font_size=31> </font_size> <font_size=31> 오전 5:31</font_size></font>"
04-06 05:31:01.596+0900 E/VCONF   (12578): vconf-kdb.c: _vconf_kdb_del_notify(468) > Error: inotify_add_watch() [/opt/var/kdb/db/ise+keysound]: Permission denied
04-06 05:31:01.596+0900 E/VCONF   (12578): vconf.c: vconf_ignore_key_changed(3218) > vconf_ignore_key_changed() failed: key(db/ise/keysound)
04-06 05:31:01.626+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 12578 pgid = 12578
04-06 05:31:01.626+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(143) > dead_pid(12578)
04-06 05:31:01.636+0900 E/PKGMGR_SERVER(13176): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-06 05:31:01.636+0900 E/PKGMGR_SERVER(13176): pkgmgr-server.c: main(2471) > package manager server terminated.
04-06 05:31:01.696+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-06 05:31:01.696+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-06 05:31:01.696+0900 E/AUL_PAD ( 1673): launchpad.c: main(698) > error reading sigchld info
04-06 05:31:01.696+0900 I/ESD     (  893): esd_main.c: __esd_app_dead_handler(1773) > pid: 12578
04-06 05:31:01.696+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 12578
04-06 05:31:01.706+0900 I/Tizen::App( 1231): (243) > App[org.example.client] pid[12578] terminate event is forwarded
04-06 05:31:01.706+0900 I/Tizen::System( 1231): (256) > osp.accessorymanager.service provider is found.
04-06 05:31:01.706+0900 I/Tizen::System( 1231): (196) > Accessory Owner is removed [org.example.client, 12578, ]
04-06 05:31:01.706+0900 I/Tizen::System( 1231): (256) > osp.system.service provider is found.
04-06 05:31:01.706+0900 I/Tizen::App( 1231): (506) > TerminatedApp(org.example.client)
04-06 05:31:01.706+0900 I/Tizen::App( 1231): (512) > Not registered pid(12578)
04-06 05:31:01.706+0900 I/Tizen::System( 1231): (246) > Terminated app [org.example.client]
04-06 05:31:01.706+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 05:31:01.716+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 05:31:01.716+0900 I/Tizen::App( 1231): (782) > Finished invoking application event listener for org.example.client, 12578.
04-06 05:31:03.758+0900 E/PKGMGR  (13269): pkgmgr.c: pkgmgr_client_reinstall(2020) > reinstall pkg start.
04-06 05:31:03.838+0900 E/PKGMGR_SERVER(13271): pkgmgr-server.c: main(2414) > package manager server start
04-06 05:31:03.888+0900 E/PKGMGR_SERVER(13271): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.client]
04-06 05:31:03.898+0900 E/PKGMGR_SERVER(13271): pm-mdm.c: _get_package_info_from_file(116) > [0;31m[_get_package_info_from_file(): 116](ret < 0) access() failed. path: org.example.client errno: 2 (No such file or directory)[0;m
04-06 05:31:03.908+0900 E/PKGMGR  (13269): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[132690002]
04-06 05:31:04.058+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: update
04-06 05:31:04.058+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [start], Value = [update], install = [1]
04-06 05:31:04.068+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:04.068+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:04.068+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:04.068+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:04.068+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:04.068+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:04.068+0900 W/AUL_AMD (  610): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
04-06 05:31:04.079+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-06 05:31:04.079+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [30]
04-06 05:31:04.079+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
04-06 05:31:04.079+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:04.079+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:04.079+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:04.079+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:04.079+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:04.079+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:04.239+0900 W/CERT_SVC_VCORE(13274): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-06 05:31:04.319+0900 E/rpm-installer(13274): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
04-06 05:31:04.319+0900 E/rpm-installer(13274): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
04-06 05:31:04.379+0900 E/PKGMGR_PARSER(13274): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
04-06 05:31:04.399+0900 I/PRIVACY-MANAGER-CLIENT(13274): SocketClient.cpp: SocketClient(37) > Client created
04-06 05:31:04.399+0900 I/PRIVACY-MANAGER-CLIENT(13274): SocketClient.cpp: connect(62) > Client connected
04-06 05:31:04.399+0900 I/PRIVACY-MANAGER-SERVER(  915): SocketService.cpp: mainloop(230) > Got incoming connection
04-06 05:31:04.399+0900 I/PRIVACY-MANAGER-CLIENT(13274): SocketClient.cpp: disconnect(72) > Client disconnected
04-06 05:31:04.399+0900 E/PKGMGR_CERT(13274): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
04-06 05:31:04.409+0900 E/PKGMGR_CERT(13274): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
04-06 05:31:04.409+0900 E/PKGMGR_CERT(13274): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
04-06 05:31:04.439+0900 E/rpm-installer(13274): coretpk-installer.c: _coretpk_installer_package_reinstall(6347) > _coretpk_installer_package_reinstall(org.example.client) failed.
04-06 05:31:04.449+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: fail
04-06 05:31:04.449+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [end], Value = [fail], install = [1]
04-06 05:31:04.449+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:04.449+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:04.449+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:04.449+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:04.449+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:04.449+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:04.449+0900 E/ESD     (  893): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
04-06 05:31:04.459+0900 W/AUL_AMD (  610): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
04-06 05:31:04.459+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.client",~) returned -1
04-06 05:31:04.459+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
04-06 05:31:04.719+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-06 05:31:04.719+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-06 05:31:06.120+0900 E/PKGMGR_SERVER(13271): pkgmgr-server.c: sighandler(417) > child NORMAL exit [13274]
04-06 05:31:06.641+0900 E/PKGMGR_SERVER(13271): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-06 05:31:06.641+0900 E/PKGMGR_SERVER(13271): pkgmgr-server.c: main(2471) > package manager server terminated.
04-06 05:31:07.322+0900 E/PKGMGR  (13323): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
04-06 05:31:07.402+0900 E/PKGMGR_SERVER(13325): pkgmgr-server.c: main(2414) > package manager server start
04-06 05:31:07.452+0900 E/PKGMGR_SERVER(13325): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk]
04-06 05:31:07.462+0900 E/PKGMGR_INFO(13325): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] not found in DB
04-06 05:31:07.462+0900 E/rpm-installer(13325): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
04-06 05:31:07.472+0900 E/PKGMGR_SERVER(13325): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
04-06 05:31:07.472+0900 E/PKGMGR  (13323): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[133230002]
04-06 05:31:07.602+0900 E/PKGMGR_INSTALLER(13328): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
04-06 05:31:07.602+0900 E/rpm-installer(13328): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] is tpk package.
04-06 05:31:07.612+0900 E/rpm-installer(13328): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
04-06 05:31:07.612+0900 E/rpm-installer(13328): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
04-06 05:31:07.612+0900 E/rpm-installer(13328): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-06 05:31:07.612+0900 E/rpm-installer(13328): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
04-06 05:31:07.612+0900 E/rpm-installer(13328): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-06 05:31:07.682+0900 W/CERT_SVC_VCORE(13328): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-06 05:31:07.732+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: install
04-06 05:31:07.732+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [start], Value = [install], install = [1]
04-06 05:31:07.742+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:07.742+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:07.742+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:07.742+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:07.742+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:07.742+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:07.752+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-06 05:31:07.752+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [30]
04-06 05:31:07.752+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
04-06 05:31:07.752+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:07.752+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:07.752+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:07.752+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:07.752+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:07.752+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:07.972+0900 E/rpm-installer(13328): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
04-06 05:31:07.972+0900 E/rpm-installer(13328): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
04-06 05:31:07.982+0900 E/rpm-installer(13328): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
04-06 05:31:07.982+0900 E/rpm-installer(13328): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-06 05:31:07.982+0900 E/rpm-installer(13328): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
04-06 05:31:07.982+0900 E/rpm-installer(13328): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
04-06 05:31:07.982+0900 E/PKGMGR_PARSER(13328): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
04-06 05:31:07.992+0900 E/PKGMGR_PARSER(13328): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
04-06 05:31:08.022+0900 I/PRIVACY-MANAGER-CLIENT(13328): SocketClient.cpp: SocketClient(37) > Client created
04-06 05:31:08.233+0900 E/PKGMGR_PARSER(13328): pkgmgr_parser.c: __check_theme(142) > theme for installation.
04-06 05:31:08.253+0900 E/PKGMGR_CERT(13328): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
04-06 05:31:08.253+0900 E/PKGMGR_CERT(13328): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 109
04-06 05:31:08.253+0900 E/PKGMGR_CERT(13328): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 109
04-06 05:31:08.253+0900 E/PKGMGR_CERT(13328): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 3
04-06 05:31:08.253+0900 E/PKGMGR_CERT(13328): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 31 4
04-06 05:31:08.253+0900 E/PKGMGR_CERT(13328): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 32 4
04-06 05:31:08.253+0900 E/PKGMGR_CERT(13328): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 3
04-06 05:31:08.263+0900 E/PKGMGR_CERT(13328): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
04-06 05:31:08.263+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
04-06 05:31:08.263+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [60]
04-06 05:31:08.263+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [1]
04-06 05:31:08.263+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:08.263+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:08.263+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:08.263+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:08.263+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:08.263+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:08.283+0900 E/rpm-installer(13328): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-06 05:31:08.303+0900 E/rpm-installer(13328): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
04-06 05:31:08.303+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
04-06 05:31:08.303+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [100]
04-06 05:31:08.303+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [1]
04-06 05:31:08.303+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:08.303+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:08.303+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:08.303+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:08.303+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:08.303+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:09.634+0900 E/PKGMGR_SERVER(13325): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-06 05:31:10.154+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
04-06 05:31:10.154+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
04-06 05:31:10.154+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
04-06 05:31:10.154+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
04-06 05:31:10.154+0900 I/Tizen::App( 1231): (78) > Installation is Completed. [Package = org.example.client]
04-06 05:31:10.154+0900 I/Tizen::App( 1231): (671) > Enter. package(org.example.client), installationResult(0)
04-06 05:31:10.164+0900 I/Tizen::App( 1231): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
04-06 05:31:10.174+0900 I/Tizen::App( 1231): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
04-06 05:31:10.194+0900 I/Tizen::App( 1231): (416) > appName = [client]
04-06 05:31:10.194+0900 I/Tizen::App( 1231): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-06 05:31:10.194+0900 E/PKGMGR_INFO( 1231): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
04-06 05:31:10.194+0900 I/Tizen::App( 1231): (683) > Application count(1) in this package
04-06 05:31:10.194+0900 I/Tizen::App( 1231): (840) > Enter.
04-06 05:31:10.194+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
04-06 05:31:10.194+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:10.194+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:10.194+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:10.194+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:10.194+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:10.194+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:31:10.194+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
04-06 05:31:10.204+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
04-06 05:31:10.204+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
04-06 05:31:10.204+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
04-06 05:31:10.204+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
04-06 05:31:10.204+0900 I/Tizen::App( 1231): (703) > Exit.
04-06 05:31:10.204+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [96]
04-06 05:31:10.204+0900 I/Tizen::App( 1231): (416) > appName = [client]
04-06 05:31:10.204+0900 I/Tizen::App( 1231): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-06 05:31:10.204+0900 I/Tizen::App( 1231): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
04-06 05:31:10.204+0900 I/Tizen::App( 1231): (131) > Enter
04-06 05:31:10.214+0900 E/PKGMGR_SERVER(13325): pkgmgr-server.c: sighandler(417) > child NORMAL exit [13328]
04-06 05:31:10.214+0900 I/Tizen::App( 1231): (137) > org.example.client does not have launch condition
04-06 05:31:10.214+0900 I/Tizen::App( 1231): (883) > Exit.
04-06 05:31:10.224+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
04-06 05:31:10.224+0900 E/HOME_APPS(  858): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
04-06 05:31:10.224+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
04-06 05:31:10.224+0900 W/HOME_APPS(  858): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
04-06 05:31:10.245+0900 E/util-view(  858): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
04-06 05:31:10.265+0900 W/HOME_APPS(  858): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
04-06 05:31:11.636+0900 E/PKGMGR_SERVER(13325): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-06 05:31:11.636+0900 E/PKGMGR_SERVER(13325): pkgmgr-server.c: main(2471) > package manager server terminated.
04-06 05:31:14.399+0900 W/AUL     (13383): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-06 05:31:14.399+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
04-06 05:31:14.409+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-06 05:31:14.419+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-06 05:31:14.419+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 05:31:14.419+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 13383
04-06 05:31:14.419+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 05:31:14.429+0900 E/RESOURCED(  664): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 5
04-06 05:31:14.429+0900 E/RESOURCED(  664): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-06 05:31:14.429+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
04-06 05:31:14.429+0900 W/AUL_PAD ( 1673): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-06 05:31:14.429+0900 W/AUL_PAD ( 1673): launchpad.c: __send_result_to_caller(267) > Check app launching
04-06 05:31:14.449+0900 I/abc     (13129): abc
04-06 05:31:14.449+0900 I/CAPI_APPFW_APPLICATION(13129): app_main.c: ui_app_main(789) > app_efl_main
04-06 05:31:14.449+0900 I/CAPI_APPFW_APPLICATION(13129): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-06 05:31:14.479+0900 E/TBM     (13129): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-06 05:31:14.529+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 13129, appid: org.example.client
04-06 05:31:14.529+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-06 05:31:14.529+0900 W/AUL     (13383): launch.c: app_request_to_launchpad(425) > request cmd(0) result(13129)
04-06 05:31:14.739+0900 D/basicui (13129): successed to load edc file
04-06 05:31:14.779+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:31:14.779+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:31:14.799+0900 I/Tizen::System( 1231): (259) > Active app [org.exampl], current [com.samsun] 
04-06 05:31:14.799+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 05:31:14.799+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 05:31:14.809+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 05:31:14.839+0900 I/MY_LOG  (13129): change
04-06 05:31:14.879+0900 I/APP_CORE(13129): appcore-efl.c: __do_app(514) > [APP 13129] Event: RESET State: CREATED
04-06 05:31:14.879+0900 I/CAPI_APPFW_APPLICATION(13129): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-06 05:31:14.889+0900 E/EFL     (13129): edje<13129> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:31:14.889+0900 E/EFL     (13129): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:31:14.899+0900 E/EFL     (13129): edje<13129> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:31:14.899+0900 E/EFL     (13129): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:31:14.899+0900 E/EFL     (13129): edje<13129> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:31:14.899+0900 E/EFL     (13129): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:31:14.909+0900 W/APP_CORE(13129): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6400002
04-06 05:31:14.909+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
04-06 05:31:15.019+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: PAUSE State: RUNNING
04-06 05:31:15.019+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-06 05:31:15.019+0900 I/APP_CORE(13129): appcore-efl.c: __do_app(514) > [APP 13129] Event: RESUME State: CREATED
04-06 05:31:15.019+0900 E/cluster-home(  858): homescreen.cpp: OnPause(260) >  app pause
04-06 05:31:15.019+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(4)
04-06 05:31:15.019+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(858)
04-06 05:31:15.019+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: bg
04-06 05:31:15.029+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(13129) status(3)
04-06 05:31:15.029+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:31:15.029+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 05:31:15.029+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(13129)
04-06 05:31:15.029+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 13129, appid: org.example.client, status: fg
04-06 05:31:15.039+0900 I/APP_CORE(13129): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-06 05:31:15.039+0900 I/APP_CORE(13129): appcore-efl.c: __do_app(625) > [APP 13129] Initial Launching, call the resume_cb
04-06 05:31:15.039+0900 I/CAPI_APPFW_APPLICATION(13129): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 05:31:15.039+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-06 05:31:15.039+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-06 05:31:15.039+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: com.samsung.weather-m-widget, status: bg
04-06 05:31:15.390+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(13129) status(0)
04-06 05:31:15.580+0900 I/Tizen::App( 1231): (499) > LaunchedApp(org.example.client)
04-06 05:31:15.580+0900 I/Tizen::App( 1231): (733) > Finished invoking application event listener for org.example.client, 13129.
04-06 05:31:15.590+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2255
04-06 05:31:16.350+0900 I/UXT     (13396): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-06 05:31:17.592+0900 E/EFL     (13129): ecore_x<13129> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=222196954
04-06 05:31:17.592+0900 I/MY_LOG  (13129): Button pressed
04-06 05:31:17.692+0900 E/EFL     (13129): ecore_x<13129> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=222197053
04-06 05:31:17.692+0900 E/VCONF   (13129): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-06 05:31:17.692+0900 E/VCONF   (13129): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-06 05:31:17.692+0900 E/VCONF   (13129): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-06 05:31:17.692+0900 E/VCONF   (13129): vconf.c: vconf_get_bool(2729) > vconf_get_bool(13129) : db/ise/keysound error
04-06 05:31:17.692+0900 E/VCONF   (13129): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-06 05:31:17.692+0900 E/VCONF   (13129): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-06 05:31:17.752+0900 I/MY_LOG  (13129): Button unpressed
04-06 05:31:17.932+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:31:17.952+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 13129 pgid = 13129
04-06 05:31:17.952+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(143) > dead_pid(13129)
04-06 05:31:17.952+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(3)
04-06 05:31:17.962+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:31:17.962+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 05:31:17.962+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(858)
04-06 05:31:17.962+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: fg
04-06 05:31:17.962+0900 W/CRASH_MANAGER(13401): worker.c: worker_job(1199) > 0613129636c69149142427
