S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 2815
Date: 2017-04-03 03:22:29+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 2815, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000aff
r2   = 0x00000006, r3   = 0xb404d4c0
r4   = 0x00000002, r5   = 0xb404d000
r6   = 0xb6a1b09c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0x2a02faf0
r10  = 0xbefff8a0, fp   = 0x00000004
ip   = 0x00000000, sp   = 0xbefff424
lr   = 0xb6911f18, pc   = 0xb6910b84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:    237808 KB
Buffers:     34068 KB
Cached:     311840 KB
VmPeak:      80112 KB
VmSize:      80108 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16276 KB
VmRSS:       16276 KB
VmData:      21316 KB
VmStk:         136 KB
VmExe:          72 KB
VmLib:       28492 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 2815 TID = 2815
2815 2826 2834 

Maps Information
2a000000 2a012000 r-xp /opt/usr/apps/org.example.client/bin/client
2a022000 2a223000 rw-p [heap]
b2599000 b25a1000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b25b2000 b25bf000 r-xp /usr/lib/libmdm-common.so.1.0.98
b25d0000 b2611000 r-xp /usr/lib/libmdm.so.1.2.12
b2621000 b2629000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b2638000 b2648000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b2669000 b26c9000 r-xp /usr/lib/libasound.so.2.0.0
b26db000 b26de000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b26ee000 b26f1000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b2701000 b2706000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b2716000 b2721000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b2735000 b273a000 r-xp /usr/lib/libmmfsession.so.0.0.1
b274a000 b2765000 r-xp /usr/lib/libmmfsound.so.0.1.0
b2775000 b277c000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b278c000 b2796000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b27a6000 b27a8000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b27b8000 b27b9000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b27c9000 b27d1000 r-xp /usr/lib/libfeedback.so.0.1.4
b27f9000 b27fa000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b280a000 b281e000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b297a000 b297b000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b298b000 b298e000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b299f000 b29a0000 r-xp /usr/lib/libxshmfence.so.1.0.0
b29b0000 b29b2000 r-xp /usr/lib/libxcb-present.so.0.0.0
b29c2000 b29c4000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b29d4000 b29d5000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b29e7000 b29ed000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b29fd000 b2a0d000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2a1d000 b2a29000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b2a3b000 b323a000 rw-p [stack:2834]
b356b000 b3575000 r-xp /lib/libnss_files-2.20-2014.11.so
b3586000 b358f000 r-xp /lib/libnss_nis-2.20-2014.11.so
b35a0000 b35b1000 r-xp /lib/libnsl-2.20-2014.11.so
b35c4000 b35ca000 r-xp /lib/libnss_compat-2.20-2014.11.so
b35db000 b35df000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b35f0000 b36d3000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b370a000 b3732000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b3744000 b3f43000 rw-p [stack:2826]
b3f43000 b3f45000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3f55000 b4033000 r-xp /usr/lib/libCOREGL.so.4.0
b4052000 b4055000 r-xp /lib/libattr.so.1.1.0
b4066000 b406d000 r-xp /lib/libcrypt-2.20-2014.11.so
b40a5000 b40a8000 r-xp /lib/libcap.so.2.21
b40b8000 b40ba000 r-xp /usr/lib/libiri.so
b40ca000 b40ea000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b40ec000 b40ef000 r-xp /usr/lib/libuuid.so.1.3.0
b40ff000 b4116000 r-xp /usr/lib/libblkid.so.1.1.0
b4127000 b4150000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b4161000 b41a8000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b41b9000 b41bf000 r-xp /usr/lib/libjson-c.so.2.0.1
b41d1000 b41d5000 r-xp /usr/lib/libogg.so.0.7.1
b41e5000 b4207000 r-xp /usr/lib/libvorbis.so.0.4.3
b4217000 b42fb000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4317000 b4322000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4332000 b4335000 r-xp /usr/lib/libEGL.so.1.4
b4346000 b434c000 r-xp /usr/lib/libxcb-render.so.0.0.0
b435c000 b435e000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b436e000 b437b000 r-xp /usr/lib/libGLESv2.so.2.0
b438c000 b43a4000 r-xp /usr/lib/libmount.so.1.1.0
b43b6000 b43b8000 r-xp /usr/lib/libXau.so.6.0.0
b43c8000 b43fe000 r-xp /usr/lib/libpulse.so.0.16.2
b440f000 b4452000 r-xp /usr/lib/libsndfile.so.1.0.25
b4467000 b44e1000 r-xp /usr/lib/libgcrypt.so.20.0.3
b44f6000 b44fd000 r-xp /usr/lib/libsensord-share.so
b450e000 b4570000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4585000 b4588000 r-xp /usr/lib/libXv.so.1.0.0
b4598000 b459d000 r-xp /usr/lib/libutilX.so.1.1.0
b45ad000 b45b2000 r-xp /usr/lib/libffi.so.6.0.2
b45c2000 b45d3000 r-xp /lib/libresolv-2.20-2014.11.so
b45e8000 b45ea000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b45fa000 b460f000 r-xp /lib/libexpat.so.1.5.2
b4621000 b46df000 r-xp /usr/lib/libcairo.so.2.11200.14
b46f2000 b46fa000 r-xp /usr/lib/libdrm.so.2.4.0
b470b000 b470e000 r-xp /usr/lib/libdri2.so.0.0.0
b471e000 b476c000 r-xp /usr/lib/libssl.so.1.0.0
b4781000 b478d000 r-xp /usr/lib/libeeze.so.1.13.0
b479d000 b47a6000 r-xp /usr/lib/libethumb.so.1.13.0
b47b7000 b47ba000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b47ca000 b4981000 r-xp /usr/lib/libcrypto.so.1.0.0
b576b000 b5774000 r-xp /usr/lib/libXi.so.6.1.0
b5785000 b5787000 r-xp /usr/lib/libXgesture.so.7.0.0
b5797000 b579b000 r-xp /usr/lib/libXtst.so.6.1.0
b57ab000 b57b1000 r-xp /usr/lib/libXrender.so.1.3.0
b57c1000 b57c7000 r-xp /usr/lib/libXrandr.so.2.2.0
b57d7000 b57d9000 r-xp /usr/lib/libXinerama.so.1.0.0
b57e9000 b57ec000 r-xp /usr/lib/libXfixes.so.3.1.0
b57fd000 b5808000 r-xp /usr/lib/libXext.so.6.4.0
b5818000 b581a000 r-xp /usr/lib/libXdamage.so.1.1.0
b582a000 b582c000 r-xp /usr/lib/libXcomposite.so.1.0.0
b583c000 b5843000 r-xp /usr/lib/libXcursor.so.1.0.2
b5853000 b586b000 r-xp /usr/lib/libudev.so.1.6.0
b586e000 b5882000 r-xp /usr/lib/libxcb.so.1.1.0
b5892000 b5894000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b58a4000 b58ab000 r-xp /usr/lib/libembryo.so.1.13.0
b58bb000 b58c5000 r-xp /usr/lib/libecore_audio.so.1.13.0
b58d6000 b58ee000 r-xp /lib/libz.so.1.2.8
b58ff000 b593b000 r-xp /usr/lib/libsystemd.so.0.4.0
b593d000 b5955000 r-xp /usr/lib/libsensor.so.1.1.0
b5966000 b596d000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b597d000 b5984000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b5996000 b5998000 r-xp /usr/lib/libappsvc.so.0.1.0
b59a8000 b59ab000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b59bb000 b59d4000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b59e5000 b5a1c000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b5a2d000 b5b18000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b5b2b000 b5ba4000 r-xp /usr/lib/libsqlite3.so.0.8.6
b5bb6000 b5bc0000 r-xp /usr/lib/libvconf.so.0.2.45
b5bd0000 b5bd2000 r-xp /usr/lib/libvasum.so.0.3.1
b5be2000 b5be6000 r-xp /usr/lib/libsmack.so.1.0.0
b5bf6000 b5bfb000 r-xp /usr/lib/libxdgmime.so.1.1.0
b5c0c000 b5c36000 r-xp /usr/lib/libdbus-1.so.3.8.12
b5c47000 b5c5e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b5c6f000 b5c72000 r-xp /usr/lib/libbundle.so.0.1.22
b5c82000 b5c9a000 r-xp /usr/lib/libpng12.so.0.50.0
b5cab000 b5cce000 r-xp /usr/lib/libjpeg.so.8.0.2
b5cef000 b5d03000 r-xp /usr/lib/libector.so.1.13.0
b5d14000 b5d2c000 r-xp /usr/lib/liblua-5.1.so
b5d3d000 b5d94000 r-xp /usr/lib/libfreetype.so.6.11.3
b5da8000 b5dd0000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5de1000 b5df4000 r-xp /usr/lib/libfribidi.so.0.3.1
b5e05000 b5e3f000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5e50000 b5e5e000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5e6e000 b5e76000 r-xp /usr/lib/libtbm.so.1.0.0
b5e86000 b5e93000 r-xp /usr/lib/libeio.so.1.13.0
b5ea3000 b5ea5000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5eb5000 b5eba000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5eca000 b5ee1000 r-xp /usr/lib/libefreet.so.1.13.0
b5ef3000 b5f13000 r-xp /usr/lib/libeldbus.so.1.13.0
b5f23000 b5f43000 r-xp /usr/lib/libecore_con.so.1.13.0
b5f45000 b5f4b000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5f5b000 b5f6c000 r-xp /usr/lib/libemotion.so.1.13.0
b5f7d000 b5f84000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f94000 b5fa6000 r-xp /usr/lib/libecore_input.so.1.13.0
b5fb7000 b5fbc000 r-xp /usr/lib/libecore_file.so.1.13.0
b5fcc000 b5fe5000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5ff5000 b6012000 r-xp /usr/lib/libeet.so.1.13.0
b602b000 b603b000 r-xp /usr/lib/libefl.so.1.13.0
b604c000 b6131000 r-xp /usr/lib/libicuuc.so.51.1
b614e000 b628e000 r-xp /usr/lib/libicui18n.so.51.1
b62a5000 b62dd000 r-xp /usr/lib/libecore_x.so.1.13.0
b62ef000 b62f1000 r-xp /usr/lib/libttrace.so.1.1
b6301000 b63e3000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b63f4000 b64d6000 r-xp /usr/lib/libX11.so.6.3.0
b64e9000 b64f8000 r-xp /usr/lib/libeo.so.1.13.0
b6509000 b658c000 r-xp /usr/lib/libedje.so.1.13.0
b659f000 b65bd000 r-xp /usr/lib/libecore.so.1.13.0
b65dd000 b66b2000 r-xp /usr/lib/libxml2.so.2.9.2
b66c7000 b66ca000 r-xp /usr/lib/libiniparser.so.0
b66da000 b6722000 r-xp /usr/lib/libeina.so.1.13.0
b6733000 b6738000 r-xp /usr/lib/libappcore-common.so.1.1
b6748000 b674d000 r-xp /usr/lib/libappcore-efl.so.1.1
b675d000 b6762000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b6773000 b6799000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b67a9000 b67c1000 r-xp /usr/lib/libaul.so.0.1.0
b67d3000 b683e000 r-xp /lib/libm-2.20-2014.11.so
b684f000 b6855000 r-xp /lib/librt-2.20-2014.11.so
b6866000 b6868000 r-xp /lib/libdl-2.20-2014.11.so
b6879000 b6886000 r-xp /usr/lib/libunwind.so.8.0.1
b68bc000 b68d5000 r-xp /lib/libgcc_s-4.9.so.1
b68e5000 b6a09000 r-xp /lib/libc-2.20-2014.11.so
b6a1e000 b6ab9000 r-xp /usr/lib/libstdc++.so.6.0.20
b6ad5000 b6c5c000 r-xp /usr/lib/libevas.so.1.13.0
b6c91000 b6ec5000 r-xp /usr/lib/libelementary.so.1.13.0
b6ef4000 b6efb000 r-xp /usr/lib/libefl-extension.so.0.1.0
b6f0c000 b6f0e000 r-xp /usr/lib/libdlog.so.0.0.0
b6f1e000 b6f23000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6f33000 b6f37000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b6f48000 b6f4a000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b6f5b000 b6f6f000 r-xp /lib/libpthread-2.20-2014.11.so
b6f9b000 b6fa8000 r-xp /usr/lib/liblptcp.so
b6fba000 b6fbe000 r-xp /usr/lib/libsys-assert.so
b6fcf000 b6fef000 r-xp /lib/ld-2.20-2014.11.so
befdf000 bf000000 rw-p [stack]
End of Maps Information

Callstack Information (PID:2815)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb6910b84) [/lib/libc.so.6] + 0x2bb84
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
ld NORMAL exit [2325]
04-03 03:20:49.998+0900 E/PKGMGR_SERVER( 2322): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-03 03:20:49.998+0900 E/PKGMGR_SERVER( 2322): pkgmgr-server.c: main(2471) > package manager server terminated.
04-03 03:20:52.160+0900 E/PKGMGR  ( 2411): pkgmgr.c: pkgmgr_client_reinstall(2020) > reinstall pkg start.
04-03 03:20:52.240+0900 E/PKGMGR_SERVER( 2413): pkgmgr-server.c: main(2414) > package manager server start
04-03 03:20:52.290+0900 E/PKGMGR_SERVER( 2413): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.client]
04-03 03:20:52.300+0900 E/PKGMGR_SERVER( 2413): pm-mdm.c: _get_package_info_from_file(116) > [0;31m[_get_package_info_from_file(): 116](ret < 0) access() failed. path: org.example.client errno: 2 (No such file or directory)[0;m
04-03 03:20:52.300+0900 E/PKGMGR  ( 2411): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[24110002]
04-03 03:20:52.450+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: update
04-03 03:20:52.450+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [start], Value = [update], install = [1]
04-03 03:20:52.450+0900 W/AUL_AMD (  610): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
04-03 03:20:52.460+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-03 03:20:52.460+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [30]
04-03 03:20:52.460+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
04-03 03:20:52.600+0900 W/CERT_SVC_VCORE( 2416): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-03 03:20:52.670+0900 E/rpm-installer( 2416): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
04-03 03:20:52.670+0900 E/rpm-installer( 2416): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
04-03 03:20:52.730+0900 E/PKGMGR_PARSER( 2416): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
04-03 03:20:52.740+0900 I/PRIVACY-MANAGER-CLIENT( 2416): SocketClient.cpp: SocketClient(37) > Client created
04-03 03:20:52.750+0900 I/PRIVACY-MANAGER-CLIENT( 2416): SocketClient.cpp: connect(62) > Client connected
04-03 03:20:52.750+0900 I/PRIVACY-MANAGER-SERVER(  915): SocketService.cpp: mainloop(230) > Got incoming connection
04-03 03:20:52.750+0900 I/PRIVACY-MANAGER-CLIENT( 2416): SocketClient.cpp: disconnect(72) > Client disconnected
04-03 03:20:52.750+0900 E/PKGMGR_CERT( 2416): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
04-03 03:20:52.760+0900 E/PKGMGR_CERT( 2416): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
04-03 03:20:52.760+0900 E/PKGMGR_CERT( 2416): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
04-03 03:20:52.801+0900 E/rpm-installer( 2416): coretpk-installer.c: _coretpk_installer_package_reinstall(6347) > _coretpk_installer_package_reinstall(org.example.client) failed.
04-03 03:20:52.801+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: fail
04-03 03:20:52.801+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [end], Value = [fail], install = [96]
04-03 03:20:52.801+0900 E/ESD     (  893): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
04-03 03:20:52.811+0900 W/AUL_AMD (  610): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
04-03 03:20:52.811+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.client",~) returned -1
04-03 03:20:52.811+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
04-03 03:20:54.442+0900 E/PKGMGR_SERVER( 2413): pkgmgr-server.c: sighandler(417) > child NORMAL exit [2416]
04-03 03:20:55.003+0900 E/PKGMGR_SERVER( 2413): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-03 03:20:55.003+0900 E/PKGMGR_SERVER( 2413): pkgmgr-server.c: main(2471) > package manager server terminated.
04-03 03:20:55.573+0900 E/PKGMGR  ( 2465): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
04-03 03:20:55.663+0900 E/PKGMGR_SERVER( 2467): pkgmgr-server.c: main(2414) > package manager server start
04-03 03:20:55.713+0900 E/PKGMGR_SERVER( 2467): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk]
04-03 03:20:55.723+0900 E/PKGMGR_INFO( 2467): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] not found in DB
04-03 03:20:55.723+0900 E/rpm-installer( 2467): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
04-03 03:20:55.733+0900 E/PKGMGR_SERVER( 2467): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
04-03 03:20:55.733+0900 E/PKGMGR  ( 2465): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[24650002]
04-03 03:20:55.854+0900 E/PKGMGR_INSTALLER( 2470): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
04-03 03:20:55.854+0900 E/rpm-installer( 2470): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] is tpk package.
04-03 03:20:55.874+0900 E/rpm-installer( 2470): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
04-03 03:20:55.874+0900 E/rpm-installer( 2470): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
04-03 03:20:55.874+0900 E/rpm-installer( 2470): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-03 03:20:55.874+0900 E/rpm-installer( 2470): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
04-03 03:20:55.874+0900 E/rpm-installer( 2470): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-03 03:20:55.934+0900 W/CERT_SVC_VCORE( 2470): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-03 03:20:55.984+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: install
04-03 03:20:55.984+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [start], Value = [install], install = [96]
04-03 03:20:55.994+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-03 03:20:55.994+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [30]
04-03 03:20:55.994+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [96]
04-03 03:20:56.174+0900 E/rpm-installer( 2470): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
04-03 03:20:56.174+0900 E/rpm-installer( 2470): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
04-03 03:20:56.174+0900 E/rpm-installer( 2470): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
04-03 03:20:56.174+0900 E/rpm-installer( 2470): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-03 03:20:56.174+0900 E/rpm-installer( 2470): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
04-03 03:20:56.174+0900 E/rpm-installer( 2470): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
04-03 03:20:56.184+0900 E/PKGMGR_PARSER( 2470): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
04-03 03:20:56.184+0900 E/PKGMGR_PARSER( 2470): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
04-03 03:20:56.224+0900 I/PRIVACY-MANAGER-CLIENT( 2470): SocketClient.cpp: SocketClient(37) > Client created
04-03 03:20:56.434+0900 E/PKGMGR_PARSER( 2470): pkgmgr_parser.c: __check_theme(142) > theme for installation.
04-03 03:20:56.454+0900 E/PKGMGR_CERT( 2470): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
04-03 03:20:56.454+0900 E/PKGMGR_CERT( 2470): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 108
04-03 03:20:56.454+0900 E/PKGMGR_CERT( 2470): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 108
04-03 03:20:56.454+0900 E/PKGMGR_CERT( 2470): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 2
04-03 03:20:56.454+0900 E/PKGMGR_CERT( 2470): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 31 3
04-03 03:20:56.454+0900 E/PKGMGR_CERT( 2470): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 32 3
04-03 03:20:56.454+0900 E/PKGMGR_CERT( 2470): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 2
04-03 03:20:56.464+0900 E/PKGMGR_CERT( 2470): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
04-03 03:20:56.464+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
04-03 03:20:56.464+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [60]
04-03 03:20:56.464+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [96]
04-03 03:20:56.484+0900 E/rpm-installer( 2470): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-03 03:20:56.504+0900 E/rpm-installer( 2470): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
04-03 03:20:56.504+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
04-03 03:20:56.504+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [100]
04-03 03:20:56.504+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [96]
04-03 03:20:58.006+0900 E/PKGMGR_SERVER( 2467): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-03 03:20:58.386+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
04-03 03:20:58.386+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
04-03 03:20:58.386+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
04-03 03:20:58.386+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
04-03 03:20:58.386+0900 I/Tizen::App( 1231): (78) > Installation is Completed. [Package = org.example.client]
04-03 03:20:58.386+0900 I/Tizen::App( 1231): (671) > Enter. package(org.example.client), installationResult(0)
04-03 03:20:58.416+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
04-03 03:20:58.416+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
04-03 03:20:58.416+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
04-03 03:20:58.416+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
04-03 03:20:58.416+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
04-03 03:20:58.446+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
04-03 03:20:58.446+0900 E/HOME_APPS(  858): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
04-03 03:20:58.446+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
04-03 03:20:58.446+0900 I/Tizen::App( 1231): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
04-03 03:20:58.446+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
04-03 03:20:58.446+0900 W/HOME_APPS(  858): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
04-03 03:20:58.466+0900 E/util-view(  858): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
04-03 03:20:58.476+0900 I/Tizen::App( 1231): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
04-03 03:20:58.486+0900 W/HOME_APPS(  858): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
04-03 03:20:58.496+0900 I/Tizen::App( 1231): (416) > appName = [client]
04-03 03:20:58.496+0900 I/Tizen::App( 1231): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-03 03:20:58.496+0900 E/PKGMGR_INFO( 1231): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
04-03 03:20:58.496+0900 I/Tizen::App( 1231): (683) > Application count(1) in this package
04-03 03:20:58.496+0900 I/Tizen::App( 1231): (840) > Enter.
04-03 03:20:58.496+0900 I/Tizen::App( 1231): (703) > Exit.
04-03 03:20:58.496+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [96]
04-03 03:20:58.506+0900 I/Tizen::App( 1231): (416) > appName = [client]
04-03 03:20:58.516+0900 I/Tizen::App( 1231): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-03 03:20:58.516+0900 I/Tizen::App( 1231): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
04-03 03:20:58.516+0900 I/Tizen::App( 1231): (131) > Enter
04-03 03:20:58.516+0900 I/Tizen::App( 1231): (137) > org.example.client does not have launch condition
04-03 03:20:58.516+0900 I/Tizen::App( 1231): (883) > Exit.
04-03 03:20:58.526+0900 E/PKGMGR_SERVER( 2467): pkgmgr-server.c: sighandler(417) > child NORMAL exit [2470]
04-03 03:20:59.998+0900 E/PKGMGR_SERVER( 2467): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-03 03:20:59.998+0900 E/PKGMGR_SERVER( 2467): pkgmgr-server.c: main(2471) > package manager server terminated.
04-03 03:21:00.068+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(195) > ""
04-03 03:21:00.068+0900 E/UXT     (  661): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 3:21
04-03 03:21:00.068+0900 I/INDICATOR(  661): clock.c: getTimeFormatted(176) > "time format : 오전 3:21"
04-03 03:21:00.068+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 3:21"
04-03 03:21:00.068+0900 W/INDICATOR(  661): clock.c: indicator_clock_changed_cb(272) > 
04-03 03:21:00.068+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146958844 Time: <font_size=31> </font_size> <font_size=31> 오전 3:21</font_size></font>"
04-03 03:21:02.720+0900 W/AUL     ( 2529): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-03 03:21:02.720+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
04-03 03:21:02.730+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-03 03:21:02.740+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-03 03:21:02.740+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-03 03:21:02.740+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 2529
04-03 03:21:02.740+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-03 03:21:02.750+0900 E/RESOURCED(  664): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
04-03 03:21:02.750+0900 E/RESOURCED(  664): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-03 03:21:02.750+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-4)
04-03 03:21:02.870+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 2531, appid: org.example.client
04-03 03:21:02.870+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-03 03:21:02.870+0900 W/AUL     ( 2529): launch.c: app_request_to_launchpad(425) > request cmd(0) result(2531)
04-03 03:21:03.871+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-03 03:21:03.871+0900 W/AUL_AMD (  610): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
04-03 03:21:07.815+0900 I/abc     ( 2531): abc
04-03 03:21:07.835+0900 I/CAPI_APPFW_APPLICATION( 2531): app_main.c: ui_app_main(789) > app_efl_main
04-03 03:21:07.875+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.client(2531)
04-03 03:21:07.875+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 2531, appid: org.example.client, status: bg
04-03 03:21:08.996+0900 I/CAPI_APPFW_APPLICATION( 2531): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-03 03:21:11.168+0900 E/TBM     ( 2531): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-03 03:21:55.001+0900 I/SERVICE_MANAGER_LIB( 2556): service-manager.c: service_manager_subscribe(895) > [34m[2556]subscribtion: org.tizen.shop_agent[0m
04-03 03:21:55.001+0900 I/SERVICE_MANAGER_LIB( 2556): service-manager.c: service_manager_subscribe(915) > [34m[2556]Policy[0m
04-03 03:21:55.001+0900 I/SERVICE_MANAGER_LIB( 2556): service-manager.c: svcman_dbus_db_open(668) > [34m[2556]Service DB Open/Create[0m
04-03 03:21:55.001+0900 I/SERVICE_MANAGER_LIB( 2556): service-manager.c: svcman_dbus_db_open(726) > [34m[2556]Service DB Open Success[0m
04-03 03:21:55.011+0900 W/SERVICE_MANAGER_LIB( 2556): service-manager.c: service_manager_subscribe(940) > [33m[2556]org.tizen.shop_agent policy subscribed[0m
04-03 03:21:55.011+0900 I/SERVICE_MANAGER_LIB( 2556): service-manager.c: svcman_dbus_db_close(733) > [34m[2556]svcman_dbus_db_close[0m
04-03 03:21:55.011+0900 I/SERVICE_MANAGER_LIB( 2556): service-manager.c: service_manager_subscribe(946) > [34m[2556]Status[0m
04-03 03:21:55.011+0900 I/SERVICE_MANAGER_LIB( 2556): service-manager.c: svcman_dbus_db_open(668) > [34m[2556]Service DB Open/Create[0m
04-03 03:21:55.011+0900 I/SERVICE_MANAGER_LIB( 2556): service-manager.c: svcman_dbus_db_open(726) > [34m[2556]Service DB Open Success[0m
04-03 03:21:55.011+0900 W/SERVICE_MANAGER_LIB( 2556): service-manager.c: service_manager_subscribe(971) > [33m[2556]org.tizen.shop_agent status subscribed[0m
04-03 03:21:55.011+0900 I/SERVICE_MANAGER_LIB( 2556): service-manager.c: svcman_dbus_db_close(733) > [34m[2556]svcman_dbus_db_close[0m
04-03 03:21:55.011+0900 I/SERVICE_MANAGER_LIB( 2556): service-manager.c: service_manager_subscribe(977) > [34m[2556]Auth[0m
04-03 03:21:55.011+0900 W/SERVICE_MANAGER_LIB( 2556): service-manager.c: svcman_dbus_db_subscribed(761) > [33m[2556]DB handle is NULL[0m
04-03 03:21:55.011+0900 I/SERVICE_MANAGER_LIB( 2556): service-manager.c: svcman_dbus_db_open(668) > [34m[2556]Service DB Open/Create[0m
04-03 03:21:55.011+0900 I/SERVICE_MANAGER_LIB( 2556): service-manager.c: svcman_dbus_db_open(726) > [34m[2556]Service DB Open Success[0m
04-03 03:21:55.011+0900 I/SERVICE_MANAGER_LIB( 2556): service-manager.c: svcman_dbus_db_close(733) > [34m[2556]svcman_dbus_db_close[0m
04-03 03:21:55.011+0900 I/SERVICE_MANAGER_LIB( 2556): service-manager.c: service_manager_subscribe(1005) > [34m[2556]Active[0m
04-03 03:21:55.011+0900 W/SERVICE_MANAGER_LIB( 2556): service-manager.c: svcman_dbus_db_subscribed(761) > [33m[2556]DB handle is NULL[0m
04-03 03:21:55.011+0900 I/SERVICE_MANAGER_LIB( 2556): service-manager.c: svcman_dbus_db_open(668) > [34m[2556]Service DB Open/Create[0m
04-03 03:21:55.011+0900 I/SERVICE_MANAGER_LIB( 2556): service-manager.c: svcman_dbus_db_open(726) > [34m[2556]Service DB Open Success[0m
04-03 03:21:55.021+0900 I/SERVICE_MANAGER_LIB( 2556): service-manager.c: svcman_dbus_db_close(733) > [34m[2556]svcman_dbus_db_close[0m
04-03 03:21:55.021+0900 I/SERVICE_MANAGER_LIB( 2556): service-manager.c: service_manager_subscribe(1032) > [34m[2556]subscribtion done[0m
04-03 03:21:55.021+0900 I/SERVICE_MANAGER_LIB( 2556): service-manager.c: service_manager_register_listener2(468) > [34m[2556]service_manager_register_listener2[0m
04-03 03:21:55.051+0900 I/SERVICE_MANAGER_LIB( 2556): service-manager.c: service_manager_register_object(494) > [34m[2556]service_manager_register_object[0m
04-03 03:21:55.091+0900 I/SERVICE_ADAPTOR_CLIENT( 2556): service_adaptor_client.c: service_adaptor_connect(823) > Service Adaptor Client Connect (Push Debug version)
04-03 03:21:55.091+0900 I/SERVICE_ADAPTOR_CLIENT( 2556): service_adaptor_client.c: service_adaptor_connect(826) > [34m[2565]API Called <service_adaptor_connect>[0m
04-03 03:21:55.111+0900 I/SERVICE_ADAPTOR_CLIENT( 2556): service_adaptor_client.c: service_adaptor_connect(867) > [34m[2565]Proxy creation success[0m
04-03 03:21:55.111+0900 I/SERVICE_ADAPTOR( 1134): dbus-service-adaptor.c: service_adaptor_method_call(101) > [34m[2567]Client Connected Successful[0m
04-03 03:21:55.111+0900 I/SERVICE_ADAPTOR_CLIENT( 2556): service_adaptor_client.c: service_adaptor_connect(897) > [34m[2565]Connects success handle (0xb71db2b0) instance (0xb1000600)[0m
04-03 03:21:55.111+0900 I/SERVICE_ADAPTOR_CLIENT( 2556): service_adaptor_client.c: service_adaptor_external_request(1062) > [34m[2565]API Called <service_adaptor_external_request>[0m
04-03 03:21:55.121+0900 E/SERVICE_ADAPTOR( 1134): service-adaptor.c: service_adaptor_get_service_context(137) > [31m[2567]Invalid argument[0m
04-03 03:21:55.121+0900 I/SERVICE_ADAPTOR( 1134): dbus-auth-adaptor.c: auth_external_method_call(684) > [34m[2567]Try API without context((null))[0m
04-03 03:21:55.121+0900 I/AUTH_ADAPTOR( 1134): auth-adaptor.c: auth_adaptor_plugin_ref(629) > [34m[2567]plugin name: com.samsung.coreapps, ref_counter: 3[0m
04-03 03:21:55.121+0900 I/AUTH_ADAPTOR( 1134): auth-adaptor.c: auth_adaptor_external_request(1573) > [34m[2567][ENTER] plugin API call -)) -)) -)) -)) -)) -)) -)) -)) -)) -))[0m
04-03 03:21:55.121+0900 I/AUTH_PLUGIN_ESU( 1134): auth-plugin-esu-internal.c: esu_internal_get_imsi_sync_wrapper(1668) > [34m[2568]esu_check_account_exist imsi : (null), msisdn : (null)[0m
04-03 03:21:55.121+0900 E/AUTH_PLUGIN_ESU( 1134): auth-plugin-esu-internal.c: esu_internal_get_imsi_sync_wrapper(1673) > [31m[2568]Get imsi send request failed:(-214)[0m
04-03 03:21:55.121+0900 E/AUTH_PLUGIN_ESU( 1134): auth-plugin-esu.c: plugin_esu_get_imsi(1112) > [31m[2567]ERROR code 201[0m
04-03 03:21:55.121+0900 E/AUTH_PLUGIN_ESU( 1134): auth-plugin-esu.c: plugin_esu_get_imsi(1113) > [31m[2567]ERROR MSG ESU is not ready[0m
04-03 03:21:55.121+0900 I/AUTH_ADAPTOR( 1134): auth-adaptor.c: auth_adaptor_external_request(1577) > [34m[2567][EXIT] plugin API called (16) ((- ((- ((- ((- ((- ((- ((- ((- ((- ((-[0m
04-03 03:21:55.121+0900 E/AUTH_ADAPTOR( 1134): auth-adaptor.c: auth_adaptor_external_request(1577) > [31m[2567]plugin issued error (201) (ESU is not ready)[0m
04-03 03:21:55.131+0900 E/SERVICE_ADAPTOR_CLIENT( 2556): service_adaptor_client.c: service_adaptor_external_request(1095) > [31m[2565]Error occured (201)([PLUGIN_ERROR] URI(com.samsung.coreapps), MSG(ESU is not ready))[0m
04-03 03:21:55.131+0900 I/SERVICE_ADAPTOR_CLIENT( 2556): service_adaptor_client.c: service_adaptor_external_request(1103) > [34m[2565]API End <service_adaptor_external_request>: -49479678[0m
04-03 03:21:55.131+0900 I/SERVICE_ADAPTOR_CLIENT( 2556): service_adaptor_client.c: service_adaptor_set_imsi(979) > [34m[2565]API Called <service_adaptor_set_imsi>[0m
04-03 03:21:55.131+0900 I/SERVICE_ADAPTOR_CLIENT( 2556): service_adaptor_client.c: service_adaptor_set_imsi(996) > [34m[2565]API End <service_adaptor_set_imsi> : 0[0m
04-03 03:21:55.131+0900 I/SERVICE_ADAPTOR_CLIENT( 2556): service_adaptor_client_auth.c: service_adaptor_get_auth_plugin(46) > [34m[2565]API Called <service_adaptor_get_auth_plugin>[0m
04-03 03:21:55.131+0900 I/AUTH_ADAPTOR( 1134): auth-adaptor.c: auth_adaptor_plugin_ref(629) > [34m[2567]plugin name: com.samsung.coreapps, ref_counter: 4[0m
04-03 03:21:55.131+0900 I/AUTH_ADAPTOR( 1134): auth-adaptor.c: auth_adaptor_create_plugin_context(816) > [34m[2567][ENTER] plugin API call -)) -)) -)) -)) -)) -)) -)) -)) -)) -))[0m
04-03 03:21:55.141+0900 I/AUTH_PLUGIN_ESU( 1134): auth-plugin-esu-internal.c: esu_internal_check_version(1970) > [34m[2567]Easy Signup version: v0.1.1[0m
04-03 03:21:55.141+0900 I/AUTH_ADAPTOR( 1134): auth-adaptor.c: auth_adaptor_create_plugin_context(818) > [34m[2567][EXIT] plugin API called ((- ((- ((- ((- ((- ((- ((- ((- ((- ((-[0m
04-03 03:21:55.141+0900 I/AUTH_ADAPTOR( 1134): auth-adaptor.c: auth_adaptor_is_auth(1141) > [34m[2567][ENTER] plugin API call -)) -)) -)) -)) -)) -)) -)) -)) -)) -))[0m
04-03 03:21:55.141+0900 I/AUTH_PLUGIN_ESU( 1134): auth-plugin-esu-internal.c: esu_internal_is_auth_sync_wrapper(994) > [34m[2569]esu_check_account_exist imsi : (null), msisdn : (null)[0m
04-03 03:21:55.141+0900 E/AUTH_PLUGIN_ESU( 1134): auth-plugin-esu-internal.c: esu_internal_is_auth_sync_wrapper(1004) > [31m[2569]esu_internal_is_auth : esu_check_account_exist request failed:(-214)[0m
04-03 03:21:55.141+0900 E/AUTH_PLUGIN_ESU( 1134): auth-plugin-esu.c: plugin_esu_is_auth(492) > [31m[2567]ERROR code 201[0m
04-03 03:21:55.141+0900 E/AUTH_PLUGIN_ESU( 1134): auth-plugin-esu.c: plugin_esu_is_auth(493) > [31m[2567]ERROR MSG ESU is not ready[0m
04-03 03:21:55.141+0900 I/AUTH_ADAPTOR( 1134): auth-adaptor.c: auth_adaptor_is_auth(1143) > [34m[2567][EXIT] plugin API called (16) ((- ((- ((- ((- ((- ((- ((- ((- ((- ((-[0m
04-03 03:21:55.141+0900 E/AUTH_ADAPTOR( 1134): auth-adaptor.c: auth_adaptor_is_auth(1143) > [31m[2567]plugin issued error (201) (ESU is not ready)[0m
04-03 03:21:55.141+0900 E/SERVICE_ADAPTOR( 1134): dbus-auth-adaptor.c: auth_adaptor_method_call(125) > [31m[2567]Is_auth Function Internal error : 4[0m
04-03 03:21:55.141+0900 E/SERVICE_ADAPTOR( 1134): dbus-auth-adaptor.c: auth_adaptor_method_call(128) > [31m[2567][201] [PLUGIN_ERROR] URI(com.samsung.coreapps), MSG(ESU is not ready)[0m
04-03 03:21:55.141+0900 I/AUTH_ADAPTOR( 1134): auth-adaptor.c: auth_adaptor_destroy_plugin_context(856) > [34m[2567][ENTER] plugin API call -)) -)) -)) -)) -)) -)) -)) -)) -)) -))[0m
04-03 03:21:55.141+0900 I/AUTH_ADAPTOR( 1134): auth-adaptor.c: auth_adaptor_destroy_plugin_context(858) > [34m[2567][EXIT] plugin API called ((- ((- ((- ((- ((- ((- ((- ((- ((- ((-[0m
04-03 03:21:55.141+0900 I/SERVICE_ADAPTOR_CLIENT( 2556): service_adaptor_client_auth.c: service_adaptor_get_auth_plugin(89) > [34m[2565]API End <service_adaptor_get_auth_plugin> :  0[0m
04-03 03:21:55.141+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2556): system_settings.c: system_settings_get_value_string(543) > Enter [system_settings_get_value_string]
04-03 03:21:55.141+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2556): system_settings.c: system_settings_get_value(404) > Enter [system_settings_get_value]
04-03 03:21:55.141+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2556): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=13
04-03 03:21:55.141+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2556): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 12, key = 13, type = 0
04-03 03:21:55.141+0900 E/SERVICE_ADAPTOR_CLIENT( 2556): service_adaptor_client_shop.c: service_adaptor_get_item_list(54) > [31m[2565]Invalid Parameter[0m
04-03 03:21:55.141+0900 E/SERVICE_ADAPTOR_CLIENT( 2556): service_adaptor_client_shop.c: service_adaptor_get_item_list(55) > [31m[2565]Error occured b : (-22) (Invalid Parameter)[0m
04-03 03:21:57.103+0900 E/PKGMGR_SERVER( 2609): pkgmgr-server.c: main(2414) > package manager server start
04-03 03:21:57.153+0900 E/PKGMGR  ( 2607): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
04-03 03:21:57.193+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-03 03:21:57.193+0900 E/AUL_AMD (  610): amd_status.c: _status_app_is_running_from_cache(827) > is_running garbage, pid: 2531
04-03 03:21:57.203+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
04-03 03:21:57.203+0900 E/PKGMGR_SERVER( 2609): pkgmgr-server.c: sighandler(417) > child NORMAL exit [2612]
04-03 03:21:59.005+0900 E/PKGMGR_SERVER( 2609): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-03 03:21:59.005+0900 E/PKGMGR_SERVER( 2609): pkgmgr-server.c: main(2471) > package manager server terminated.
04-03 03:22:00.076+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(195) > ""
04-03 03:22:00.076+0900 E/UXT     (  661): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 3:22
04-03 03:22:00.076+0900 I/INDICATOR(  661): clock.c: getTimeFormatted(176) > "time format : 오전 3:22"
04-03 03:22:00.076+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 3:22"
04-03 03:22:00.076+0900 W/INDICATOR(  661): clock.c: indicator_clock_changed_cb(272) > 
04-03 03:22:00.076+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146952688 Time: <font_size=31> </font_size> <font_size=31> 오전 3:22</font_size></font>"
04-03 03:22:01.067+0900 E/PKGMGR  ( 2699): pkgmgr.c: pkgmgr_client_reinstall(2020) > reinstall pkg start.
04-03 03:22:01.147+0900 E/PKGMGR_SERVER( 2702): pkgmgr-server.c: main(2414) > package manager server start
04-03 03:22:01.197+0900 E/PKGMGR_SERVER( 2702): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.client]
04-03 03:22:01.207+0900 E/PKGMGR_SERVER( 2702): pm-mdm.c: _get_package_info_from_file(116) > [0;31m[_get_package_info_from_file(): 116](ret < 0) access() failed. path: org.example.client errno: 2 (No such file or directory)[0;m
04-03 03:22:01.207+0900 E/PKGMGR  ( 2699): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[26990002]
04-03 03:22:01.357+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: update
04-03 03:22:01.357+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [start], Value = [update], install = [1]
04-03 03:22:01.367+0900 W/AUL_AMD (  610): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
04-03 03:22:01.367+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-03 03:22:01.367+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [30]
04-03 03:22:01.367+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
04-03 03:22:01.508+0900 W/CERT_SVC_VCORE( 2705): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-03 03:22:01.578+0900 E/rpm-installer( 2705): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
04-03 03:22:01.578+0900 E/rpm-installer( 2705): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
04-03 03:22:01.638+0900 E/PKGMGR_PARSER( 2705): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
04-03 03:22:01.648+0900 I/PRIVACY-MANAGER-CLIENT( 2705): SocketClient.cpp: SocketClient(37) > Client created
04-03 03:22:01.648+0900 I/PRIVACY-MANAGER-CLIENT( 2705): SocketClient.cpp: connect(62) > Client connected
04-03 03:22:01.648+0900 I/PRIVACY-MANAGER-SERVER(  915): SocketService.cpp: mainloop(230) > Got incoming connection
04-03 03:22:01.658+0900 I/PRIVACY-MANAGER-CLIENT( 2705): SocketClient.cpp: disconnect(72) > Client disconnected
04-03 03:22:01.658+0900 E/PKGMGR_CERT( 2705): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
04-03 03:22:01.658+0900 E/PKGMGR_CERT( 2705): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
04-03 03:22:01.668+0900 E/PKGMGR_CERT( 2705): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
04-03 03:22:01.698+0900 E/rpm-installer( 2705): coretpk-installer.c: _coretpk_installer_package_reinstall(6347) > _coretpk_installer_package_reinstall(org.example.client) failed.
04-03 03:22:01.708+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: fail
04-03 03:22:01.708+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [end], Value = [fail], install = [96]
04-03 03:22:01.708+0900 E/ESD     (  893): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
04-03 03:22:01.708+0900 W/AUL_AMD (  610): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
04-03 03:22:01.718+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.client",~) returned -1
04-03 03:22:01.718+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
04-03 03:22:02.999+0900 E/PKGMGR_SERVER( 2702): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-03 03:22:03.349+0900 E/PKGMGR_SERVER( 2702): pkgmgr-server.c: sighandler(417) > child NORMAL exit [2705]
04-03 03:22:04.701+0900 E/PKGMGR  ( 2753): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
04-03 03:22:04.731+0900 E/PKGMGR_SERVER( 2702): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk]
04-03 03:22:04.741+0900 E/PKGMGR_INFO( 2702): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] not found in DB
04-03 03:22:04.751+0900 E/rpm-installer( 2702): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
04-03 03:22:04.751+0900 E/PKGMGR_SERVER( 2702): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
04-03 03:22:04.761+0900 E/PKGMGR  ( 2753): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[27530002]
04-03 03:22:04.871+0900 E/PKGMGR_INSTALLER( 2755): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
04-03 03:22:04.871+0900 E/rpm-installer( 2755): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] is tpk package.
04-03 03:22:04.891+0900 E/rpm-installer( 2755): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
04-03 03:22:04.891+0900 E/rpm-installer( 2755): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
04-03 03:22:04.891+0900 E/rpm-installer( 2755): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-03 03:22:04.891+0900 E/rpm-installer( 2755): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
04-03 03:22:04.891+0900 E/rpm-installer( 2755): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-03 03:22:04.941+0900 W/CERT_SVC_VCORE( 2755): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-03 03:22:04.991+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: install
04-03 03:22:04.991+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [start], Value = [install], install = [96]
04-03 03:22:05.001+0900 E/PKGMGR_SERVER( 2702): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-03 03:22:05.001+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-03 03:22:05.001+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [30]
04-03 03:22:05.001+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [96]
04-03 03:22:05.191+0900 E/rpm-installer( 2755): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
04-03 03:22:05.191+0900 E/rpm-installer( 2755): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
04-03 03:22:05.191+0900 E/rpm-installer( 2755): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
04-03 03:22:05.191+0900 E/rpm-installer( 2755): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-03 03:22:05.191+0900 E/rpm-installer( 2755): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
04-03 03:22:05.191+0900 E/rpm-installer( 2755): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
04-03 03:22:05.201+0900 E/PKGMGR_PARSER( 2755): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
04-03 03:22:05.201+0900 E/PKGMGR_PARSER( 2755): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
04-03 03:22:05.241+0900 I/PRIVACY-MANAGER-CLIENT( 2755): SocketClient.cpp: SocketClient(37) > Client created
04-03 03:22:05.451+0900 E/PKGMGR_PARSER( 2755): pkgmgr_parser.c: __check_theme(142) > theme for installation.
04-03 03:22:05.471+0900 E/PKGMGR_CERT( 2755): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
04-03 03:22:05.471+0900 E/PKGMGR_CERT( 2755): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 108
04-03 03:22:05.471+0900 E/PKGMGR_CERT( 2755): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 108
04-03 03:22:05.471+0900 E/PKGMGR_CERT( 2755): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 2
04-03 03:22:05.471+0900 E/PKGMGR_CERT( 2755): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 31 3
04-03 03:22:05.471+0900 E/PKGMGR_CERT( 2755): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 32 3
04-03 03:22:05.471+0900 E/PKGMGR_CERT( 2755): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 2
04-03 03:22:05.481+0900 E/PKGMGR_CERT( 2755): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
04-03 03:22:05.481+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
04-03 03:22:05.491+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [60]
04-03 03:22:05.491+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [96]
04-03 03:22:05.501+0900 E/rpm-installer( 2755): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-03 03:22:05.521+0900 E/rpm-installer( 2755): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
04-03 03:22:05.521+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
04-03 03:22:05.521+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [100]
04-03 03:22:05.521+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [96]
04-03 03:22:07.003+0900 E/PKGMGR_SERVER( 2702): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-03 03:22:07.403+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
04-03 03:22:07.403+0900 I/Tizen::App( 1231): (78) > Installation is Completed. [Package = org.example.client]
04-03 03:22:07.403+0900 I/Tizen::App( 1231): (671) > Enter. package(org.example.client), installationResult(0)
04-03 03:22:07.403+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
04-03 03:22:07.403+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
04-03 03:22:07.403+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
04-03 03:22:07.413+0900 I/Tizen::App( 1231): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
04-03 03:22:07.453+0900 I/Tizen::App( 1231): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
04-03 03:22:07.463+0900 E/PKGMGR_SERVER( 2702): pkgmgr-server.c: sighandler(417) > child NORMAL exit [2755]
04-03 03:22:07.463+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
04-03 03:22:07.473+0900 I/Tizen::App( 1231): (416) > appName = [client]
04-03 03:22:07.473+0900 I/Tizen::App( 1231): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-03 03:22:07.473+0900 E/PKGMGR_INFO( 1231): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
04-03 03:22:07.473+0900 I/Tizen::App( 1231): (683) > Application count(1) in this package
04-03 03:22:07.473+0900 I/Tizen::App( 1231): (840) > Enter.
04-03 03:22:07.473+0900 I/Tizen::App( 1231): (703) > Exit.
04-03 03:22:07.473+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [96]
04-03 03:22:07.483+0900 I/Tizen::App( 1231): (416) > appName = [client]
04-03 03:22:07.483+0900 I/Tizen::App( 1231): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-03 03:22:07.483+0900 I/Tizen::App( 1231): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
04-03 03:22:07.483+0900 I/Tizen::App( 1231): (131) > Enter
04-03 03:22:07.493+0900 I/Tizen::App( 1231): (137) > org.example.client does not have launch condition
04-03 03:22:07.493+0900 I/Tizen::App( 1231): (883) > Exit.
04-03 03:22:07.503+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
04-03 03:22:07.503+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
04-03 03:22:07.503+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
04-03 03:22:07.503+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
04-03 03:22:07.503+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
04-03 03:22:07.513+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
04-03 03:22:07.513+0900 E/HOME_APPS(  858): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
04-03 03:22:07.513+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
04-03 03:22:07.513+0900 W/HOME_APPS(  858): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
04-03 03:22:07.533+0900 E/util-view(  858): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
04-03 03:22:07.543+0900 W/HOME_APPS(  858): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
04-03 03:22:09.005+0900 E/PKGMGR_SERVER( 2702): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-03 03:22:09.005+0900 E/PKGMGR_SERVER( 2702): pkgmgr-server.c: main(2471) > package manager server terminated.
04-03 03:22:11.788+0900 W/AUL     ( 2813): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-03 03:22:11.788+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
04-03 03:22:11.798+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-03 03:22:11.808+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-03 03:22:11.808+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-03 03:22:11.808+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 2813
04-03 03:22:11.808+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-03 03:22:11.818+0900 E/RESOURCED(  664): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
04-03 03:22:11.818+0900 E/RESOURCED(  664): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-03 03:22:11.818+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-4)
04-03 03:22:11.938+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 2815, appid: org.example.client
04-03 03:22:11.938+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-03 03:22:11.948+0900 W/AUL     ( 2813): launch.c: app_request_to_launchpad(425) > request cmd(0) result(2815)
04-03 03:22:12.939+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-03 03:22:12.939+0900 W/AUL_AMD (  610): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
04-03 03:22:16.943+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.client(2815)
04-03 03:22:16.943+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 2815, appid: org.example.client, status: bg
04-03 03:22:18.464+0900 I/abc     ( 2815): abc
04-03 03:22:18.484+0900 I/CAPI_APPFW_APPLICATION( 2815): app_main.c: ui_app_main(789) > app_efl_main
04-03 03:22:19.835+0900 I/CAPI_APPFW_APPLICATION( 2815): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-03 03:22:22.018+0900 E/TBM     ( 2815): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-03 03:22:29.875+0900 W/CRASH_MANAGER( 2837): worker.c: worker_job(1199) > 0602815636c69149115734
